using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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

        }

        private void fillUpperTable()
        {

            facultyLB.Text = dc.Degree.FacultyID.ToString();
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

                foreach (ScheduleBlock block in sb)
                {
                    String mahzor = dc.Name;

                    createSerie(mahzor);

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

        }

        private void add_Click(object sender, EventArgs e)
        {
            int weekday = int.Parse(dayCB.Text);

            DateTime time = TimePicker.Value;

            DataRowView row = (DataRowView)roomCB.SelectedItem;

            if (row != null)
            {
                int roomID = (int)row.Row[0];
                ScheduleBlock.saveToDB(weekday, time, roomID, dc.Id, semester.Id);
                plotGraph();
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
            }

        }
    }
}
