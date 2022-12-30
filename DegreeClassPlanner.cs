using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Final_Project
{
    public partial class DegreeClassPlanner : Form
    {
        Semester semester;
        DegreeClass dc;
        public DegreeClassPlanner(Semester semester, DegreeClass dc)
        {
            this.semester = semester;
            this.dc = dc;
            InitializeComponent();
            fillUpperTable();
            plotGraph();
            //fillNumbers();

        }

        private void fillUpperTable()
        {

            facultyLB.Text = dc.Degree.Faculty.Name.ToString();
            megamaLB.Text = dc.Degree.Name;
            mahzorLB.Text = dc.Name;
            shanaLB.Text = semester.HebrewYear;
            semesterLB.Text = semester.SemesterType.ToString();

        }

        Dictionary<int, ScheduleBlock> dataPoints = new Dictionary<int, ScheduleBlock>();

        private void plotGraph()
        {
            try
            {
                List<ScheduleBlock> sb = ScheduleBlock.getListbyMahzorSemester(this.dc.Id, this.semester.Id);
                luz.Series.Clear();
                dataPoints.Clear();
                formatChart(dc.Name);

                String mahzor = dc.Name;
                createSerie(mahzor);

                for (int i = 1; i<7; i++)
                {
                    int p = luz.Series[mahzor].Points.AddXY(i, 7.59, 7.591);
                    dataPoints.Add(p,null);
                    luz.Series[mahzor].Points[p].Color = Color.Transparent;
                    luz.Series[mahzor].Points[p].BorderColor = Color.Transparent;
                    luz.Series[mahzor].Points[p].BorderWidth = 3;
                }

                foreach (ScheduleBlock block in sb)
                {
                    int p = luz.Series[mahzor].Points.AddXY(block.DayOfWeek, block.StartTime, block.EndTime);
                    dataPoints.Add(p, block);
                    luz.Series[mahzor].Points[p].BorderColor = Color.Black;
                    luz.Series[mahzor].Points[p].BorderWidth = 3;
                    luz.Series[mahzor].Points[p].Label = block.RoomAndTime();

                }
            }
            catch (Exception ex1) { }
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

        private void DegreeClassPlanner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grilDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.grilDataSet.Room);
            populateTree();
            populateBuildingsTree();
            fillNumbers();

        }

        private void fillNumbers()
        {
            DegreeClassPlanExecTableAdapter planexec = new DegreeClassPlanExecTableAdapter();
            DataRowCollection rows = planexec.GetDataDCSem(this.dc.Id,this.semester.Id).Rows;

            tihnunLB.Text = rows[0][5].ToString();
            hours_req.Text = tihnunLB.Text;
            bitzuaLB.Text = rows[0][6].ToString();
            hours_used.Text = bitzuaLB.Text;
            itraLB.Text = rows[0][7].ToString();
            hours_remaining.Text = itraLB.Text;
            if (int.Parse(itraLB.Text) < 0)
            {
                itraLB.ForeColor = Color.Red;
            }
            else if (int.Parse(itraLB.Text) == 0)
            {
                itraLB.ForeColor = Color.Green;
            }
        }

        private void populateTree()
        {
            treeRooms.Nodes.Clear();
            TreeNode root = treeRooms.Nodes.Add("מכללת קרית אונו");

            campusTableAdapter adapter = new campusTableAdapter();
            DataRowCollection CRows = adapter.GetData().Rows;

            for (int h = 0; h < CRows.Count; h++)
            {
                String campusName = (String)CRows[h][1];

                BuildingsByCampusTableAdapter b_adapter = new BuildingsByCampusTableAdapter();

                TreeNode campusNode = treeRooms.Nodes[0].Nodes.Add(campusName);


                DataRowCollection BRows = b_adapter.GetData(campusName).Rows;

                for (int i = 0; i < BRows.Count; i++)
                {
                    String bldName = BRows[i][0].ToString();
                    TreeNode buildingNode = treeRooms.Nodes[0].Nodes[h].Nodes.Add(bldName);

                    RoomsByCampusTableAdapter room_adap = new RoomsByCampusTableAdapter();

                    DataRowCollection roomsRows = room_adap.GetData(bldName).Rows;

                    for (int k = 0; k < roomsRows.Count; k++)
                    {
                        int roomID = (int)roomsRows[k][2];
                        String roomName = roomsRows[k][3].ToString();

                        TreeNode roomNode = treeRooms.Nodes[0].Nodes[h].Nodes[i].Nodes.Add(roomID.ToString(), roomName);

                    }

                }
            }

        }



        private void add_Click(object sender, EventArgs e)
        {
            int weekday = int.Parse(dayCB.Text);

            //DateTime startTime = startPicker.Value;
            int numberOfBlocks = int.Parse(numberOfBlocksCB.SelectedItem.ToString());

            if (selectedRoomID != -1)
            {
                int roomID = selectedRoomID;

                for (int i = 0; i < numberOfBlocks; i++)
                {
                    ScheduleBlock.insertNew(weekday, startTime, roomID, dc.Id, semester.Id);
                    startTime = startTime.AddMinutes(45);
                }
                                
                plotGraph();
                fillNumbers();
            }


        }

        private void luz_MouseClick(object sender, MouseEventArgs e)
        {

            var r = luz.HitTest(e.X, e.Y);

            if (r.ChartElementType == ChartElementType.DataPointLabel)
            {
                DataPoint p = (DataPoint)r.Object;
                int idx = r.PointIndex;
                ScheduleBlock sb = dataPoints[idx];

                BlockEdit dbfrom = new BlockEdit(sb);
                dbfrom.Show();
                dbfrom.FormClosed += Dbfrom_FormClosed;

            }

        }

        private void Dbfrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            plotGraph();
            fillNumbers(); 
        }

        int selectedRoomID = -1;
        private void treeRooms_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            //selectedRoomID = int.Parse(e.Node.Name);
            int.TryParse(e.Node.Name, out selectedRoomID);
            roomLB.Text = selectedRoomID.ToString();

            
        }

        DateTime startTime;
        DateTime endTime;
        private void minuteCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int startHour = int.Parse(hourCB.SelectedItem.ToString());
                int startMinute = int.Parse(minuteCB.SelectedItem.ToString());
                int numberOfBlocks = int.Parse(numberOfBlocksCB.SelectedItem.ToString());

                startTime = new DateTime();

                startTime = startTime.AddHours(startHour);
                startTime = startTime.AddMinutes(startMinute);

                endTime = startTime;

                endTime = endTime.AddMinutes(numberOfBlocks * 45);

                int endHour = (int)endTime.Hour;
                int endMinute = (int)endTime.Minute;

                endHourCB.Text = endHour.ToString();
                endMinutesCB.Text = endMinute.ToString();
            }
            catch (Exception)
            {

                
            }
            

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matrix_ValueChanged(object sender, EventArgs e)
        {
            updatePlannerMatrix();
        }

        private void updatePlannerMatrix()
        {

            decimal totalInMatrix = 0;
            //sun
            sun.Text = (sun_morning.Value + sun_evening.Value).ToString();
            totalInMatrix += sun_morning.Value + sun_evening.Value;

            //mon
            mon.Text = (mon_morning.Value + mon_evening.Value).ToString();
            totalInMatrix += mon_morning.Value + mon_evening.Value;

            //tue
            tue.Text = (tue_morning.Value + tue_evening.Value).ToString();
            totalInMatrix += tue_morning.Value + tue_evening.Value;

            //wed
            wed.Text = (wed_morning.Value + wed_evening.Value).ToString();
            totalInMatrix += wed_morning.Value + wed_evening.Value;

            //thu
            thu.Text = (thu_morning.Value + thu_evening.Value).ToString();
            totalInMatrix += thu_morning.Value + thu_evening.Value;

            //fri
            fri.Text = (fri_morning.Value + fri_evening.Value).ToString();
            totalInMatrix += fri_morning.Value + fri_evening.Value;

            //sat
            sat.Text = (sat_morning.Value + sat_evening.Value).ToString();
            totalInMatrix += sat_morning.Value + sat_evening.Value;

            //in plan
            hours_matrix.Text = totalInMatrix.ToString();

            //itra
            int rem = int.Parse(hours_req.Text) - int.Parse(hours_used.Text) - (int)totalInMatrix;


            hours_remaining.Text = rem.ToString();

            if (int.Parse(hours_remaining.Text) < 0)
            {
                hours_remaining.ForeColor = Color.Red;
            }
            else if (int.Parse(hours_remaining.Text) == 0)
            {
                hours_remaining.ForeColor = Color.Green;
            }
        }

        int selectedBuildingID = -1;
        private void treeBuildings_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            int.TryParse(e.Node.Name, out selectedBuildingID);
            selected_building.Text = e.Node.Text;
        }

        private void populateBuildingsTree()
        {
            treeBuildings.Nodes.Clear();
            TreeNode root = treeBuildings.Nodes.Add("מכללת קרית אונו");

            campusTableAdapter adapter = new campusTableAdapter();
            DataRowCollection CRows = adapter.GetData().Rows;

            for (int h = 0; h < CRows.Count; h++)
            {
                String campusName = (String)CRows[h][1];

                BuildingsByCampusTableAdapter b_adapter = new BuildingsByCampusTableAdapter();

                TreeNode campusNode = treeBuildings.Nodes[0].Nodes.Add(campusName);


                DataRowCollection BRows = b_adapter.GetData(campusName).Rows;

                for (int i = 0; i < BRows.Count; i++)
                {
                    String bldName = BRows[i][0].ToString();
                    int bldID = (int)BRows[i][2];
                    TreeNode buildingNode = treeBuildings.Nodes[0].Nodes[h].Nodes.Add(bldID.ToString(),bldName);
                }
            }

        }
    }
}
