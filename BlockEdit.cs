using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class BlockEdit : Form
    {

        ScheduleBlock block;
        List<string> myItems = new List<string>();
        List<Constraint> constraints = new List<Constraint>();

        /*
         * this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);
         */

        private string[] days = { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי", "שבת" };


        public BlockEdit(ScheduleBlock block)
        {

            InitializeComponent();
            this.block = ScheduleBlock.getFromDB(block.Id);

            
            populateRoomProperties();
            populateDCProperties();
            populateBlockProperties();
            /*
            checkConstraints();
            */


        }

        private void BlockEdit_Load(object sender, System.EventArgs e)
        {
            checkConstraints();
        }

        private void ChangePB(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Eval(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            bw.ReportProgress(50);
            constraints = Evaluator.evaluate(this.block);
            bw.ReportProgress(100);
        }


        private void populateRoomProperties()
        {
            try
            {
                this.roomIDTB.Text = block.room.Id.ToString();
                this.roomNameTB.Text = block.room.Name;
                this.roomFloorTB.Text = block.room.Floor.ToString();
                this.buildingTB.Text = block.room.building.Name;
                this.campusTB.Text = block.room.building.Campus.Name;

                this.allRoomsTableAdapter.ClearBeforeFill = true;
                this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, block.room.Id);
            }
            catch (System.Exception ex1) { }


        }

        private void populateDCProperties()
        {
            try
            {
                this.roomIDTB.Text = block.room.Id.ToString();
                this.roomNameTB.Text = block.room.Name;
                this.roomFloorTB.Text = block.room.Floor.ToString();
                this.buildingTB.Text = block.room.building.Name;
                this.campusTB.Text = block.room.building.Campus.Name;

                this.dCFeaturesTableAdapter.ClearBeforeFill = true;
                this.dCFeaturesTableAdapter.Fill(this.grilDataViewsSet.DCFeatures, block.degreeClass.Id);
            }
            catch (System.Exception ex1) { }


        }

        private void populateBlockProperties()
        {
            dayOfWeek.Text = days[block.DayOfWeek - 1];

            time.Text = block.TimeToString();
            semester.Text = block.semester.ToString();

            CoursePlacementTableAdapter cpta = new CoursePlacementTableAdapter();
            DataRowCollection rows = cpta.GetDataBySBID(block.Id).Rows;

            inUse.Text = (rows.Count != 0) ? "כן" : "לא";

            facultyTB.Text = block.degreeClass.Degree.Faculty.Name;

            megamaTB.Text = block.degreeClass.Degree.Name;
            mahzorTB.Text = block.degreeClass.Name;

            commentsBox.Text = block.comments;

            DegreeClassPlanExecTableAdapter planExe = new DegreeClassPlanExecTableAdapter();
            DataRowCollection rows1 = planExe.GetDataDCSem(block.degreeClass.Id, block.semester.Id).Rows;

            if (rows1.Count != 0)
            {
                shibutzTB.Text = rows1[0][6].ToString();
                itraTB.Text = rows1[0][7].ToString();
                itraTB.RightToLeft = RightToLeft.No;
                if ((int)rows1[0][7] < 0)
                {
                    itraTB.ForeColor = Color.Red;
                }
                else if ((int)rows1[0][7] == 0)
                {
                    itraTB.ForeColor = Color.Green;
                }
            }
            else
            {
                shibutzTB.Text = " ";
                itraTB.Text = " ";
            }


        }

        private void checkConstraints()
        {

            Image[] img_arr = new Image[3];
            //Image loading_img = Image.FromFile(global::Final_Project.Properties.Resources.)
            img_arr[0] = global::Final_Project.Properties.Resources.icons8_intersect_25;
            //img_arr[1] = global::Final_Project.Properties.Resources.icons8_error_25;
            //img_arr[2] = global::Final_Project.Properties.Resources.icons8_high_priority_25;

            //start icons:
            /*
            shabat_st_ico.Image = img_arr[0];
            friday_stat_ico.Image = img_arr[0];
            simul_stat_ico.Image = img_arr[0];
            overlap_stat_ico.Image = img_arr[0];
            cap_stat_ico.Image = img_arr[0];
            movem_stat_ico.Image = img_arr[0];
            spacing_stat_ico.Image = img_arr[0];
            */

            //BW HERE
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.DoWork += Eval;
            bw.ProgressChanged += ChangePB;
            bw.RunWorkerCompleted += UpdateTable;
            bw.RunWorkerAsync();
            

        }

        private void UpdateTable(object sender, RunWorkerCompletedEventArgs e)
        {

            Image[] img_arr = new Image[3];
            img_arr[0] = global::Final_Project.Properties.Resources.icons8_approval_25;
            img_arr[1] = global::Final_Project.Properties.Resources.icons8_error_25;
            img_arr[2] = global::Final_Project.Properties.Resources.icons8_high_priority_25;

            //start icons:
            shabat_st_ico.Image = img_arr[0];
            friday_stat_ico.Image = img_arr[0];
            simul_stat_ico.Image = img_arr[0];
            overlap_stat_ico.Image = img_arr[0];
            cap_stat_ico.Image = img_arr[0];
            movem_stat_ico.Image = img_arr[0];
            spacing_stat_ico.Image = img_arr[0];

            foreach (Constraint c in constraints)
            {


                if (c.typeOfConstraint == Constraint.Type.Timing_Saturday)
                {
                    //Stat-icon
                    shabat_st_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //shabat_txt.Text = "לא ניתן להקצות בשבת";
                    shabat_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Timing_Friday)
                {
                    //Stat-icon
                    friday_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //friday_txt.Text = "לא ניתן להקצות בשישי בשעה מאוחרת";
                    friday_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Simultaneous)
                {
                    //Stat-icon
                    simul_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //simul_txt.Text = "קיים שיבוץ בו זמנית במקום אחר";
                    simul_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Overlap)
                {
                    //Stat-icon
                    overlap_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //overlap_txt.Text = "קיימת חפיפה בין הקצאות";
                    overlap_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Capacity)
                {
                    //Stat-icon
                    cap_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //cap_txt.Text = "שים לב לקיבולת החדר";
                    cap_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Movement)
                {
                    //Stat-icon
                    movem_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //movem_txt.Text = "הקצאה זו גורמת לתזוזה בקמפוס";
                    movem_txt.Text = c.Comment;
                }
                if (c.typeOfConstraint == Constraint.Type.Spacing)
                {
                    //Stat-icon
                    spacing_stat_ico.Image = img_arr[(int)c.constraintSeverity];
                    //Stat-text
                    //spacing_txt.Text = "אין מספיק מרווח בין מחזורים שונים";
                    spacing_txt.Text = c.Comment;
                }
            }
        }

        private void editBT_Click(object sender, System.EventArgs e)
        {

        }

        private void deleteBT_Click(object sender, EventArgs e)
        {
            String msg = $"האם בטוח שרוצה למחוק את הבלוק?";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yesno == DialogResult.Yes)
            {
                if (ScheduleBlock.deleteFromDB(this.block.Id))
                {
                    MessageBox.Show("בלוק נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void commentsBox_Validated(object sender, EventArgs e)
        {
            block.updateComments(commentsBox.Text);
        }
    }
}
