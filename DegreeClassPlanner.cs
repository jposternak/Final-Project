using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Dictionary<int, ScheduleBlock> draftDataPoints = new Dictionary<int, ScheduleBlock>();
        List<ScheduleBlock> draftBlocks = new List<ScheduleBlock>();

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

                for (int i = 1; i < 7; i++)
                {
                    int p = luz.Series[mahzor].Points.AddXY(i, 7.59, 7.591);
                    dataPoints.Add(p, null);
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
            minuteCB_SelectedIndexChanged(sender, e);

        }

        private void fillNumbers()
        {
            DegreeClassPlanExecTableAdapter planexec = new DegreeClassPlanExecTableAdapter();
            DataRowCollection rows = planexec.GetDataDCSem(this.dc.Id, this.semester.Id).Rows;

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


        #region automatic planner
        private void matrix_ValueChanged(object sender, EventArgs e)
        {
            updatePlannerMatrix();
        }

        int[,] draftMatrix = new int[7, 2];
        private void updatePlannerMatrix()
        {

            decimal totalInMatrix = 0;
            //sun
            draftMatrix[0, 0] = (int)sun_morning.Value;
            draftMatrix[0, 1] = (int)sun_evening.Value;
            sun.Text = (sun_morning.Value + sun_evening.Value).ToString();
            totalInMatrix += sun_morning.Value + sun_evening.Value;

            //mon
            draftMatrix[1, 0] = (int)mon_morning.Value;
            draftMatrix[1, 1] = (int)mon_evening.Value;
            mon.Text = (mon_morning.Value + mon_evening.Value).ToString();
            totalInMatrix += mon_morning.Value + mon_evening.Value;

            //tue
            draftMatrix[2, 0] = (int)tue_morning.Value;
            draftMatrix[2, 1] = (int)tue_evening.Value;
            tue.Text = (tue_morning.Value + tue_evening.Value).ToString();
            totalInMatrix += tue_morning.Value + tue_evening.Value;

            //wed
            draftMatrix[3, 0] = (int)wed_morning.Value;
            draftMatrix[3, 1] = (int)wed_evening.Value;
            wed.Text = (wed_morning.Value + wed_evening.Value).ToString();
            totalInMatrix += wed_morning.Value + wed_evening.Value;

            //thu
            draftMatrix[4, 0] = (int)thu_morning.Value;
            draftMatrix[4, 1] = (int)thu_evening.Value;
            thu.Text = (thu_morning.Value + thu_evening.Value).ToString();
            totalInMatrix += thu_morning.Value + thu_evening.Value;

            //fri
            draftMatrix[5, 0] = (int)fri_morning.Value;
            draftMatrix[5, 1] = (int)fri_evening.Value;
            fri.Text = (fri_morning.Value + fri_evening.Value).ToString();
            totalInMatrix += fri_morning.Value + fri_evening.Value;

            //sat
            draftMatrix[6, 0] = (int)sat_morning.Value;
            draftMatrix[6, 1] = (int)sat_evening.Value;
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
                    TreeNode buildingNode = treeBuildings.Nodes[0].Nodes[h].Nodes.Add(bldID.ToString(), bldName);
                }
            }

        }


        private void plotDraft()
        {
            //BackgroundWorker bw = sender as BackgroundWorker;

            //draftMatrix[dayofweek-1,morning = 0 / evening =1]

            if (draftBlocks.Count > 0)
            {

                for (int m = 0; m < 7; m++)
                {

                    int p = luz.Series[draftName].Points.AddXY(m + 1, 7.59, 7.591);
                    draftDataPoints.Add(p, null);
                    luz.Series[draftName].Points[p].Color = Color.Transparent;
                    luz.Series[draftName].Points[p].BorderColor = Color.Transparent;
                    luz.Series[draftName].Points[p].BorderWidth = 3;
                }

                //for plot from the draft list

                foreach (ScheduleBlock sbDraft in draftBlocks)
                {
                    int p1 = luz.Series[draftName].Points.AddXY(sbDraft.DayOfWeek, sbDraft.StartTime, sbDraft.EndTime);
                    draftDataPoints.Add(p1, sbDraft);
                    luz.Series[draftName].Points[p1].BorderColor = Color.Black;
                    luz.Series[draftName].Points[p1].BorderWidth = 3;
                    luz.Series[draftName].Points[p1].Label = sbDraft.room.ToString();
                    luz.Series[draftName].Points[p1].Color = Color.Orange;
                }
            }
            else
            {
                luz.Series[draftName].Points.Clear();
            }

        }


        private void createDraft(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            //draftMatrix[dayofweek-1,morning = 0 / evening =1]
            for (int m = 0; m < draftMatrix.GetLength(0); m++)
            {
                int progress = (int)((m * 1.0) / draftMatrix.GetLength(0)) * 100;

                for (int n = 0; n < draftMatrix.GetLength(1); n++)
                {
                    if (draftMatrix[m, n] > 0)
                    {
                        int numOfBlocks = draftMatrix[m, n];
                        TimeSpan StartTime = new TimeSpan(0, 0, 0, 0);
                        if (n == 0)
                        {
                            //morning
                            StartTime = StartTime.Add(TimeSpan.FromHours(8));
                            //ENDTIME===>>.Add(TimeSpan.FromMinutes(numOfBlocks * 45));

                        }
                        else if (n == 1)
                        {
                            //evening
                            StartTime = StartTime.Add(TimeSpan.FromHours(16));
                        }

                        ScheduleBlock sbDraft = new ScheduleBlock(0, m + 1, StartTime);
                        sbDraft.setStartTime(StartTime, numOfBlocks);
                        sbDraft.degreeClass = dc;
                        sbDraft.semester = semester;

                        List<Room> roomsInBuilding = Building.getBuildingRooms(selectedBuildingID);

                        for (int j = 0; j < roomsInBuilding.Count; j++)
                        {
                            sbDraft.room = roomsInBuilding[j];
                            List<Constraint> list = Evaluator.evaluate(sbDraft);
                            if (list.Count == 0)
                            {
                                //draftDataPoints.Add(j, sbDraft);
                                draftBlocks.Add(sbDraft);
                                break;
                            }
                        }

                    }
                }
                bw.ReportProgress(progress);
            }

            bw.ReportProgress(100);
        }

        String draftName = "draft";
        private void searchBT_Click(object sender, EventArgs e)
        {

            createSerie(draftName);

            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += createDraft;
            bw.ProgressChanged += ChangePB;
            bw.RunWorkerCompleted += DraftIsReady;
            bw.RunWorkerAsync();

        }

        private void DraftIsReady(object sender, RunWorkerCompletedEventArgs e)
        {
            //plot 
            plotDraft();

            //clear matrix and table
            sun_morning.Value = 0;
            sun_evening.Value = 0;

            mon_morning.Value = 0;
            mon_evening.Value = 0;

            tue_morning.Value = 0;
            tue_evening.Value = 0;

            wed_morning.Value = 0;
            wed_evening.Value = 0;

            thu_morning.Value = 0;
            thu_evening.Value = 0;

            fri_morning.Value = 0;
            fri_evening.Value = 0;

            sat_morning.Value = 0;
            sat_evening.Value = 0;

            updatePlannerMatrix();

            //open button for save
            saveDraft.Enabled = true;

            //close button of draft
            searchBT.Enabled = false;

        }

        private void ChangePB(object sender, ProgressChangedEventArgs e)
        {
            draftPB.Value = e.ProgressPercentage;
        }

        #endregion

        private void saveDraft_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < draftDataPoints.Count; i++)
            {
                ScheduleBlock draftSB = draftDataPoints[i];
                if (draftSB != null)
                {
                    int weekDay = draftSB.DayOfWeek;

                    int numberOfBlocks = (int)Math.Round((draftSB.EndTimeT.TotalMinutes - draftSB.StartTimeT.TotalMinutes) / 45);

                    int roomID = draftSB.room.Id;
                    DateTime start = new DateTime();

                    start = start.AddHours(draftSB.StartTimeT.Hours);
                    start = start.AddMinutes(draftSB.StartTimeT.Minutes);

                    for (int k = 0; k < numberOfBlocks; k++)
                    {
                        ScheduleBlock.insertNew(weekDay, start, roomID, dc.Id, semester.Id);
                        start = start.AddMinutes(45);
                    }

                }

            }

            plotGraph();
            draftDataPoints.Clear();
            searchBT_Click(null, null);


            //clear draft data points
            //close button for save
            saveDraft.Enabled = false;

            //open button of draft
            searchBT.Enabled = true;

            //delete draft
            draftBlocks.Clear();
            //replot draft
            plotDraft();

            //success message
            MessageBox.Show("Great Success");

        }


    }

}
