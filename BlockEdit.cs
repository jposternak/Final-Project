using Final_Project.grilDataSetTableAdapters;
using Final_Project.grilDataViewsSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class BlockEdit : Form
    {

        ScheduleBlock block;
        List<string> myItems = new List<string> ();


        /*
         * this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);
         */

        private string[] days = { "ראשון","שני","שלישי","רביעי","חמישי","שישי","שבת" };


        public BlockEdit(ScheduleBlock block)
        {

            InitializeComponent();

            this.block = ScheduleBlock.getFromDB(block.Id);

            populateRoomProperties();
            populateBlockProperties();
            checkConstraints();
            
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

        private void populateBlockProperties()
        {
            dayOfWeek.Text = days[block.DayOfWeek - 1] ;

            time.Text = block.TimeToString();
            semester.Text = block.semester.ToString();

            CoursePlacementTableAdapter cpta = new CoursePlacementTableAdapter();
            DataRowCollection rows = cpta.GetDataBySBID(block.Id).Rows;
            
            inUse.Text = (rows.Count != 0) ? "כן" : "לא";

            facultyTB.Text = block.degreeClass.Degree.Faculty.Name;
            
            megamaTB.Text = block.degreeClass.Degree.Name;
            mahzorTB.Text = block.degreeClass.Name;

            DegreeClassPlanExecTableAdapter planExe = new DegreeClassPlanExecTableAdapter();
            DataRowCollection rows1 = planExe.GetDataDCSem(block.degreeClass.Id,block.semester.Id).Rows;

            if (rows1.Count != 0)
            {
                shibutzTB.Text = rows1[0][6].ToString();
                itraTB.Text = rows1[0][7].ToString();
                itraTB.RightToLeft = RightToLeft.No;
                if ((int)rows1[0][7] < 0)
                {
                    itraTB.ForeColor = Color.Red;
                }
                else if((int)rows1[0][7] == 0)
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
            listBox.DataSource = myItems;
        }

        private void BlockEdit_Load(object sender, System.EventArgs e)
        {
            //this.previousWindow = sender;

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
    }
}
