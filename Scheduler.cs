using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final_Project
{
    public partial class Scheduler : Form
    {
        public Scheduler()
        {
            InitializeComponent();
        }

        private void Scheduler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grilDataViewsSet.DegreeClassPlanExec' table. You can move, or remove it, as needed.
            this.degreeClassPlanExecTableAdapter.Fill(this.grilDataViewsSet.DegreeClassPlanExec);
            // TODO: This line of code loads data into the 'grilDataSet.Semester' table. You can move, or remove it, as needed.
            this.semesterTableAdapter.Fill(this.grilDataSet.Semester);
            // TODO: This line of code loads data into the 'grilDataSet.campus' table. You can move, or remove it, as needed.
            this.campusTableAdapter.Fill(this.grilDataSet.campus);
            // TODO: This line of code loads data into the 'grilDataViewsSet.ScheduleBlockDetails' table. You can move, or remove it, as needed.
            //this.scheduleBlockDetailsTableAdapter.Fill(this.grilDataViewsSet.ScheduleBlockDetails);
            this.roomsByCampusTableAdapter.FillAll(this.grilDataViewsSet.RoomsByCampus);

        }


        private void campusCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            populateTree(campusCB.Text);

        }


        private void populateTree(String campusName)
        {
            treeRooms.Nodes.Clear();
            TreeNode root = treeRooms.Nodes.Add(campusName);

            this.buildingsByCampusTableAdapter.Fill(this.grilDataViewsSet.BuildingsByCampus, campusName);
            DataRowCollection BRows = this.buildingsByCampusTableAdapter.GetData(campusName).Rows;

            for (int i = 0; i < BRows.Count; i++)
            {
                String bldName = BRows[i][0].ToString();
                TreeNode buildingNode = treeRooms.Nodes[0].Nodes.Add(bldName);

                this.roomsByCampusTableAdapter.Fill(this.grilDataViewsSet.RoomsByCampus, bldName);
                DataRowCollection roomsRows = this.roomsByCampusTableAdapter.GetData(bldName).Rows;

                for (int k = 0; k < roomsRows.Count; k++)
                {
                    int roomID = (int)roomsRows[k][2];
                    String roomName = roomsRows[k][3].ToString();

                    TreeNode roomNode = treeRooms.Nodes[0].Nodes[i].Nodes.Add(roomID.ToString(), roomName);

                }

            }

        }

        Dictionary<int, ScheduleBlock> dataPoints = new Dictionary<int, ScheduleBlock>();

        private void treeRooms_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                int selectedRoomID = int.Parse(e.Node.Name);

                List<ScheduleBlock> sb = getList(selectedRoomID);
                luz.Series.Clear();
                dataPoints.Clear();
                formatChart(e.Node.Text);

                foreach (ScheduleBlock block in sb)
                {
                    //Enable for different series
                    //String faculty = block.FacultyName;
                    //Remove this line if various series is option
                    String faculty = e.Node.Text;

                    createSerie(faculty);

                    int p = luz.Series[faculty].Points.AddXY(block.DayOfWeek, block.StartTime, block.EndTime);
                    dataPoints.Add(p, block);
                    luz.Series[faculty].Points[p].BorderColor = Color.Black;
                    luz.Series[faculty].Points[p].BorderWidth = 3;
                    luz.Series[faculty].Points[p].Label = block.ToString();

                }
            }catch(Exception e1) { }


        }

        private List<ScheduleBlock> getList(int RoomID)
        {
            List<ScheduleBlock> list = new List<ScheduleBlock>();
            DataRowCollection rows = this.scheduleBlockDetailsTableAdapter.GetDataByRoomID(RoomID).Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                int id = (int)rows[i][0];
                int dayOfWeek = (int)rows[i][1];
                TimeSpan begda = (TimeSpan)rows[i][2];
                TimeSpan endda = (TimeSpan)rows[i][3];

                ScheduleBlock sb = new ScheduleBlock(id, dayOfWeek, begda, endda);
                sb.DegreeClassName = (String)(rows[i][9]);
                sb.FacultyName = (String)(rows[i][10]);

                list.Add(sb);

            }

            return list;

        }

        private void createSerie(String seriesName)
        {
            if (luz.Series.FindByName(seriesName) == null)
            {
                luz.Series.Add(seriesName);

                luz.Series[seriesName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
                luz.Series[seriesName].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                luz.Series[seriesName].YValuesPerPoint = 2;
                luz.Series[seriesName].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }
        }

        private void formatChart(String roomName)
        {

            String chartName = roomName;
            luz.ChartAreas.Clear();
            luz.Titles.Clear();

            luz.Titles.Add(chartName);
            luz.ChartAreas.Add(chartName);
             

            luz.ChartAreas[chartName].AxisX.Maximum = 7;
            luz.ChartAreas[chartName].AxisX.Minimum = 0;
            luz.ChartAreas[chartName].AxisX.Interval = 1;
            luz.ChartAreas[chartName].AxisX.LabelStyle.Enabled = Enabled;


            luz.ChartAreas[chartName].AxisY.Maximum = 22.3;
            luz.ChartAreas[chartName].AxisY.Minimum = 8;
            luz.ChartAreas[chartName].AxisY.Interval = 1;
            luz.ChartAreas[chartName].AxisY.IsReversed = true;
        }

        private void semesterCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                DataRowView row = (DataRowView)semesterCB.SelectedItem;
                if (row != null)
                {
                    int semesterID = (int)row.Row[0];
                    this.degreeClassPlanExecTableAdapter.FillByItra(this.grilDataViewsSet.DegreeClassPlanExec, semesterID);
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void luz_Click(object sender, EventArgs e)
        {

            



        }

        private void luz_MouseClick(object sender, MouseEventArgs e)
        {
            var r = luz.HitTest(e.X, e.Y);

            if (r.ChartElementType == ChartElementType.DataPointLabel)
            {
                DataPoint p = (DataPoint)r.Object;
                int idx = r.PointIndex;
                ScheduleBlock sb = dataPoints[idx];
                MessageBox.Show(sb.ToString());

                BlockEdit dbfrom = new BlockEdit(sb);
                dbfrom.Show();
            }
        }
    }
}
