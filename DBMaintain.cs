using System;
using System.Data;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class DBMaintain : Form
    {
        public DBMaintain()
        {
            InitializeComponent();
        }

        private void DBMaintain_Load(object sender, EventArgs e)
        {


            try
            {
                this.buildingTableAdapter.ClearBeforeFill = true;
                this.campusTableAdapter.ClearBeforeFill = true;
                this.featuresTableAdapter.ClearBeforeFill = true;
                this.campusTableAdapter.ClearBeforeFill = true;
                this.allRoomsTableAdapter.ClearBeforeFill = true;
                this.degreeClassTableAdapter.ClearBeforeFill = true;
                this.degreeTableAdapter.ClearBeforeFill = true;
                this.facultyTableAdapter.ClearBeforeFill = true;

                // TODO: This line of code loads data into the 'grilDataSet.Semester' table. You can move, or remove it, as needed.
                this.semesterTableAdapter.Fill(this.grilDataSet.Semester);
                // TODO: This line of code loads data into the 'grilDataSet.Features' table. You can move, or remove it, as needed.
                this.featuresTableAdapter.Fill(this.grilDataSet.Features);

                // TODO: This line of code loads data into the 'grilDataSet.Building' table. You can move, or remove it, as needed.
                this.buildingTableAdapter.Fill(this.grilDataSet.Building);
                // TODO: This line of code loads data into the 'grilDataSet.campus' table. You can move, or remove it, as needed.
                this.campusTableAdapter.Fill(this.grilDataSet.campus);

                // TODO: This line of code loads data into the 'grilDataSet.DegreeClass' table. You can move, or remove it, as needed.
                //this.degreeClassTableAdapter.Fill(this.grilDataSet.DegreeClass);
                // TODO: This line of code loads data into the 'grilDataSet.Degree' table. You can move, or remove it, as needed.
                this.degreeTableAdapter.Fill(this.grilDataSet.Degree);
                // TODO: This line of code loads data into the 'grilDataSet.Faculty' table. You can move, or remove it, as needed.
                this.facultyTableAdapter.Fill(this.grilDataSet.Faculty);
            }
            catch (Exception ex)
            {

            }
        }

        private void BackToMenuBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Campus Data
        DataGridViewCellCollection currentCampusRow;

        //Update - Campus Data
        private void dataGridCampus_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection currentCell = dataGridCampus.Rows[e.RowIndex].Cells;
            int cid = (int)currentCell[0].Value;
            String cname = (String)currentCell[1].Value;
            this.campusTableAdapter.UpdateQuery(cname, cid);
        }

        private void dataGridCampus_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridView aa = (DataGridView)sender;
            int cid = (int)aa.CurrentRow.Cells[0].Value;
            this.campusTableAdapter.DeleteQuery(cid);
        }

        private void dataGridCampus_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentCampusRow = dataGridCampus.Rows[e.RowIndex].Cells;
        }

        private void newCampusBT_Click(object sender, EventArgs e)
        {
            this.grilDataSet.campus.campusIDColumn.AutoIncrement = true;
            this.campusTableAdapter.InsertQuery("--חדש--");
            this.buildingTableAdapter.Fill(this.grilDataSet.Building);
        }
        #endregion

        #region Rooms and Features

        private void roomsCampusCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                String campusSelection = roomsCampusCB.Text;
                this.roomsByCampusTableAdapter.Fill(this.grilDataViewsSet.RoomsByCampus, campusSelection);
                this.buildingsByCampusTableAdapter.Fill(this.grilDataViewsSet.BuildingsByCampus, roomsCampusCB.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void campusNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (campusNameComboBox.Text != "")
                {
                    this.roomsByCampusTableAdapter.Fill(this.grilDataViewsSet.RoomsByCampus, campusNameComboBox.Text);
                }
            }
            catch (Exception ex1)
            {

            }
        }

        private void roomsDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int roomID = (int)roomsDataGrid.Rows[e.RowIndex].Cells[0].Value;
                this.roomTableAdapter.FillByRoomID(this.grilDataSet.Room, roomID);
                this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);


            }
            catch (Exception ex2)
            {

            }
        }

        private void roomEditBT_Click(object sender, EventArgs e)
        {
            roomNameTB.Enabled = true;
            roomFloorTB.Enabled = true;
            roomBuildingCB.Enabled = true;
        }

        private void roomSaveBT_Click(object sender, EventArgs e)
        {

            int roomId = int.Parse(roomIDTB.Text);
            String roomName = roomNameTB.Text;
            int floor = int.Parse(roomFloorTB.Text);

            DataRowView aa = (DataRowView)roomBuildingCB.SelectedItem;
            int buildingID = (int)aa.Row[0];
            int campusID = (int)aa.Row[2];

            //String roomCampusName = campusTableAdapter.GetData().campusNameColumn[campusID];


            //New Room - insert           
            if (int.Parse(roomIDTB.Text) == -1)
            {
                this.roomTableAdapter.InsertQuery(roomName, floor, buildingID);
            }
            else //existing - update
            {
                this.roomTableAdapter.UpdateQuery(roomName, floor, buildingID, roomId);
            }

            MessageBox.Show("הנתונים עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            campusNameComboBox_SelectedIndexChanged(null, null);

            roomNameTB.Enabled = false;
            roomFloorTB.Enabled = false;
            roomBuildingCB.Enabled = false;

        }

        private void roomNewBT_Click(object sender, EventArgs e)
        {

            roomIDTB.Text = "-1";
            roomNameTB.Text = "-";
            roomFloorTB.Text = "-";
            roomBuildingCB.Text = "-";

            //Show message to remember hit save

            roomNameTB.Enabled = true;
            roomFloorTB.Enabled = true;
            roomBuildingCB.Enabled = true;

            MessageBox.Show("לאחר עדכון הפרטים לחץ על שמור", "חדר חדש נוצר", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void roomDeleteBT_Click(object sender, EventArgs e)
        {
            //ask if sure
            int roomId = int.Parse(roomIDTB.Text);
            String roomName = roomNameTB.Text;
            String buildingName = roomBuildingCB.Text;

            String msg = $"האם בטוח שרוצה למחוק את החדר?\n{roomName} - {buildingName}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {
                try
                {
                    this.roomTableAdapter.DeleteQuery(roomId);
                    MessageBox.Show("החדר נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    campusNameComboBox_SelectedIndexChanged(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("לא ניתן למחוק חדר, בדוק שלא מקושר לשום דבר", "שגיאה!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }



        int featureIDfromMenu;
        int featureID;

        private void featuresMenuGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            featureIDfromMenu = (int)featuresMenuGrid.Rows[e.RowIndex].Cells[0].Value;
        }

        private void addFeatureToRoomBT_Click(object sender, EventArgs e)
        {
            int roomID = int.Parse(roomIDTB.Text);

            //Check if Feature Exists already

            //if not, then check if a qualifier is needed, if it does, ask for it

            //add to DB and update table view
            this.roomFeaturesTableAdapter.InsertQuery(roomID, featureIDfromMenu, 1);
            MessageBox.Show("הנתונים עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);


        }


        private void roomFeaturesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            featureID = (int)roomFeaturesGridView.Rows[e.RowIndex].Cells[1].Value;
        }

        private void removeFeatureFromRoomBT_Click(object sender, EventArgs e)
        {
            int roomID = int.Parse(roomIDTB.Text);

            String msg = $"האם בטוח שרוצה למחוק את המאפיין?\n{roomID} - {featureID}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {

                this.roomFeaturesTableAdapter.DeleteQuery(roomID, featureID);
                MessageBox.Show("המאפיין נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);

            }

        }


        private void roomFeaturesGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int roomID = (int)roomFeaturesGridView.Rows[e.RowIndex].Cells[0].Value;
            int featureID = (int)roomFeaturesGridView.Rows[e.RowIndex].Cells[1].Value;
            int qualifier = (int)roomFeaturesGridView.Rows[e.RowIndex].Cells[4].Value;

            if (roomID > 0 && featureID > 0 && qualifier > 0)
            {
                this.roomFeaturesTableAdapter.UpdateQuery(qualifier, roomID, featureID);
                this.allRoomsTableAdapter.FillByRoomID(this.grilDataViewsSet.AllRooms, roomID);
            }
        }






        #endregion


        #region Features Tables

        //Update Features
        private void features_gridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection currentCell = features_gridView.Rows[e.RowIndex].Cells;
            int fid = (int)currentCell[0].Value;
            String fName = (String)currentCell[1].Value;
            Boolean fqual = (Boolean)currentCell[2].Value;
            this.featuresTableAdapter.UpdateQuery(fName, fqual, fid);
        }

        private void addFeatureBT_Click(object sender, EventArgs e)
        {
            this.featuresTableAdapter.InsertQuery("--חדש--", false);
            this.featuresTableAdapter.Fill(this.grilDataSet.Features);
        }


        private void features_gridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //currentCampusRow = dataGridCampus.Rows[e.RowIndex].Cells;
            //currentFeatureRow = .Rows[e.RowIndex];
            int rowNum = (int)features_gridView.Rows[e.RowIndex].Cells[0].Value;
            featureLabel.Text = rowNum.ToString();
            removeFeatBT.Text = $"מחק מאפיין {(String)features_gridView.Rows[e.RowIndex].Cells[1].Value}";
        }

        private void removeFeatBT_Click(object sender, EventArgs e)
        {
            int fid = int.Parse(featureLabel.Text);
            this.featuresTableAdapter.DeleteQuery(fid);
            this.featuresTableAdapter.Fill(this.grilDataSet.Features);
        }
        #endregion


        #region Semester Data
        int semesterNumCurrent;

        private void SemesterDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //populate the fields
            semesterNumCurrent = (int)SemesterDataGridView.Rows[e.RowIndex].Cells[0].Value;
            String semesterYear = (String)SemesterDataGridView.Rows[e.RowIndex].Cells[1].Value;
            String semesterType = (String)SemesterDataGridView.Rows[e.RowIndex].Cells[2].Value;
            DateTime semesterBegda = (DateTime)SemesterDataGridView.Rows[e.RowIndex].Cells[3].Value;
            DateTime semesterEndda = (DateTime)SemesterDataGridView.Rows[e.RowIndex].Cells[4].Value;

            SemesterYearCB.Text = semesterYear;
            semesterTypeCB.Text = semesterType;
            begdaSemesterPicker.Value = semesterBegda;
            enddaSemesterPicker.Value = semesterEndda;
        }

        private void saveSemesterBT_Click(object sender, EventArgs e)
        {
            //semesterNumCurrent

            String semesterYear = SemesterYearCB.Text;
            String semesterType = semesterTypeCB.Text;
            DateTime semesterBegda = begdaSemesterPicker.Value;
            DateTime semesterEndda = enddaSemesterPicker.Value;

            if (semesterNumCurrent == -1) //Means needs to create semester
            {
                this.semesterTableAdapter.InsertQuery(semesterYear, semesterType, semesterBegda.ToString(), semesterEndda.ToString());
            }
            else
            {
                this.semesterTableAdapter.UpdateQuery(semesterYear, semesterType, semesterBegda.ToString(), semesterEndda.ToString(), semesterNumCurrent);
            }
            MessageBox.Show("הנתונים עודכנו בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.semesterTableAdapter.Fill(this.grilDataSet.Semester);
        }

        private void addNewSemesterBT_Click(object sender, EventArgs e)
        {
            //create new value with defaults
            semesterNumCurrent = -1;
            SemesterYearCB.Text = "-";
            semesterTypeCB.Text = "-";
            begdaSemesterPicker.Value = DateTime.Now;
            enddaSemesterPicker.Value = DateTime.Now;

            //pop message to hit save
            MessageBox.Show("לאחר עדכון הפרטים לחץ על שמור", "סמסטר חדש נוצר", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteSemesterBT_Click(object sender, EventArgs e)
        {
            //ask if sure
            String semesterYear = SemesterYearCB.Text;
            String semesterType = semesterTypeCB.Text;
            DateTime semesterBegda = begdaSemesterPicker.Value;
            DateTime semesterEndda = enddaSemesterPicker.Value;

            String msg = $"האם בטוח שרוצה למחוק את הסמסטר?\n{semesterYear} - {semesterType}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (yesno == DialogResult.Yes)
            {
                this.semesterTableAdapter.DeleteQuery(semesterNumCurrent);
                MessageBox.Show("סמסטר נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.semesterTableAdapter.Fill(this.grilDataSet.Semester);
            }
        }













        #endregion


        #region Faculty and Degree

        int currentFacultyID;
        Boolean facCelChanged = false;
        private void facultyGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection currentCell = facultyGrid.Rows[e.RowIndex].Cells;
            currentFacultyID = (int)currentCell[0].Value;
        }

        private void facultyGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            facCelChanged = true;
        }

        private void addFacultyBT_Click(object sender, EventArgs e)
        {
            this.facultyTableAdapter.InsertQuery("-חדש-");
            MessageBox.Show("הפקולטה נוספה בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.facultyTableAdapter.Fill(this.grilDataSet.Faculty);
        }

        private void deleteFacultyBT_Click(object sender, EventArgs e)
        {

            String msg = $"האם בטוח שרוצה למחוק את הפקולטה?\n{currentFacultyID}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {
                this.facultyTableAdapter.DeleteQuery(currentFacultyID);
                MessageBox.Show("הפקולטה נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.facultyTableAdapter.Fill(this.grilDataSet.Faculty);
            }
        }

        private void facultyGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellCollection currentCell = facultyGrid.Rows[e.RowIndex].Cells;
            if (currentCell[0].Value != null && facCelChanged)
            {
                int fid = (int)currentCell[0].Value;
                String fName = (String)currentCell[1].Value;
                this.facultyTableAdapter.UpdateQuery(fName, fid);
                this.facultyTableAdapter.Fill(this.grilDataSet.Faculty);
                facCelChanged = false;
            }

        }


        private void editDegBT_Click(object sender, EventArgs e)
        {
            degNameTB.Enabled = true;
            degFacCB.Enabled = true;
        }

        private void saveDegBT_Click(object sender, EventArgs e)
        {

            int degId = int.Parse(degIDTB.Text);
            String degName = degNameTB.Text;
            DataRowView row = (DataRowView)degFacCB.SelectedItem;
            int facId = (int)row.Row[0];

            if (degId == -1)
            {
                this.degreeTableAdapter.InsertQuery(degName, facId);
            }
            else
            {
                this.degreeTableAdapter.UpdateQuery(degName, facId, degId);
            }

            this.degreeTableAdapter.Fill(this.grilDataSet.Degree);

            degNameTB.Enabled = false;
            degFacCB.Enabled = false;
        }

        private void newDegBT_Click(object sender, EventArgs e)
        {
            degNameTB.Enabled = true;
            degFacCB.Enabled = true;

            degIDTB.Text = "-1";
            degNameTB.Text = "--חדש--";
        }

        private void delDegBT_Click(object sender, EventArgs e)
        {
            int degId = int.Parse(degIDTB.Text);
            String degName = degNameTB.Text;

            String msg = $"האם בטוח שרוצה למחוק את המגמה?\n{degName}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {
                this.degreeTableAdapter.DeleteQuery(degId);
                MessageBox.Show("המגמה נמחקה בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                campusNameComboBox_SelectedIndexChanged(null, null);
                this.degreeTableAdapter.Fill(this.grilDataSet.Degree);
            }

        }



        private void classFacCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)degFacCB.SelectedItem;
                if (row != null)
                {
                    int facId = (int)row.Row[0];
                    this.degreeTableAdapter.FillByFacultyID(this.grilDataSet.Degree, facId);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void classDegCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                DataRowView row = (DataRowView)classDegCB.SelectedItem;
                if (row != null)
                {
                    int degId = (int)row.Row[0];
                    this.degreeClassTableAdapter.FillByDegreeID(this.grilDataSet.DegreeClass, degId);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void classDegGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void summerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (summerCheckBox.Checked)
            {
                summerCheckBox.Text = "כן";
            }
            else
            {
                summerCheckBox.Text = "לא";
            }
        }

        private void newClassBT_Click(object sender, EventArgs e)
        {
            editClassBT_Click(null, null);

            degreeClassIDTextBox.Text = "-1";
            degreeClassNameTextBox.Text = "--חדש--";
            numberOfStudentsNumericUpDown.Value = 0;
            durationNumericUpDown.Value = 0;
            summerCheckBox.CheckState = CheckState.Unchecked;
            weeklyHoursNumericUpDown.Value = 0;
            isActive.CheckState = CheckState.Checked;

        }

        private void editClassBT_Click(object sender, EventArgs e)
        {
            degreeClassNameTextBox.Enabled = true;
            classMegamaCB.Enabled = true;
            numberOfStudentsNumericUpDown.Enabled = true;
            startingSemesterComboBox.Enabled = true;
            durationNumericUpDown.Enabled = true;
            summerCheckBox.Enabled = true;
            weeklyHoursNumericUpDown.Enabled = true;
            isActive.Enabled = true;
        }

        private void saveClassBT_Click(object sender, EventArgs e)
        {

            int classID = int.Parse(degreeClassIDTextBox.Text);
            String className = degreeClassNameTextBox.Text;

            DataRowView rowMegama = (DataRowView)classMegamaCB.SelectedItem;
            int degId = (int)rowMegama.Row[0];

            int numOfStd = (int)(numberOfStudentsNumericUpDown.Value);

            DataRowView rowSemester = (DataRowView)startingSemesterComboBox.SelectedItem;
            int semesterId = (int)rowSemester.Row[0];
          
            int semesterLen = (int)(durationNumericUpDown.Value);
            bool isSummer = summerCheckBox.CheckState == CheckState.Checked;
            int weeklyHours = (int)(weeklyHoursNumericUpDown.Value);
            bool is_Active = isActive.CheckState == CheckState.Checked;

            //update DB


            if (classID == -1)
            {
                this.degreeClassTableAdapter.InsertQuery(className,degId,numOfStd,semesterId,semesterLen,isSummer,weeklyHours, is_Active);
            }
            else
            {
                this.degreeClassTableAdapter.UpdateQuery(className, degId, numOfStd, semesterId, semesterLen, isSummer, weeklyHours, is_Active,classID);
            }

            this.degreeClassTableAdapter.Fill(this.grilDataSet.DegreeClass);

            degreeClassNameTextBox.Enabled = false;
            classMegamaCB.Enabled = false;
            numberOfStudentsNumericUpDown.Enabled = false;
            startingSemesterComboBox.Enabled = false;
            durationNumericUpDown.Enabled = false;
            summerCheckBox.Enabled = false;
            weeklyHoursNumericUpDown.Enabled = false;
            isActive.Enabled = false;

        }

        private void delClassBT_Click(object sender, EventArgs e)
        {
            int classID = int.Parse(degreeClassIDTextBox.Text);
            String className = degreeClassNameTextBox.Text;

            String msg = $"האם בטוח שרוצה למחוק את המחזור?\n{className}";
            DialogResult yesno = MessageBox.Show(msg, "האם בטוח", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yesno == DialogResult.Yes)
            {
                this.degreeClassTableAdapter.DeleteQuery(classID);
                MessageBox.Show("המחזור נמחק בהצלחה", "הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.degreeClassTableAdapter.Fill(this.grilDataSet.DegreeClass);

            }
        }

        #endregion


    }
}
