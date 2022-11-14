using System;
using System.Collections.Generic;
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



        public BlockEdit(ScheduleBlock block)
        {



            InitializeComponent();

            this.block = block;

            populateRoomProperties();
            populateBlockProperties();
            checkConstraints();
            
        }

        private void populateRoomProperties()
        {
            try
            {

                this.scheduleBlockDetailsTableAdapter.FillByRoomID(this.grilDataViewsSet.ScheduleBlockDetails, this.block.Id);

                this.roomIDTB.Text = block.roomID.ToString();
                this.roomNameTB.Text = block.roomName;
                this.roomFloorTB.Text = block.roomFloor.ToString();
                this.buildingTB.Text = block.buildingName;
                this.campusTB.Text = block.campusName;

                this.allRoomsTableAdapter.ClearBeforeFill = true;
                this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, block.roomID);
            }
            catch (System.Exception ex1) { }


        }

        private void populateBlockProperties()
        {
            dayOfWeek.Text = block.DayOfWeek.ToString();
            time.Text = block.TimeToString();
            semester.Text = "not implemented";
            inUse.Text = "not implemented";


            facultyTB.Text = block.FacultyName;

            megamaTB.Text = "megama";
            mahzorTB.Text = block.DegreeClassName;
            shibutzTB.Text = "mispar shibutz";
            itraTB.Text = "mispar itra";


        }

        private void checkConstraints()
        {
            listBox.DataSource = myItems;
        }

        private void BlockEdit_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'grilDataViewsSet.ScheduleBlockDetails' table. You can move, or remove it, as needed.
            //this.scheduleBlockDetailsTableAdapter.FillByRoomID(this.grilDataViewsSet.ScheduleBlockDetails, this.block.Id);

        }

        private void BlockEdit_Load_1(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'grilDataViewsSet.AllRooms' table. You can move, or remove it, as needed.
            //this.allRoomsTableAdapter.Fill(this.grilDataViewsSet.AllRooms);

        }

        private void editBT_Click(object sender, System.EventArgs e)
        {

        }
    }
}
