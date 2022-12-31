namespace Final_Project
{
    partial class DBMaintain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label degreeClassIDLabel;
            System.Windows.Forms.Label degreeClassNameLabel;
            System.Windows.Forms.Label degreeIDLabel;
            System.Windows.Forms.Label numberOfStudentsLabel;
            System.Windows.Forms.Label startingSemesterLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label summerLabel;
            System.Windows.Forms.Label weeklyHoursLabel;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBMaintain));
            this.buildingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grilDataSet = new Final_Project.grilDataSet();
            this.campusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.featuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grilDataViewsSet = new Final_Project.grilDataViewsSet();
            this.roomsByCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsByCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackToMenuBT = new System.Windows.Forms.Button();
            this.fKCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Final_Project.grilDataViewsSetTableAdapters.TableAdapterManager();
            this.roomsByCampusTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.RoomsByCampusTableAdapter();
            this.buildingsByCampusTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.BuildingsByCampusTableAdapter();
            this.allRoomsTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.AllRoomsTableAdapter();
            this.campusTableAdapter = new Final_Project.grilDataSetTableAdapters.campusTableAdapter();
            this.buildingTableAdapter = new Final_Project.grilDataSetTableAdapters.BuildingTableAdapter();
            this.featuresTableAdapter = new Final_Project.grilDataSetTableAdapters.FeaturesTableAdapter();
            this.semesterTableAdapter = new Final_Project.grilDataSetTableAdapters.SemesterTableAdapter();
            this.grilDataSet1 = new Final_Project.grilDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Final_Project.grilDataSetTableAdapters.RoomTableAdapter();
            this.roomFeaturesTableAdapter = new Final_Project.grilDataSetTableAdapters.RoomFeaturesTableAdapter();
            this.DegreeClassPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.classMegamaCB = new System.Windows.Forms.ComboBox();
            this.degreeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.degreeClassIDTextBox = new System.Windows.Forms.TextBox();
            this.degreeClassNameTextBox = new System.Windows.Forms.TextBox();
            this.weeklyHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.summerCheckBox = new System.Windows.Forms.CheckBox();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startingSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfStudentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.delClassBT = new System.Windows.Forms.Button();
            this.saveClassBT = new System.Windows.Forms.Button();
            this.editClassBT = new System.Windows.Forms.Button();
            this.newClassBT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DCFremove = new System.Windows.Forms.Button();
            this.DCFadd = new System.Windows.Forms.Button();
            this.FeaturesMenu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DCFeatures = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dCFeaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDegGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.hebrewYearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeClassIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.weeklyHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDegCB = new System.Windows.Forms.ComboBox();
            this.degreeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classFacCB = new System.Windows.Forms.ComboBox();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.FacultyPage = new System.Windows.Forms.TabPage();
            this.delDegBT = new System.Windows.Forms.Button();
            this.newDegBT = new System.Windows.Forms.Button();
            this.saveDegBT = new System.Windows.Forms.Button();
            this.editDegBT = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.degFacCB = new System.Windows.Forms.ComboBox();
            this.degNameTB = new System.Windows.Forms.TextBox();
            this.degIDTB = new System.Windows.Forms.TextBox();
            this.deleteFacultyBT = new System.Windows.Forms.Button();
            this.addFacultyBT = new System.Windows.Forms.Button();
            this.degreeGrid = new System.Windows.Forms.DataGridView();
            this.degreeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyGrid = new System.Windows.Forms.DataGridView();
            this.facultyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacultyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SemestersPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteSemesterBT = new System.Windows.Forms.Button();
            this.addNewSemesterBT = new System.Windows.Forms.Button();
            this.saveSemesterBT = new System.Windows.Forms.Button();
            this.enddaSemesterPicker = new System.Windows.Forms.DateTimePicker();
            this.begdaSemesterPicker = new System.Windows.Forms.DateTimePicker();
            this.semesterTypeCB = new System.Windows.Forms.ComboBox();
            this.SemesterYearCB = new System.Windows.Forms.ComboBox();
            this.SemesterDataGridView = new System.Windows.Forms.DataGridView();
            this.semesterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hebrewYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeaturesPage = new System.Windows.Forms.TabPage();
            this.removeFeatBT = new System.Windows.Forms.Button();
            this.featureLabel = new System.Windows.Forms.Label();
            this.addFeatureBT = new System.Windows.Forms.Button();
            this.features_gridView = new System.Windows.Forms.DataGridView();
            this.featuresIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifierReqDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoomsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.removeFeatureFromRoomBT = new System.Windows.Forms.Button();
            this.addFeatureToRoomBT = new System.Windows.Forms.Button();
            this.featuresMenuGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifierReqDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roomFeaturesGridView = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeaturesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featureNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomDeleteBT = new System.Windows.Forms.Button();
            this.roomNewBT = new System.Windows.Forms.Button();
            this.roomSaveBT = new System.Windows.Forms.Button();
            this.roomEditBT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roomCampusTB = new System.Windows.Forms.TextBox();
            this.roomBuildingCB = new System.Windows.Forms.ComboBox();
            this.roomFloorTB = new System.Windows.Forms.TextBox();
            this.roomNameTB = new System.Windows.Forms.TextBox();
            this.roomIDTB = new System.Windows.Forms.TextBox();
            this.campusNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomsDataGrid = new System.Windows.Forms.DataGridView();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsCampusCB = new System.Windows.Forms.ComboBox();
            this.CampusPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridBuilding = new System.Windows.Forms.DataGridView();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCampus = new System.Windows.Forms.DataGridView();
            this.campusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newCampusBT = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.facultyTableAdapter = new Final_Project.grilDataSetTableAdapters.FacultyTableAdapter();
            this.degreeTableAdapter = new Final_Project.grilDataSetTableAdapters.DegreeTableAdapter();
            this.degreeClassTableAdapter = new Final_Project.grilDataSetTableAdapters.DegreeClassTableAdapter();
            this.tableAdapterManager1 = new Final_Project.grilDataSetTableAdapters.TableAdapterManager();
            this.dCFeaturesTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.DCFeaturesTableAdapter();
            this.DCFSource = new System.Windows.Forms.BindingSource(this.components);
            this.degreeClassFeaturesTableAdapter = new Final_Project.grilDataSetTableAdapters.DegreeClassFeaturesTableAdapter();
            degreeClassIDLabel = new System.Windows.Forms.Label();
            degreeClassNameLabel = new System.Windows.Forms.Label();
            degreeIDLabel = new System.Windows.Forms.Label();
            numberOfStudentsLabel = new System.Windows.Forms.Label();
            startingSemesterLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            summerLabel = new System.Windows.Forms.Label();
            weeklyHoursLabel = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsByCampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsByCampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.DegreeClassPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCFeatures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCFeaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDegGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.FacultyPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.degreeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyGrid)).BeginInit();
            this.SemestersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterDataGridView)).BeginInit();
            this.FeaturesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.features_gridView)).BeginInit();
            this.RoomsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featuresMenuGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFeaturesGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGrid)).BeginInit();
            this.CampusPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampus)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DCFSource)).BeginInit();
            this.SuspendLayout();
            // 
            // degreeClassIDLabel
            // 
            degreeClassIDLabel.AutoSize = true;
            degreeClassIDLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            degreeClassIDLabel.Location = new System.Drawing.Point(284, 0);
            degreeClassIDLabel.Name = "degreeClassIDLabel";
            degreeClassIDLabel.Size = new System.Drawing.Size(109, 25);
            degreeClassIDLabel.TabIndex = 0;
            degreeClassIDLabel.Text = "מזהה מחזור";
            // 
            // degreeClassNameLabel
            // 
            degreeClassNameLabel.AutoSize = true;
            degreeClassNameLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            degreeClassNameLabel.Location = new System.Drawing.Point(302, 42);
            degreeClassNameLabel.Name = "degreeClassNameLabel";
            degreeClassNameLabel.Size = new System.Drawing.Size(91, 25);
            degreeClassNameLabel.TabIndex = 2;
            degreeClassNameLabel.Text = "שם מחזור";
            // 
            // degreeIDLabel
            // 
            degreeIDLabel.AutoSize = true;
            degreeIDLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            degreeIDLabel.Location = new System.Drawing.Point(336, 84);
            degreeIDLabel.Name = "degreeIDLabel";
            degreeIDLabel.Size = new System.Drawing.Size(57, 25);
            degreeIDLabel.TabIndex = 4;
            degreeIDLabel.Text = "מגמה";
            // 
            // numberOfStudentsLabel
            // 
            numberOfStudentsLabel.AutoSize = true;
            numberOfStudentsLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfStudentsLabel.Location = new System.Drawing.Point(249, 336);
            numberOfStudentsLabel.Name = "numberOfStudentsLabel";
            numberOfStudentsLabel.Size = new System.Drawing.Size(144, 25);
            numberOfStudentsLabel.TabIndex = 6;
            numberOfStudentsLabel.Text = "מספר סטודנטים";
            numberOfStudentsLabel.Visible = false;
            // 
            // startingSemesterLabel
            // 
            startingSemesterLabel.AutoSize = true;
            startingSemesterLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            startingSemesterLabel.Location = new System.Drawing.Point(255, 126);
            startingSemesterLabel.Name = "startingSemesterLabel";
            startingSemesterLabel.Size = new System.Drawing.Size(138, 25);
            startingSemesterLabel.TabIndex = 8;
            startingSemesterLabel.Text = "סמסטר התחלה";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            durationLabel.Location = new System.Drawing.Point(256, 210);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(137, 25);
            durationLabel.TabIndex = 10;
            durationLabel.Text = "כמות סמסטרים";
            // 
            // summerLabel
            // 
            summerLabel.AutoSize = true;
            summerLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            summerLabel.Location = new System.Drawing.Point(289, 252);
            summerLabel.Name = "summerLabel";
            summerLabel.Size = new System.Drawing.Size(104, 25);
            summerLabel.TabIndex = 12;
            summerLabel.Text = "לימודי קיץ?";
            // 
            // weeklyHoursLabel
            // 
            weeklyHoursLabel.AutoSize = true;
            weeklyHoursLabel.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            weeklyHoursLabel.Location = new System.Drawing.Point(267, 168);
            weeklyHoursLabel.Name = "weeklyHoursLabel";
            weeklyHoursLabel.Size = new System.Drawing.Size(126, 25);
            weeklyHoursLabel.TabIndex = 14;
            weeklyHoursLabel.Text = "שעות שבועיות";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label19.Location = new System.Drawing.Point(332, 294);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(61, 25);
            label19.TabIndex = 14;
            label19.Text = "פעיל?";
            // 
            // buildingBindingSource
            // 
            this.buildingBindingSource.DataMember = "Building";
            this.buildingBindingSource.DataSource = this.grilDataSet;
            // 
            // grilDataSet
            // 
            this.grilDataSet.DataSetName = "grilDataSet";
            this.grilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campusBindingSource
            // 
            this.campusBindingSource.DataMember = "campus";
            this.campusBindingSource.DataSource = this.grilDataSet;
            // 
            // featuresBindingSource
            // 
            this.featuresBindingSource.DataMember = "Features";
            this.featuresBindingSource.DataSource = this.grilDataSet;
            // 
            // allRoomsBindingSource
            // 
            this.allRoomsBindingSource.DataMember = "AllRooms";
            this.allRoomsBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // grilDataViewsSet
            // 
            this.grilDataViewsSet.DataSetName = "grilDataViewsSet";
            this.grilDataViewsSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsByCampusBindingSource
            // 
            this.roomsByCampusBindingSource.DataMember = "RoomsByCampus";
            this.roomsByCampusBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // buildingsByCampusBindingSource
            // 
            this.buildingsByCampusBindingSource.DataMember = "BuildingsByCampus";
            this.buildingsByCampusBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // campusBindingSource1
            // 
            this.campusBindingSource1.DataMember = "campus";
            this.campusBindingSource1.DataSource = this.grilDataSet;
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataMember = "Semester";
            this.semesterBindingSource.DataSource = this.grilDataSet;
            // 
            // BackToMenuBT
            // 
            this.BackToMenuBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToMenuBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.BackToMenuBT.Font = new System.Drawing.Font("Rubik Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackToMenuBT.Location = new System.Drawing.Point(1108, 11);
            this.BackToMenuBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackToMenuBT.Name = "BackToMenuBT";
            this.BackToMenuBT.Size = new System.Drawing.Size(131, 57);
            this.BackToMenuBT.TabIndex = 1;
            this.BackToMenuBT.Text = "חזרה לתפריט";
            this.BackToMenuBT.UseVisualStyleBackColor = false;
            this.BackToMenuBT.Click += new System.EventHandler(this.BackToMenuBT_Click);
            // 
            // fKCampusBindingSource
            // 
            this.fKCampusBindingSource.DataMember = "FK_Campus";
            this.fKCampusBindingSource.DataSource = this.campusBindingSource;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Final_Project.grilDataViewsSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roomsByCampusTableAdapter
            // 
            this.roomsByCampusTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsByCampusTableAdapter
            // 
            this.buildingsByCampusTableAdapter.ClearBeforeFill = true;
            // 
            // allRoomsTableAdapter
            // 
            this.allRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // campusTableAdapter
            // 
            this.campusTableAdapter.ClearBeforeFill = true;
            // 
            // buildingTableAdapter
            // 
            this.buildingTableAdapter.ClearBeforeFill = true;
            // 
            // featuresTableAdapter
            // 
            this.featuresTableAdapter.ClearBeforeFill = true;
            // 
            // semesterTableAdapter
            // 
            this.semesterTableAdapter.ClearBeforeFill = true;
            // 
            // grilDataSet1
            // 
            this.grilDataSet1.DataSetName = "grilDataSet";
            this.grilDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.grilDataSet1;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // roomFeaturesTableAdapter
            // 
            this.roomFeaturesTableAdapter.ClearBeforeFill = true;
            // 
            // DegreeClassPage
            // 
            this.DegreeClassPage.AutoScroll = true;
            this.DegreeClassPage.Controls.Add(this.groupBox4);
            this.DegreeClassPage.Controls.Add(this.groupBox3);
            this.DegreeClassPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DegreeClassPage.Location = new System.Drawing.Point(4, 34);
            this.DegreeClassPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DegreeClassPage.Name = "DegreeClassPage";
            this.DegreeClassPage.Size = new System.Drawing.Size(1219, 609);
            this.DegreeClassPage.TabIndex = 7;
            this.DegreeClassPage.Text = "מחזורי לימודים";
            this.DegreeClassPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel1);
            this.groupBox4.Controls.Add(this.delClassBT);
            this.groupBox4.Controls.Add(this.saveClassBT);
            this.groupBox4.Controls.Add(this.editClassBT);
            this.groupBox4.Controls.Add(this.newClassBT);
            this.groupBox4.Location = new System.Drawing.Point(19, 20);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(412, 582);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "פרטי המחזור";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.23711F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.76289F));
            this.tableLayoutPanel1.Controls.Add(degreeClassIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.classMegamaCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numberOfStudentsNumericUpDown, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.degreeClassIDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(degreeClassNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.degreeClassNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(numberOfStudentsLabel, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.summerCheckBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(summerLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.durationNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(durationLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(degreeIDLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(startingSemesterLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.startingSemesterComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(weeklyHoursLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.weeklyHoursNumericUpDown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(label19, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.isActive, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 43);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 366);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // classMegamaCB
            // 
            this.classMegamaCB.DataSource = this.degreeBindingSource1;
            this.classMegamaCB.DisplayMember = "DegreeName";
            this.classMegamaCB.Enabled = false;
            this.classMegamaCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classMegamaCB.FormattingEnabled = true;
            this.classMegamaCB.Location = new System.Drawing.Point(3, 86);
            this.classMegamaCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classMegamaCB.Name = "classMegamaCB";
            this.classMegamaCB.Size = new System.Drawing.Size(227, 33);
            this.classMegamaCB.TabIndex = 17;
            // 
            // degreeBindingSource1
            // 
            this.degreeBindingSource1.DataMember = "Degree";
            this.degreeBindingSource1.DataSource = this.grilDataSet;
            // 
            // degreeClassIDTextBox
            // 
            this.degreeClassIDTextBox.Enabled = false;
            this.degreeClassIDTextBox.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeClassIDTextBox.Location = new System.Drawing.Point(3, 2);
            this.degreeClassIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeClassIDTextBox.Name = "degreeClassIDTextBox";
            this.degreeClassIDTextBox.Size = new System.Drawing.Size(227, 31);
            this.degreeClassIDTextBox.TabIndex = 1;
            // 
            // degreeClassNameTextBox
            // 
            this.degreeClassNameTextBox.Enabled = false;
            this.degreeClassNameTextBox.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeClassNameTextBox.Location = new System.Drawing.Point(3, 44);
            this.degreeClassNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeClassNameTextBox.Name = "degreeClassNameTextBox";
            this.degreeClassNameTextBox.Size = new System.Drawing.Size(227, 31);
            this.degreeClassNameTextBox.TabIndex = 3;
            // 
            // weeklyHoursNumericUpDown
            // 
            this.weeklyHoursNumericUpDown.Enabled = false;
            this.weeklyHoursNumericUpDown.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyHoursNumericUpDown.Location = new System.Drawing.Point(3, 170);
            this.weeklyHoursNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weeklyHoursNumericUpDown.Name = "weeklyHoursNumericUpDown";
            this.weeklyHoursNumericUpDown.Size = new System.Drawing.Size(227, 31);
            this.weeklyHoursNumericUpDown.TabIndex = 15;
            // 
            // summerCheckBox
            // 
            this.summerCheckBox.Enabled = false;
            this.summerCheckBox.Location = new System.Drawing.Point(114, 254);
            this.summerCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summerCheckBox.Name = "summerCheckBox";
            this.summerCheckBox.Size = new System.Drawing.Size(116, 25);
            this.summerCheckBox.TabIndex = 13;
            this.summerCheckBox.Text = "לא";
            this.summerCheckBox.UseVisualStyleBackColor = true;
            this.summerCheckBox.CheckedChanged += new System.EventHandler(this.summerCheckBox_CheckedChanged);
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.Enabled = false;
            this.durationNumericUpDown.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationNumericUpDown.Location = new System.Drawing.Point(3, 212);
            this.durationNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(227, 31);
            this.durationNumericUpDown.TabIndex = 11;
            // 
            // startingSemesterComboBox
            // 
            this.startingSemesterComboBox.DataSource = this.semesterBindingSource;
            this.startingSemesterComboBox.DisplayMember = "SemesterFullName";
            this.startingSemesterComboBox.Enabled = false;
            this.startingSemesterComboBox.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingSemesterComboBox.FormattingEnabled = true;
            this.startingSemesterComboBox.Location = new System.Drawing.Point(3, 128);
            this.startingSemesterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingSemesterComboBox.Name = "startingSemesterComboBox";
            this.startingSemesterComboBox.Size = new System.Drawing.Size(227, 33);
            this.startingSemesterComboBox.TabIndex = 9;
            // 
            // numberOfStudentsNumericUpDown
            // 
            this.numberOfStudentsNumericUpDown.Enabled = false;
            this.numberOfStudentsNumericUpDown.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStudentsNumericUpDown.Location = new System.Drawing.Point(3, 338);
            this.numberOfStudentsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfStudentsNumericUpDown.Name = "numberOfStudentsNumericUpDown";
            this.numberOfStudentsNumericUpDown.Size = new System.Drawing.Size(227, 31);
            this.numberOfStudentsNumericUpDown.TabIndex = 7;
            this.numberOfStudentsNumericUpDown.Visible = false;
            // 
            // isActive
            // 
            this.isActive.Enabled = false;
            this.isActive.Location = new System.Drawing.Point(114, 296);
            this.isActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(116, 25);
            this.isActive.TabIndex = 13;
            this.isActive.UseVisualStyleBackColor = true;
            this.isActive.CheckedChanged += new System.EventHandler(this.summerCheckBox_CheckedChanged);
            // 
            // delClassBT
            // 
            this.delClassBT.BackColor = System.Drawing.Color.IndianRed;
            this.delClassBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delClassBT.Location = new System.Drawing.Point(11, 514);
            this.delClassBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delClassBT.Name = "delClassBT";
            this.delClassBT.Size = new System.Drawing.Size(87, 49);
            this.delClassBT.TabIndex = 16;
            this.delClassBT.Text = "מחק";
            this.delClassBT.UseVisualStyleBackColor = false;
            this.delClassBT.Click += new System.EventHandler(this.delClassBT_Click);
            // 
            // saveClassBT
            // 
            this.saveClassBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.saveClassBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveClassBT.Location = new System.Drawing.Point(11, 425);
            this.saveClassBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveClassBT.Name = "saveClassBT";
            this.saveClassBT.Size = new System.Drawing.Size(87, 49);
            this.saveClassBT.TabIndex = 16;
            this.saveClassBT.Text = "שמור";
            this.saveClassBT.UseVisualStyleBackColor = true;
            this.saveClassBT.Click += new System.EventHandler(this.saveClassBT_Click);
            // 
            // editClassBT
            // 
            this.editClassBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClassBT.Location = new System.Drawing.Point(104, 425);
            this.editClassBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editClassBT.Name = "editClassBT";
            this.editClassBT.Size = new System.Drawing.Size(87, 49);
            this.editClassBT.TabIndex = 16;
            this.editClassBT.Text = "ערוך";
            this.editClassBT.UseVisualStyleBackColor = true;
            this.editClassBT.Click += new System.EventHandler(this.editClassBT_Click);
            // 
            // newClassBT
            // 
            this.newClassBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newClassBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClassBT.Location = new System.Drawing.Point(104, 514);
            this.newClassBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newClassBT.Name = "newClassBT";
            this.newClassBT.Size = new System.Drawing.Size(87, 49);
            this.newClassBT.TabIndex = 16;
            this.newClassBT.Text = "חדש";
            this.newClassBT.UseVisualStyleBackColor = false;
            this.newClassBT.Click += new System.EventHandler(this.newClassBT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.classDegGrid);
            this.groupBox3.Controls.Add(this.classDegCB);
            this.groupBox3.Controls.Add(this.classFacCB);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(436, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(753, 599);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "מחזורים";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.DCFremove);
            this.groupBox5.Controls.Add(this.DCFadd);
            this.groupBox5.Controls.Add(this.FeaturesMenu);
            this.groupBox5.Controls.Add(this.DCFeatures);
            this.groupBox5.Location = new System.Drawing.Point(13, 335);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(740, 260);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "מאפיינים";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(503, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 25);
            this.label20.TabIndex = 3;
            this.label20.Text = "מאפיינים לחדר";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(54, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 25);
            this.label21.TabIndex = 3;
            this.label21.Text = "תפריט מאפיינים רלוונטים";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // DCFremove
            // 
            this.DCFremove.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.DCFremove.Location = new System.Drawing.Point(337, 178);
            this.DCFremove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DCFremove.Name = "DCFremove";
            this.DCFremove.Size = new System.Drawing.Size(59, 39);
            this.DCFremove.TabIndex = 2;
            this.DCFremove.Text = ">>>";
            this.DCFremove.UseVisualStyleBackColor = true;
            this.DCFremove.Click += new System.EventHandler(this.DCFremove_Click);
            // 
            // DCFadd
            // 
            this.DCFadd.AllowDrop = true;
            this.DCFadd.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.DCFadd.Location = new System.Drawing.Point(337, 116);
            this.DCFadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DCFadd.Name = "DCFadd";
            this.DCFadd.Size = new System.Drawing.Size(59, 39);
            this.DCFadd.TabIndex = 2;
            this.DCFadd.Text = "<<<";
            this.DCFadd.UseVisualStyleBackColor = true;
            this.DCFadd.Click += new System.EventHandler(this.DCFadd_Click);
            // 
            // FeaturesMenu
            // 
            this.FeaturesMenu.AllowUserToAddRows = false;
            this.FeaturesMenu.AllowUserToDeleteRows = false;
            this.FeaturesMenu.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeaturesMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FeaturesMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeaturesMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn2});
            this.FeaturesMenu.DataSource = this.featuresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeaturesMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.FeaturesMenu.Location = new System.Drawing.Point(5, 74);
            this.FeaturesMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeaturesMenu.MultiSelect = false;
            this.FeaturesMenu.Name = "FeaturesMenu";
            this.FeaturesMenu.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeaturesMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FeaturesMenu.RowHeadersWidth = 51;
            this.FeaturesMenu.RowTemplate.Height = 24;
            this.FeaturesMenu.ShowCellErrors = false;
            this.FeaturesMenu.ShowCellToolTips = false;
            this.FeaturesMenu.ShowEditingIcon = false;
            this.FeaturesMenu.ShowRowErrors = false;
            this.FeaturesMenu.Size = new System.Drawing.Size(315, 193);
            this.FeaturesMenu.TabIndex = 1;
            this.FeaturesMenu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeaturesMenu_RowEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FeaturesID";
            this.dataGridViewTextBoxColumn2.HeaderText = "FeaturesID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FeatureName";
            this.dataGridViewTextBoxColumn3.HeaderText = "שם מאפיין";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "QualifierReq";
            this.dataGridViewCheckBoxColumn2.HeaderText = "דורש ערך?";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 111;
            // 
            // DCFeatures
            // 
            this.DCFeatures.AllowUserToAddRows = false;
            this.DCFeatures.AllowUserToDeleteRows = false;
            this.DCFeatures.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DCFeatures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DCFeatures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DCFeatures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.DCFeatures.DataSource = this.dCFeaturesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DCFeatures.DefaultCellStyle = dataGridViewCellStyle5;
            this.DCFeatures.Location = new System.Drawing.Point(407, 74);
            this.DCFeatures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DCFeatures.Name = "DCFeatures";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DCFeatures.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DCFeatures.RowHeadersWidth = 51;
            this.DCFeatures.RowTemplate.Height = 24;
            this.DCFeatures.ShowCellErrors = false;
            this.DCFeatures.ShowCellToolTips = false;
            this.DCFeatures.ShowEditingIcon = false;
            this.DCFeatures.ShowRowErrors = false;
            this.DCFeatures.Size = new System.Drawing.Size(333, 193);
            this.DCFeatures.TabIndex = 0;
            this.DCFeatures.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DCFeatures_CellValidated);
            this.DCFeatures.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DCFeatures_RowEnter);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FeaturesID";
            this.dataGridViewTextBoxColumn5.HeaderText = "FeaturesID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FeatureName";
            this.dataGridViewTextBoxColumn7.HeaderText = "שם מאפיין";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Qualifier";
            this.dataGridViewTextBoxColumn8.HeaderText = "ערך מאפיין";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 131;
            // 
            // dCFeaturesBindingSource
            // 
            this.dCFeaturesBindingSource.DataMember = "DCFeatures";
            this.dCFeaturesBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // classDegGrid
            // 
            this.classDegGrid.AllowUserToAddRows = false;
            this.classDegGrid.AllowUserToDeleteRows = false;
            this.classDegGrid.AutoGenerateColumns = false;
            this.classDegGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDegGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.hebrewYearDataGridViewTextBoxColumn1,
            this.semesterTypeDataGridViewTextBoxColumn1,
            this.degreeClassIDDataGridViewTextBoxColumn,
            this.degreeClassNameDataGridViewTextBoxColumn,
            this.degreeIDDataGridViewTextBoxColumn1,
            this.numberOfStudentsDataGridViewTextBoxColumn,
            this.startingSemesterDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.summerDataGridViewCheckBoxColumn,
            this.weeklyHoursDataGridViewTextBoxColumn});
            this.classDegGrid.DataSource = this.degreeClassBindingSource;
            this.classDegGrid.Location = new System.Drawing.Point(79, 78);
            this.classDegGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classDegGrid.Name = "classDegGrid";
            this.classDegGrid.ReadOnly = true;
            this.classDegGrid.RowHeadersWidth = 51;
            this.classDegGrid.RowTemplate.Height = 24;
            this.classDegGrid.ShowCellErrors = false;
            this.classDegGrid.ShowCellToolTips = false;
            this.classDegGrid.ShowEditingIcon = false;
            this.classDegGrid.ShowRowErrors = false;
            this.classDegGrid.Size = new System.Drawing.Size(661, 236);
            this.classDegGrid.TabIndex = 2;
            this.classDegGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDegGrid_RowEnter);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.FalseValue = "";
            this.dataGridViewCheckBoxColumn1.HeaderText = "פעיל";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.TrueValue = "";
            this.dataGridViewCheckBoxColumn1.Width = 58;
            // 
            // hebrewYearDataGridViewTextBoxColumn1
            // 
            this.hebrewYearDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hebrewYearDataGridViewTextBoxColumn1.DataPropertyName = "HebrewYear";
            this.hebrewYearDataGridViewTextBoxColumn1.HeaderText = "שנה";
            this.hebrewYearDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.hebrewYearDataGridViewTextBoxColumn1.Name = "hebrewYearDataGridViewTextBoxColumn1";
            this.hebrewYearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // semesterTypeDataGridViewTextBoxColumn1
            // 
            this.semesterTypeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semesterTypeDataGridViewTextBoxColumn1.DataPropertyName = "SemesterType";
            this.semesterTypeDataGridViewTextBoxColumn1.HeaderText = "סוג סמסטר";
            this.semesterTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.semesterTypeDataGridViewTextBoxColumn1.Name = "semesterTypeDataGridViewTextBoxColumn1";
            this.semesterTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // degreeClassIDDataGridViewTextBoxColumn
            // 
            this.degreeClassIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.HeaderText = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeClassIDDataGridViewTextBoxColumn.Name = "degreeClassIDDataGridViewTextBoxColumn";
            this.degreeClassIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeClassIDDataGridViewTextBoxColumn.Visible = false;
            this.degreeClassIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeClassNameDataGridViewTextBoxColumn
            // 
            this.degreeClassNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeClassNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeClassName";
            this.degreeClassNameDataGridViewTextBoxColumn.HeaderText = "שם מחזור";
            this.degreeClassNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeClassNameDataGridViewTextBoxColumn.Name = "degreeClassNameDataGridViewTextBoxColumn";
            this.degreeClassNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeIDDataGridViewTextBoxColumn1
            // 
            this.degreeIDDataGridViewTextBoxColumn1.DataPropertyName = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn1.HeaderText = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.degreeIDDataGridViewTextBoxColumn1.Name = "degreeIDDataGridViewTextBoxColumn1";
            this.degreeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.degreeIDDataGridViewTextBoxColumn1.Visible = false;
            this.degreeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numberOfStudentsDataGridViewTextBoxColumn
            // 
            this.numberOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.HeaderText = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfStudentsDataGridViewTextBoxColumn.Name = "numberOfStudentsDataGridViewTextBoxColumn";
            this.numberOfStudentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfStudentsDataGridViewTextBoxColumn.Visible = false;
            this.numberOfStudentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingSemesterDataGridViewTextBoxColumn
            // 
            this.startingSemesterDataGridViewTextBoxColumn.DataPropertyName = "StartingSemester";
            this.startingSemesterDataGridViewTextBoxColumn.HeaderText = "StartingSemester";
            this.startingSemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingSemesterDataGridViewTextBoxColumn.Name = "startingSemesterDataGridViewTextBoxColumn";
            this.startingSemesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.startingSemesterDataGridViewTextBoxColumn.Visible = false;
            this.startingSemesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Visible = false;
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // summerDataGridViewCheckBoxColumn
            // 
            this.summerDataGridViewCheckBoxColumn.DataPropertyName = "Summer";
            this.summerDataGridViewCheckBoxColumn.HeaderText = "Summer";
            this.summerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.summerDataGridViewCheckBoxColumn.Name = "summerDataGridViewCheckBoxColumn";
            this.summerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.summerDataGridViewCheckBoxColumn.Visible = false;
            this.summerDataGridViewCheckBoxColumn.Width = 125;
            // 
            // weeklyHoursDataGridViewTextBoxColumn
            // 
            this.weeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "WeeklyHours";
            this.weeklyHoursDataGridViewTextBoxColumn.HeaderText = "WeeklyHours";
            this.weeklyHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.weeklyHoursDataGridViewTextBoxColumn.Name = "weeklyHoursDataGridViewTextBoxColumn";
            this.weeklyHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.weeklyHoursDataGridViewTextBoxColumn.Visible = false;
            this.weeklyHoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // degreeClassBindingSource
            // 
            this.degreeClassBindingSource.DataMember = "DegreeClass";
            this.degreeClassBindingSource.DataSource = this.grilDataSet;
            // 
            // classDegCB
            // 
            this.classDegCB.DataSource = this.degreeBindingSource;
            this.classDegCB.DisplayMember = "DegreeName";
            this.classDegCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDegCB.FormattingEnabled = true;
            this.classDegCB.Location = new System.Drawing.Point(79, 34);
            this.classDegCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classDegCB.Name = "classDegCB";
            this.classDegCB.Size = new System.Drawing.Size(207, 33);
            this.classDegCB.TabIndex = 1;
            this.classDegCB.SelectedIndexChanged += new System.EventHandler(this.classDegCB_SelectedIndexChanged);
            // 
            // degreeBindingSource
            // 
            this.degreeBindingSource.DataMember = "Degree";
            this.degreeBindingSource.DataSource = this.grilDataSet;
            // 
            // classFacCB
            // 
            this.classFacCB.DataSource = this.facultyBindingSource;
            this.classFacCB.DisplayMember = "FacultyName";
            this.classFacCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classFacCB.FormattingEnabled = true;
            this.classFacCB.Location = new System.Drawing.Point(395, 34);
            this.classFacCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.classFacCB.Name = "classFacCB";
            this.classFacCB.Size = new System.Drawing.Size(247, 33);
            this.classFacCB.TabIndex = 1;
            this.classFacCB.SelectedIndexChanged += new System.EventHandler(this.classFacCB_SelectedIndexChanged);
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.grilDataSet;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(292, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "מגמה:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(648, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "פקולטה:";
            // 
            // FacultyPage
            // 
            this.FacultyPage.Controls.Add(this.delDegBT);
            this.FacultyPage.Controls.Add(this.newDegBT);
            this.FacultyPage.Controls.Add(this.saveDegBT);
            this.FacultyPage.Controls.Add(this.editDegBT);
            this.FacultyPage.Controls.Add(this.label16);
            this.FacultyPage.Controls.Add(this.label15);
            this.FacultyPage.Controls.Add(this.label14);
            this.FacultyPage.Controls.Add(this.degFacCB);
            this.FacultyPage.Controls.Add(this.degNameTB);
            this.FacultyPage.Controls.Add(this.degIDTB);
            this.FacultyPage.Controls.Add(this.deleteFacultyBT);
            this.FacultyPage.Controls.Add(this.addFacultyBT);
            this.FacultyPage.Controls.Add(this.degreeGrid);
            this.FacultyPage.Controls.Add(this.facultyGrid);
            this.FacultyPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FacultyPage.Location = new System.Drawing.Point(4, 34);
            this.FacultyPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FacultyPage.Name = "FacultyPage";
            this.FacultyPage.Size = new System.Drawing.Size(1219, 609);
            this.FacultyPage.TabIndex = 5;
            this.FacultyPage.Text = "פקולטות ומגמות";
            this.FacultyPage.UseVisualStyleBackColor = true;
            // 
            // delDegBT
            // 
            this.delDegBT.BackColor = System.Drawing.Color.IndianRed;
            this.delDegBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.delDegBT.Location = new System.Drawing.Point(27, 558);
            this.delDegBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delDegBT.Name = "delDegBT";
            this.delDegBT.Size = new System.Drawing.Size(84, 38);
            this.delDegBT.TabIndex = 11;
            this.delDegBT.Text = "מחק";
            this.delDegBT.UseVisualStyleBackColor = false;
            this.delDegBT.Click += new System.EventHandler(this.delDegBT_Click);
            // 
            // newDegBT
            // 
            this.newDegBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newDegBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newDegBT.Location = new System.Drawing.Point(27, 513);
            this.newDegBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newDegBT.Name = "newDegBT";
            this.newDegBT.Size = new System.Drawing.Size(84, 38);
            this.newDegBT.TabIndex = 10;
            this.newDegBT.Text = "חדש";
            this.newDegBT.UseVisualStyleBackColor = false;
            this.newDegBT.Click += new System.EventHandler(this.newDegBT_Click);
            // 
            // saveDegBT
            // 
            this.saveDegBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.saveDegBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveDegBT.Location = new System.Drawing.Point(190, 558);
            this.saveDegBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveDegBT.Name = "saveDegBT";
            this.saveDegBT.Size = new System.Drawing.Size(84, 38);
            this.saveDegBT.TabIndex = 9;
            this.saveDegBT.Text = "שמור";
            this.saveDegBT.UseVisualStyleBackColor = true;
            this.saveDegBT.Click += new System.EventHandler(this.saveDegBT_Click);
            // 
            // editDegBT
            // 
            this.editDegBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.editDegBT.Location = new System.Drawing.Point(190, 513);
            this.editDegBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editDegBT.Name = "editDegBT";
            this.editDegBT.Size = new System.Drawing.Size(84, 38);
            this.editDegBT.TabIndex = 8;
            this.editDegBT.Text = "ערוך";
            this.editDegBT.UseVisualStyleBackColor = true;
            this.editDegBT.Click += new System.EventHandler(this.editDegBT_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(367, 508);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 25);
            this.label16.TabIndex = 7;
            this.label16.Text = "שם פקולטה";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.Location = new System.Drawing.Point(589, 508);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "שם מגמה";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(709, 508);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 25);
            this.label14.TabIndex = 7;
            this.label14.Text = "מזהה מגמה";
            // 
            // degFacCB
            // 
            this.degFacCB.DataSource = this.facultyBindingSource;
            this.degFacCB.DisplayMember = "FacultyName";
            this.degFacCB.Enabled = false;
            this.degFacCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.degFacCB.FormattingEnabled = true;
            this.degFacCB.Location = new System.Drawing.Point(284, 538);
            this.degFacCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degFacCB.Name = "degFacCB";
            this.degFacCB.Size = new System.Drawing.Size(185, 33);
            this.degFacCB.TabIndex = 6;
            // 
            // degNameTB
            // 
            this.degNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeBindingSource, "DegreeName", true));
            this.degNameTB.Enabled = false;
            this.degNameTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.degNameTB.Location = new System.Drawing.Point(503, 540);
            this.degNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degNameTB.Name = "degNameTB";
            this.degNameTB.Size = new System.Drawing.Size(169, 31);
            this.degNameTB.TabIndex = 4;
            // 
            // degIDTB
            // 
            this.degIDTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeBindingSource, "DegreeID", true));
            this.degIDTB.Enabled = false;
            this.degIDTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.degIDTB.Location = new System.Drawing.Point(709, 539);
            this.degIDTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degIDTB.Name = "degIDTB";
            this.degIDTB.Size = new System.Drawing.Size(100, 31);
            this.degIDTB.TabIndex = 3;
            // 
            // deleteFacultyBT
            // 
            this.deleteFacultyBT.BackColor = System.Drawing.Color.IndianRed;
            this.deleteFacultyBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteFacultyBT.Location = new System.Drawing.Point(970, 498);
            this.deleteFacultyBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteFacultyBT.Name = "deleteFacultyBT";
            this.deleteFacultyBT.Size = new System.Drawing.Size(114, 38);
            this.deleteFacultyBT.TabIndex = 2;
            this.deleteFacultyBT.Text = "מחק פקולטה";
            this.deleteFacultyBT.UseVisualStyleBackColor = false;
            this.deleteFacultyBT.Click += new System.EventHandler(this.deleteFacultyBT_Click);
            // 
            // addFacultyBT
            // 
            this.addFacultyBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addFacultyBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addFacultyBT.Location = new System.Drawing.Point(1090, 498);
            this.addFacultyBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFacultyBT.Name = "addFacultyBT";
            this.addFacultyBT.Size = new System.Drawing.Size(114, 38);
            this.addFacultyBT.TabIndex = 2;
            this.addFacultyBT.Text = "הוסף פקולטה";
            this.addFacultyBT.UseVisualStyleBackColor = false;
            this.addFacultyBT.Click += new System.EventHandler(this.addFacultyBT_Click);
            // 
            // degreeGrid
            // 
            this.degreeGrid.AllowUserToAddRows = false;
            this.degreeGrid.AllowUserToDeleteRows = false;
            this.degreeGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.degreeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.degreeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.degreeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeIDDataGridViewTextBoxColumn,
            this.degreeNameDataGridViewTextBoxColumn,
            this.facultyIDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.degreeGrid.DataSource = this.degreeBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.degreeGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.degreeGrid.Location = new System.Drawing.Point(27, 14);
            this.degreeGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.degreeGrid.Name = "degreeGrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.degreeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.degreeGrid.RowHeadersWidth = 51;
            this.degreeGrid.RowTemplate.Height = 24;
            this.degreeGrid.Size = new System.Drawing.Size(792, 479);
            this.degreeGrid.TabIndex = 1;
            // 
            // degreeIDDataGridViewTextBoxColumn
            // 
            this.degreeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn.HeaderText = "מזהה מגמה";
            this.degreeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeIDDataGridViewTextBoxColumn.Name = "degreeIDDataGridViewTextBoxColumn";
            this.degreeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // degreeNameDataGridViewTextBoxColumn
            // 
            this.degreeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeName";
            this.degreeNameDataGridViewTextBoxColumn.HeaderText = "שם מגמה";
            this.degreeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeNameDataGridViewTextBoxColumn.Name = "degreeNameDataGridViewTextBoxColumn";
            // 
            // facultyIDDataGridViewTextBoxColumn1
            // 
            this.facultyIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultyIDDataGridViewTextBoxColumn1.DataPropertyName = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn1.HeaderText = "מזהה פקולטה";
            this.facultyIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.facultyIDDataGridViewTextBoxColumn1.Name = "facultyIDDataGridViewTextBoxColumn1";
            this.facultyIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FacultyName";
            this.dataGridViewTextBoxColumn1.HeaderText = "שם פקולטה";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // facultyGrid
            // 
            this.facultyGrid.AllowUserToAddRows = false;
            this.facultyGrid.AllowUserToDeleteRows = false;
            this.facultyGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultyGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.facultyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyIDDataGridViewTextBoxColumn,
            this.FacultyName});
            this.facultyGrid.DataSource = this.facultyBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.facultyGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.facultyGrid.Location = new System.Drawing.Point(837, 14);
            this.facultyGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facultyGrid.Name = "facultyGrid";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.facultyGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.facultyGrid.RowHeadersWidth = 51;
            this.facultyGrid.RowTemplate.Height = 24;
            this.facultyGrid.Size = new System.Drawing.Size(369, 479);
            this.facultyGrid.TabIndex = 0;
            this.facultyGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_CellValueChanged);
            this.facultyGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_RowEnter);
            this.facultyGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_RowValidated);
            // 
            // facultyIDDataGridViewTextBoxColumn
            // 
            this.facultyIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facultyIDDataGridViewTextBoxColumn.DataPropertyName = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn.HeaderText = "מזהה פקולטה";
            this.facultyIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facultyIDDataGridViewTextBoxColumn.Name = "facultyIDDataGridViewTextBoxColumn";
            this.facultyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.facultyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "שם פקולטה";
            this.FacultyName.MinimumWidth = 6;
            this.FacultyName.Name = "FacultyName";
            // 
            // SemestersPage
            // 
            this.SemestersPage.Controls.Add(this.label4);
            this.SemestersPage.Controls.Add(this.label3);
            this.SemestersPage.Controls.Add(this.label2);
            this.SemestersPage.Controls.Add(this.label1);
            this.SemestersPage.Controls.Add(this.deleteSemesterBT);
            this.SemestersPage.Controls.Add(this.addNewSemesterBT);
            this.SemestersPage.Controls.Add(this.saveSemesterBT);
            this.SemestersPage.Controls.Add(this.enddaSemesterPicker);
            this.SemestersPage.Controls.Add(this.begdaSemesterPicker);
            this.SemestersPage.Controls.Add(this.semesterTypeCB);
            this.SemestersPage.Controls.Add(this.SemesterYearCB);
            this.SemestersPage.Controls.Add(this.SemesterDataGridView);
            this.SemestersPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SemestersPage.Location = new System.Drawing.Point(4, 34);
            this.SemestersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SemestersPage.Name = "SemestersPage";
            this.SemestersPage.Size = new System.Drawing.Size(1219, 609);
            this.SemestersPage.TabIndex = 4;
            this.SemestersPage.Text = "סמסטרים";
            this.SemestersPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(750, 531);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "ת. סיום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(733, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ת. תחילה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(980, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "סוג";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1147, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "שנה";
            // 
            // deleteSemesterBT
            // 
            this.deleteSemesterBT.BackColor = System.Drawing.Color.IndianRed;
            this.deleteSemesterBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.deleteSemesterBT.Location = new System.Drawing.Point(504, 554);
            this.deleteSemesterBT.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSemesterBT.Name = "deleteSemesterBT";
            this.deleteSemesterBT.Size = new System.Drawing.Size(100, 37);
            this.deleteSemesterBT.TabIndex = 3;
            this.deleteSemesterBT.Text = "מחק";
            this.deleteSemesterBT.UseVisualStyleBackColor = false;
            this.deleteSemesterBT.Click += new System.EventHandler(this.deleteSemesterBT_Click);
            // 
            // addNewSemesterBT
            // 
            this.addNewSemesterBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewSemesterBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addNewSemesterBT.Location = new System.Drawing.Point(504, 509);
            this.addNewSemesterBT.Margin = new System.Windows.Forms.Padding(4);
            this.addNewSemesterBT.Name = "addNewSemesterBT";
            this.addNewSemesterBT.Size = new System.Drawing.Size(100, 37);
            this.addNewSemesterBT.TabIndex = 3;
            this.addNewSemesterBT.Text = "חדש";
            this.addNewSemesterBT.UseVisualStyleBackColor = false;
            this.addNewSemesterBT.Click += new System.EventHandler(this.addNewSemesterBT_Click);
            // 
            // saveSemesterBT
            // 
            this.saveSemesterBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.saveSemesterBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveSemesterBT.Location = new System.Drawing.Point(504, 464);
            this.saveSemesterBT.Margin = new System.Windows.Forms.Padding(4);
            this.saveSemesterBT.Name = "saveSemesterBT";
            this.saveSemesterBT.Size = new System.Drawing.Size(100, 37);
            this.saveSemesterBT.TabIndex = 3;
            this.saveSemesterBT.Text = "שמור";
            this.saveSemesterBT.UseVisualStyleBackColor = true;
            this.saveSemesterBT.Click += new System.EventHandler(this.saveSemesterBT_Click);
            // 
            // enddaSemesterPicker
            // 
            this.enddaSemesterPicker.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.enddaSemesterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddaSemesterPicker.Location = new System.Drawing.Point(637, 560);
            this.enddaSemesterPicker.Margin = new System.Windows.Forms.Padding(4);
            this.enddaSemesterPicker.Name = "enddaSemesterPicker";
            this.enddaSemesterPicker.Size = new System.Drawing.Size(178, 31);
            this.enddaSemesterPicker.TabIndex = 2;
            // 
            // begdaSemesterPicker
            // 
            this.begdaSemesterPicker.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.begdaSemesterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.begdaSemesterPicker.Location = new System.Drawing.Point(637, 491);
            this.begdaSemesterPicker.Margin = new System.Windows.Forms.Padding(4);
            this.begdaSemesterPicker.Name = "begdaSemesterPicker";
            this.begdaSemesterPicker.Size = new System.Drawing.Size(178, 31);
            this.begdaSemesterPicker.TabIndex = 2;
            // 
            // semesterTypeCB
            // 
            this.semesterTypeCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.semesterTypeCB.FormattingEnabled = true;
            this.semesterTypeCB.Items.AddRange(new object[] {
            "חורף",
            "אביב",
            "קיץ"});
            this.semesterTypeCB.Location = new System.Drawing.Point(854, 489);
            this.semesterTypeCB.Margin = new System.Windows.Forms.Padding(4);
            this.semesterTypeCB.Name = "semesterTypeCB";
            this.semesterTypeCB.Size = new System.Drawing.Size(160, 33);
            this.semesterTypeCB.TabIndex = 1;
            // 
            // SemesterYearCB
            // 
            this.SemesterYearCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SemesterYearCB.FormattingEnabled = true;
            this.SemesterYearCB.Items.AddRange(new object[] {
            "תשפא",
            "תשפב",
            "תשפג",
            "תשפד",
            "תשפה",
            "תשפו",
            "תשפז"});
            this.SemesterYearCB.Location = new System.Drawing.Point(1028, 489);
            this.SemesterYearCB.Margin = new System.Windows.Forms.Padding(4);
            this.SemesterYearCB.Name = "SemesterYearCB";
            this.SemesterYearCB.Size = new System.Drawing.Size(160, 33);
            this.SemesterYearCB.TabIndex = 1;
            // 
            // SemesterDataGridView
            // 
            this.SemesterDataGridView.AllowUserToAddRows = false;
            this.SemesterDataGridView.AllowUserToDeleteRows = false;
            this.SemesterDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SemesterDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.SemesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SemesterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterIDDataGridViewTextBoxColumn,
            this.hebrewYearDataGridViewTextBoxColumn,
            this.semesterTypeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.SemesterDataGridView.DataSource = this.semesterBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SemesterDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.SemesterDataGridView.Location = new System.Drawing.Point(11, 4);
            this.SemesterDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SemesterDataGridView.Name = "SemesterDataGridView";
            this.SemesterDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SemesterDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.SemesterDataGridView.RowHeadersWidth = 51;
            this.SemesterDataGridView.Size = new System.Drawing.Size(1177, 436);
            this.SemesterDataGridView.TabIndex = 0;
            this.SemesterDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SemesterDataGridView_RowEnter);
            // 
            // semesterIDDataGridViewTextBoxColumn
            // 
            this.semesterIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semesterIDDataGridViewTextBoxColumn.DataPropertyName = "SemesterID";
            this.semesterIDDataGridViewTextBoxColumn.HeaderText = "מזהה סמסטר";
            this.semesterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterIDDataGridViewTextBoxColumn.Name = "semesterIDDataGridViewTextBoxColumn";
            this.semesterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hebrewYearDataGridViewTextBoxColumn
            // 
            this.hebrewYearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hebrewYearDataGridViewTextBoxColumn.DataPropertyName = "HebrewYear";
            this.hebrewYearDataGridViewTextBoxColumn.HeaderText = "שנה עברית";
            this.hebrewYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hebrewYearDataGridViewTextBoxColumn.Name = "hebrewYearDataGridViewTextBoxColumn";
            this.hebrewYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterTypeDataGridViewTextBoxColumn
            // 
            this.semesterTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.semesterTypeDataGridViewTextBoxColumn.DataPropertyName = "SemesterType";
            this.semesterTypeDataGridViewTextBoxColumn.HeaderText = "סוג סמסטר";
            this.semesterTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterTypeDataGridViewTextBoxColumn.Name = "semesterTypeDataGridViewTextBoxColumn";
            this.semesterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.semesterTypeDataGridViewTextBoxColumn.Width = 136;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "תאריך תחילה";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "תאריך סיום";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FeaturesPage
            // 
            this.FeaturesPage.Controls.Add(this.removeFeatBT);
            this.FeaturesPage.Controls.Add(this.featureLabel);
            this.FeaturesPage.Controls.Add(this.addFeatureBT);
            this.FeaturesPage.Controls.Add(this.features_gridView);
            this.FeaturesPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FeaturesPage.Location = new System.Drawing.Point(4, 34);
            this.FeaturesPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeaturesPage.Name = "FeaturesPage";
            this.FeaturesPage.Size = new System.Drawing.Size(1219, 609);
            this.FeaturesPage.TabIndex = 3;
            this.FeaturesPage.Text = "מאפיינים";
            this.FeaturesPage.UseVisualStyleBackColor = true;
            // 
            // removeFeatBT
            // 
            this.removeFeatBT.BackColor = System.Drawing.Color.IndianRed;
            this.removeFeatBT.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.removeFeatBT.Location = new System.Drawing.Point(134, 483);
            this.removeFeatBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFeatBT.Name = "removeFeatBT";
            this.removeFeatBT.Size = new System.Drawing.Size(213, 58);
            this.removeFeatBT.TabIndex = 3;
            this.removeFeatBT.Text = "מחק";
            this.removeFeatBT.UseVisualStyleBackColor = false;
            this.removeFeatBT.Click += new System.EventHandler(this.removeFeatBT_Click);
            // 
            // featureLabel
            // 
            this.featureLabel.AutoSize = true;
            this.featureLabel.Location = new System.Drawing.Point(247, 499);
            this.featureLabel.Name = "featureLabel";
            this.featureLabel.Size = new System.Drawing.Size(70, 25);
            this.featureLabel.TabIndex = 2;
            this.featureLabel.Text = "label1";
            // 
            // addFeatureBT
            // 
            this.addFeatureBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addFeatureBT.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addFeatureBT.Location = new System.Drawing.Point(134, 419);
            this.addFeatureBT.Margin = new System.Windows.Forms.Padding(4);
            this.addFeatureBT.Name = "addFeatureBT";
            this.addFeatureBT.Size = new System.Drawing.Size(213, 58);
            this.addFeatureBT.TabIndex = 1;
            this.addFeatureBT.Text = "הוסף מאפיין חדש";
            this.addFeatureBT.UseVisualStyleBackColor = false;
            this.addFeatureBT.Click += new System.EventHandler(this.addFeatureBT_Click);
            // 
            // features_gridView
            // 
            this.features_gridView.AllowUserToAddRows = false;
            this.features_gridView.AutoGenerateColumns = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.features_gridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.features_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.features_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featuresIDDataGridViewTextBoxColumn,
            this.featureNameDataGridViewTextBoxColumn,
            this.qualifierReqDataGridViewCheckBoxColumn});
            this.features_gridView.DataSource = this.featuresBindingSource;
            this.features_gridView.Location = new System.Drawing.Point(393, 31);
            this.features_gridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.features_gridView.Name = "features_gridView";
            this.features_gridView.RowHeadersWidth = 51;
            this.features_gridView.RowTemplate.Height = 24;
            this.features_gridView.Size = new System.Drawing.Size(779, 510);
            this.features_gridView.TabIndex = 0;
            this.features_gridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.features_gridView_RowEnter);
            this.features_gridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.features_gridView_RowValidated);
            // 
            // featuresIDDataGridViewTextBoxColumn
            // 
            this.featuresIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featuresIDDataGridViewTextBoxColumn.DataPropertyName = "FeaturesID";
            this.featuresIDDataGridViewTextBoxColumn.HeaderText = "מזהה מאפיין";
            this.featuresIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.featuresIDDataGridViewTextBoxColumn.Name = "featuresIDDataGridViewTextBoxColumn";
            this.featuresIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // featureNameDataGridViewTextBoxColumn
            // 
            this.featureNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featureNameDataGridViewTextBoxColumn.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.featureNameDataGridViewTextBoxColumn.Name = "featureNameDataGridViewTextBoxColumn";
            // 
            // qualifierReqDataGridViewCheckBoxColumn
            // 
            this.qualifierReqDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualifierReqDataGridViewCheckBoxColumn.DataPropertyName = "QualifierReq";
            this.qualifierReqDataGridViewCheckBoxColumn.HeaderText = "נדרש מספר?";
            this.qualifierReqDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.qualifierReqDataGridViewCheckBoxColumn.Name = "qualifierReqDataGridViewCheckBoxColumn";
            this.qualifierReqDataGridViewCheckBoxColumn.Width = 129;
            // 
            // RoomsPage
            // 
            this.RoomsPage.AutoScroll = true;
            this.RoomsPage.Controls.Add(this.groupBox2);
            this.RoomsPage.Controls.Add(this.groupBox1);
            this.RoomsPage.Controls.Add(this.campusNameComboBox);
            this.RoomsPage.Controls.Add(this.label6);
            this.RoomsPage.Controls.Add(this.label5);
            this.RoomsPage.Controls.Add(this.roomsDataGrid);
            this.RoomsPage.Controls.Add(this.roomsCampusCB);
            this.RoomsPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RoomsPage.Location = new System.Drawing.Point(4, 34);
            this.RoomsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomsPage.Name = "RoomsPage";
            this.RoomsPage.Size = new System.Drawing.Size(1219, 609);
            this.RoomsPage.TabIndex = 2;
            this.RoomsPage.Text = "חדרים";
            this.RoomsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.removeFeatureFromRoomBT);
            this.groupBox2.Controls.Add(this.addFeatureToRoomBT);
            this.groupBox2.Controls.Add(this.featuresMenuGrid);
            this.groupBox2.Controls.Add(this.roomFeaturesGridView);
            this.groupBox2.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(3, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(791, 359);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "מאפיינים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(515, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "מאפיינים רלוונטים לחדר";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(116, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "תפריט מאפיינים";
            // 
            // removeFeatureFromRoomBT
            // 
            this.removeFeatureFromRoomBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.removeFeatureFromRoomBT.Location = new System.Drawing.Point(378, 240);
            this.removeFeatureFromRoomBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeFeatureFromRoomBT.Name = "removeFeatureFromRoomBT";
            this.removeFeatureFromRoomBT.Size = new System.Drawing.Size(59, 39);
            this.removeFeatureFromRoomBT.TabIndex = 2;
            this.removeFeatureFromRoomBT.Text = ">>>";
            this.removeFeatureFromRoomBT.UseVisualStyleBackColor = true;
            this.removeFeatureFromRoomBT.Click += new System.EventHandler(this.removeFeatureFromRoomBT_Click);
            // 
            // addFeatureToRoomBT
            // 
            this.addFeatureToRoomBT.AllowDrop = true;
            this.addFeatureToRoomBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.addFeatureToRoomBT.Location = new System.Drawing.Point(378, 176);
            this.addFeatureToRoomBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addFeatureToRoomBT.Name = "addFeatureToRoomBT";
            this.addFeatureToRoomBT.Size = new System.Drawing.Size(59, 39);
            this.addFeatureToRoomBT.TabIndex = 2;
            this.addFeatureToRoomBT.Text = "<<<";
            this.addFeatureToRoomBT.UseVisualStyleBackColor = true;
            this.addFeatureToRoomBT.Click += new System.EventHandler(this.addFeatureToRoomBT_Click);
            // 
            // featuresMenuGrid
            // 
            this.featuresMenuGrid.AllowUserToAddRows = false;
            this.featuresMenuGrid.AllowUserToDeleteRows = false;
            this.featuresMenuGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.featuresMenuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.featuresMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featuresMenuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.featureNameDataGridViewTextBoxColumn2,
            this.qualifierReqDataGridViewCheckBoxColumn1});
            this.featuresMenuGrid.DataSource = this.featuresBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.featuresMenuGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.featuresMenuGrid.Location = new System.Drawing.Point(5, 85);
            this.featuresMenuGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.featuresMenuGrid.MultiSelect = false;
            this.featuresMenuGrid.Name = "featuresMenuGrid";
            this.featuresMenuGrid.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.featuresMenuGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.featuresMenuGrid.RowHeadersWidth = 51;
            this.featuresMenuGrid.RowTemplate.Height = 24;
            this.featuresMenuGrid.ShowCellErrors = false;
            this.featuresMenuGrid.ShowCellToolTips = false;
            this.featuresMenuGrid.ShowEditingIcon = false;
            this.featuresMenuGrid.ShowRowErrors = false;
            this.featuresMenuGrid.Size = new System.Drawing.Size(357, 269);
            this.featuresMenuGrid.TabIndex = 1;
            this.featuresMenuGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.featuresMenuGrid_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "FeaturesID";
            this.Column1.HeaderText = "FeaturesID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 6;
            // 
            // featureNameDataGridViewTextBoxColumn2
            // 
            this.featureNameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featureNameDataGridViewTextBoxColumn2.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn2.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.featureNameDataGridViewTextBoxColumn2.Name = "featureNameDataGridViewTextBoxColumn2";
            this.featureNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // qualifierReqDataGridViewCheckBoxColumn1
            // 
            this.qualifierReqDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualifierReqDataGridViewCheckBoxColumn1.DataPropertyName = "QualifierReq";
            this.qualifierReqDataGridViewCheckBoxColumn1.HeaderText = "דורש ערך?";
            this.qualifierReqDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.qualifierReqDataGridViewCheckBoxColumn1.Name = "qualifierReqDataGridViewCheckBoxColumn1";
            this.qualifierReqDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.qualifierReqDataGridViewCheckBoxColumn1.Width = 111;
            // 
            // roomFeaturesGridView
            // 
            this.roomFeaturesGridView.AllowUserToAddRows = false;
            this.roomFeaturesGridView.AllowUserToDeleteRows = false;
            this.roomFeaturesGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFeaturesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.roomFeaturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomFeaturesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn1,
            this.FeaturesID,
            this.roomNameDataGridViewTextBoxColumn1,
            this.featureNameDataGridViewTextBoxColumn1,
            this.qualifierDataGridViewTextBoxColumn});
            this.roomFeaturesGridView.DataSource = this.allRoomsBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomFeaturesGridView.DefaultCellStyle = dataGridViewCellStyle21;
            this.roomFeaturesGridView.Location = new System.Drawing.Point(451, 85);
            this.roomFeaturesGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomFeaturesGridView.Name = "roomFeaturesGridView";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFeaturesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.roomFeaturesGridView.RowHeadersWidth = 51;
            this.roomFeaturesGridView.RowTemplate.Height = 24;
            this.roomFeaturesGridView.ShowCellErrors = false;
            this.roomFeaturesGridView.ShowCellToolTips = false;
            this.roomFeaturesGridView.ShowEditingIcon = false;
            this.roomFeaturesGridView.ShowRowErrors = false;
            this.roomFeaturesGridView.Size = new System.Drawing.Size(334, 269);
            this.roomFeaturesGridView.TabIndex = 0;
            this.roomFeaturesGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomFeaturesGridView_CellValidated);
            this.roomFeaturesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomFeaturesGridView_RowEnter);
            // 
            // roomIDDataGridViewTextBoxColumn1
            // 
            this.roomIDDataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn1.Name = "roomIDDataGridViewTextBoxColumn1";
            this.roomIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn1.Visible = false;
            this.roomIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // FeaturesID
            // 
            this.FeaturesID.DataPropertyName = "FeaturesID";
            this.FeaturesID.HeaderText = "FeaturesID";
            this.FeaturesID.MinimumWidth = 6;
            this.FeaturesID.Name = "FeaturesID";
            this.FeaturesID.ReadOnly = true;
            this.FeaturesID.Visible = false;
            this.FeaturesID.Width = 125;
            // 
            // roomNameDataGridViewTextBoxColumn1
            // 
            this.roomNameDataGridViewTextBoxColumn1.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn1.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.roomNameDataGridViewTextBoxColumn1.Name = "roomNameDataGridViewTextBoxColumn1";
            this.roomNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roomNameDataGridViewTextBoxColumn1.Visible = false;
            this.roomNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // featureNameDataGridViewTextBoxColumn1
            // 
            this.featureNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featureNameDataGridViewTextBoxColumn1.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn1.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.featureNameDataGridViewTextBoxColumn1.Name = "featureNameDataGridViewTextBoxColumn1";
            this.featureNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qualifierDataGridViewTextBoxColumn
            // 
            this.qualifierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qualifierDataGridViewTextBoxColumn.DataPropertyName = "Qualifier";
            this.qualifierDataGridViewTextBoxColumn.HeaderText = "ערך מאפיין";
            this.qualifierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualifierDataGridViewTextBoxColumn.Name = "qualifierDataGridViewTextBoxColumn";
            this.qualifierDataGridViewTextBoxColumn.Width = 131;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomDeleteBT);
            this.groupBox1.Controls.Add(this.roomNewBT);
            this.groupBox1.Controls.Add(this.roomSaveBT);
            this.groupBox1.Controls.Add(this.roomEditBT);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.roomCampusTB);
            this.groupBox1.Controls.Add(this.roomBuildingCB);
            this.groupBox1.Controls.Add(this.roomFloorTB);
            this.groupBox1.Controls.Add(this.roomNameTB);
            this.groupBox1.Controls.Add(this.roomIDTB);
            this.groupBox1.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(791, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי החדר";
            // 
            // roomDeleteBT
            // 
            this.roomDeleteBT.BackColor = System.Drawing.Color.IndianRed;
            this.roomDeleteBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomDeleteBT.Location = new System.Drawing.Point(253, 161);
            this.roomDeleteBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomDeleteBT.Name = "roomDeleteBT";
            this.roomDeleteBT.Size = new System.Drawing.Size(75, 34);
            this.roomDeleteBT.TabIndex = 6;
            this.roomDeleteBT.Text = "מחק";
            this.roomDeleteBT.UseVisualStyleBackColor = false;
            this.roomDeleteBT.Click += new System.EventHandler(this.roomDeleteBT_Click);
            // 
            // roomNewBT
            // 
            this.roomNewBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.roomNewBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomNewBT.Location = new System.Drawing.Point(253, 124);
            this.roomNewBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomNewBT.Name = "roomNewBT";
            this.roomNewBT.Size = new System.Drawing.Size(75, 34);
            this.roomNewBT.TabIndex = 6;
            this.roomNewBT.Text = "צור חדש";
            this.roomNewBT.UseVisualStyleBackColor = false;
            this.roomNewBT.Click += new System.EventHandler(this.roomNewBT_Click);
            // 
            // roomSaveBT
            // 
            this.roomSaveBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.roomSaveBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomSaveBT.Location = new System.Drawing.Point(253, 63);
            this.roomSaveBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomSaveBT.Name = "roomSaveBT";
            this.roomSaveBT.Size = new System.Drawing.Size(75, 34);
            this.roomSaveBT.TabIndex = 6;
            this.roomSaveBT.Text = "שמור";
            this.roomSaveBT.UseVisualStyleBackColor = true;
            this.roomSaveBT.Click += new System.EventHandler(this.roomSaveBT_Click);
            // 
            // roomEditBT
            // 
            this.roomEditBT.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomEditBT.Location = new System.Drawing.Point(253, 25);
            this.roomEditBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomEditBT.Name = "roomEditBT";
            this.roomEditBT.Size = new System.Drawing.Size(75, 34);
            this.roomEditBT.TabIndex = 6;
            this.roomEditBT.Text = "ערוך";
            this.roomEditBT.UseVisualStyleBackColor = true;
            this.roomEditBT.Click += new System.EventHandler(this.roomEditBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(549, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "בניין";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(549, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "קמפוס";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(549, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "קומה";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(549, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "שם החדר";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(549, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "מזהה חדר";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomCampusTB
            // 
            this.roomCampusTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "campusName", true));
            this.roomCampusTB.Enabled = false;
            this.roomCampusTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomCampusTB.Location = new System.Drawing.Point(349, 167);
            this.roomCampusTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomCampusTB.Name = "roomCampusTB";
            this.roomCampusTB.ReadOnly = true;
            this.roomCampusTB.Size = new System.Drawing.Size(193, 31);
            this.roomCampusTB.TabIndex = 4;
            // 
            // roomBuildingCB
            // 
            this.roomBuildingCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "BuildingName", true));
            this.roomBuildingCB.DataSource = this.buildingBindingSource;
            this.roomBuildingCB.DisplayMember = "BuildingName";
            this.roomBuildingCB.Enabled = false;
            this.roomBuildingCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomBuildingCB.FormattingEnabled = true;
            this.roomBuildingCB.Location = new System.Drawing.Point(349, 130);
            this.roomBuildingCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomBuildingCB.Name = "roomBuildingCB";
            this.roomBuildingCB.Size = new System.Drawing.Size(193, 33);
            this.roomBuildingCB.TabIndex = 3;
            // 
            // roomFloorTB
            // 
            this.roomFloorTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "Floor", true));
            this.roomFloorTB.Enabled = false;
            this.roomFloorTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomFloorTB.Location = new System.Drawing.Point(349, 95);
            this.roomFloorTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomFloorTB.Name = "roomFloorTB";
            this.roomFloorTB.Size = new System.Drawing.Size(193, 31);
            this.roomFloorTB.TabIndex = 2;
            // 
            // roomNameTB
            // 
            this.roomNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "RoomName", true));
            this.roomNameTB.Enabled = false;
            this.roomNameTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomNameTB.Location = new System.Drawing.Point(349, 60);
            this.roomNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomNameTB.Name = "roomNameTB";
            this.roomNameTB.Size = new System.Drawing.Size(193, 31);
            this.roomNameTB.TabIndex = 1;
            // 
            // roomIDTB
            // 
            this.roomIDTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "RoomID", true));
            this.roomIDTB.Enabled = false;
            this.roomIDTB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomIDTB.Location = new System.Drawing.Point(349, 25);
            this.roomIDTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomIDTB.Name = "roomIDTB";
            this.roomIDTB.ReadOnly = true;
            this.roomIDTB.Size = new System.Drawing.Size(193, 31);
            this.roomIDTB.TabIndex = 0;
            // 
            // campusNameComboBox
            // 
            this.campusNameComboBox.DataSource = this.buildingsByCampusBindingSource;
            this.campusNameComboBox.DisplayMember = "BuildingName";
            this.campusNameComboBox.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.campusNameComboBox.FormattingEnabled = true;
            this.campusNameComboBox.Location = new System.Drawing.Point(925, 63);
            this.campusNameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.campusNameComboBox.Name = "campusNameComboBox";
            this.campusNameComboBox.Size = new System.Drawing.Size(200, 33);
            this.campusNameComboBox.TabIndex = 5;
            this.campusNameComboBox.SelectedIndexChanged += new System.EventHandler(this.campusNameComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(1144, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "בניין:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(1133, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "קמפוס:";
            // 
            // roomsDataGrid
            // 
            this.roomsDataGrid.AllowUserToAddRows = false;
            this.roomsDataGrid.AllowUserToDeleteRows = false;
            this.roomsDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.roomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn});
            this.roomsDataGrid.DataSource = this.roomsByCampusBindingSource;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsDataGrid.DefaultCellStyle = dataGridViewCellStyle24;
            this.roomsDataGrid.Location = new System.Drawing.Point(801, 107);
            this.roomsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.roomsDataGrid.Name = "roomsDataGrid";
            this.roomsDataGrid.ReadOnly = true;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.roomsDataGrid.RowHeadersWidth = 51;
            this.roomsDataGrid.ShowCellErrors = false;
            this.roomsDataGrid.ShowCellToolTips = false;
            this.roomsDataGrid.ShowEditingIcon = false;
            this.roomsDataGrid.ShowRowErrors = false;
            this.roomsDataGrid.Size = new System.Drawing.Size(387, 482);
            this.roomsDataGrid.TabIndex = 1;
            this.roomsDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGrid_RowEnter);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.Visible = false;
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "שם החדר";
            this.roomNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "קומה";
            this.floorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            this.floorDataGridViewTextBoxColumn.Width = 86;
            // 
            // roomsCampusCB
            // 
            this.roomsCampusCB.DataSource = this.campusBindingSource1;
            this.roomsCampusCB.DisplayMember = "campusName";
            this.roomsCampusCB.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.roomsCampusCB.FormattingEnabled = true;
            this.roomsCampusCB.Location = new System.Drawing.Point(925, 15);
            this.roomsCampusCB.Margin = new System.Windows.Forms.Padding(4);
            this.roomsCampusCB.Name = "roomsCampusCB";
            this.roomsCampusCB.Size = new System.Drawing.Size(200, 33);
            this.roomsCampusCB.TabIndex = 0;
            this.roomsCampusCB.SelectedIndexChanged += new System.EventHandler(this.roomsCampusCB_SelectionChangeCommitted);
            // 
            // CampusPage
            // 
            this.CampusPage.Controls.Add(this.tableLayoutPanel2);
            this.CampusPage.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CampusPage.Location = new System.Drawing.Point(4, 34);
            this.CampusPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CampusPage.Name = "CampusPage";
            this.CampusPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CampusPage.Size = new System.Drawing.Size(1219, 609);
            this.CampusPage.TabIndex = 0;
            this.CampusPage.Text = "קמפוסים ובניינים";
            this.CampusPage.UseVisualStyleBackColor = true;
            this.CampusPage.Click += new System.EventHandler(this.CampusPage_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridBuilding, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridCampus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.newCampusBT, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(56, 26);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1103, 558);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dataGridBuilding
            // 
            this.dataGridBuilding.AutoGenerateColumns = false;
            this.dataGridBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBuilding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIDDataGridViewTextBoxColumn,
            this.buildingNameDataGridViewTextBoxColumn,
            this.campusIDDataGridViewTextBoxColumn1});
            this.dataGridBuilding.DataSource = this.buildingBindingSource;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBuilding.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBuilding.Location = new System.Drawing.Point(224, 271);
            this.dataGridBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridBuilding.Name = "dataGridBuilding";
            this.dataGridBuilding.RowHeadersWidth = 51;
            this.dataGridBuilding.RowTemplate.Height = 24;
            this.dataGridBuilding.Size = new System.Drawing.Size(876, 265);
            this.dataGridBuilding.TabIndex = 1;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "מזהה בניין";
            this.buildingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.Width = 117;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "BuildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "שם בניין";
            this.buildingNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            // 
            // campusIDDataGridViewTextBoxColumn1
            // 
            this.campusIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.campusIDDataGridViewTextBoxColumn1.DataPropertyName = "CampusID";
            this.campusIDDataGridViewTextBoxColumn1.HeaderText = "מזהה קמפוס";
            this.campusIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.campusIDDataGridViewTextBoxColumn1.Name = "campusIDDataGridViewTextBoxColumn1";
            this.campusIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.campusIDDataGridViewTextBoxColumn1.Width = 137;
            // 
            // dataGridCampus
            // 
            this.dataGridCampus.AllowUserToAddRows = false;
            this.dataGridCampus.AllowUserToOrderColumns = true;
            this.dataGridCampus.AutoGenerateColumns = false;
            this.dataGridCampus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCampus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCampus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campusIDDataGridViewTextBoxColumn,
            this.campusNameDataGridViewTextBoxColumn});
            this.dataGridCampus.DataSource = this.campusBindingSource;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Rubik SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCampus.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridCampus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCampus.Location = new System.Drawing.Point(224, 2);
            this.dataGridCampus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCampus.MultiSelect = false;
            this.dataGridCampus.Name = "dataGridCampus";
            this.dataGridCampus.RowHeadersWidth = 51;
            this.dataGridCampus.RowTemplate.Height = 24;
            this.dataGridCampus.Size = new System.Drawing.Size(876, 265);
            this.dataGridCampus.TabIndex = 0;
            this.dataGridCampus.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCampus_RowEnter);
            this.dataGridCampus.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCampus_RowValidated);
            this.dataGridCampus.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridCampus_UserDeletedRow);
            // 
            // campusIDDataGridViewTextBoxColumn
            // 
            this.campusIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.campusIDDataGridViewTextBoxColumn.DataPropertyName = "campusID";
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Rubik", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.campusIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle29;
            this.campusIDDataGridViewTextBoxColumn.HeaderText = "מזהה קמפוס";
            this.campusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusIDDataGridViewTextBoxColumn.Name = "campusIDDataGridViewTextBoxColumn";
            this.campusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.campusIDDataGridViewTextBoxColumn.Width = 149;
            // 
            // campusNameDataGridViewTextBoxColumn
            // 
            this.campusNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.campusNameDataGridViewTextBoxColumn.DataPropertyName = "campusName";
            this.campusNameDataGridViewTextBoxColumn.HeaderText = "שם קמפוס";
            this.campusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusNameDataGridViewTextBoxColumn.Name = "campusNameDataGridViewTextBoxColumn";
            // 
            // newCampusBT
            // 
            this.newCampusBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newCampusBT.Font = new System.Drawing.Font("Rubik Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newCampusBT.Location = new System.Drawing.Point(4, 4);
            this.newCampusBT.Margin = new System.Windows.Forms.Padding(4);
            this.newCampusBT.Name = "newCampusBT";
            this.newCampusBT.Size = new System.Drawing.Size(213, 54);
            this.newCampusBT.TabIndex = 2;
            this.newCampusBT.Text = "הוספת קמפוס חדש";
            this.newCampusBT.UseVisualStyleBackColor = false;
            this.newCampusBT.Click += new System.EventHandler(this.newCampusBT_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CampusPage);
            this.tabControl1.Controls.Add(this.RoomsPage);
            this.tabControl1.Controls.Add(this.FeaturesPage);
            this.tabControl1.Controls.Add(this.SemestersPage);
            this.tabControl1.Controls.Add(this.FacultyPage);
            this.tabControl1.Controls.Add(this.DegreeClassPage);
            this.tabControl1.Font = new System.Drawing.Font("Rubik Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 647);
            this.tabControl1.TabIndex = 0;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // degreeTableAdapter
            // 
            this.degreeTableAdapter.ClearBeforeFill = true;
            // 
            // degreeClassTableAdapter
            // 
            this.degreeClassTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BuildingTableAdapter = this.buildingTableAdapter;
            this.tableAdapterManager1.campusTableAdapter = this.campusTableAdapter;
            this.tableAdapterManager1.CourseDetailsTableAdapter = null;
            this.tableAdapterManager1.CourseFeaturesTableAdapter = null;
            this.tableAdapterManager1.CoursePlacementTableAdapter = null;
            this.tableAdapterManager1.CourseTableAdapter = null;
            this.tableAdapterManager1.DegreeClassFeaturesTableAdapter = null;
            this.tableAdapterManager1.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager1.FeaturesTableAdapter = this.featuresTableAdapter;
            this.tableAdapterManager1.LecturerTableAdapter = null;
            this.tableAdapterManager1.LecturerTimeTableAdapter = null;
            this.tableAdapterManager1.RoomFeaturesTableAdapter = this.roomFeaturesTableAdapter;
            this.tableAdapterManager1.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager1.ScheduleBlockTableAdapter = null;
            this.tableAdapterManager1.SemesterTableAdapter = this.semesterTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Final_Project.grilDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dCFeaturesTableAdapter
            // 
            this.dCFeaturesTableAdapter.ClearBeforeFill = true;
            // 
            // DCFSource
            // 
            this.DCFSource.DataMember = "DegreeClassFeatures";
            this.DCFSource.DataSource = this.grilDataSet;
            // 
            // degreeClassFeaturesTableAdapter
            // 
            this.degreeClassFeaturesTableAdapter.ClearBeforeFill = true;
            // 
            // DBMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Final_Project.Properties.Resources.black;
            this.ClientSize = new System.Drawing.Size(1251, 709);
            this.Controls.Add(this.BackToMenuBT);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DBMaintain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ניהול המידע ותחזוק הטבלאות";
            this.Load += new System.EventHandler(this.DBMaintain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featuresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsByCampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsByCampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.DegreeClassPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCFeatures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCFeaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDegGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.FacultyPage.ResumeLayout(false);
            this.FacultyPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.degreeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyGrid)).EndInit();
            this.SemestersPage.ResumeLayout(false);
            this.SemestersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterDataGridView)).EndInit();
            this.FeaturesPage.ResumeLayout(false);
            this.FeaturesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.features_gridView)).EndInit();
            this.RoomsPage.ResumeLayout(false);
            this.RoomsPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.featuresMenuGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomFeaturesGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGrid)).EndInit();
            this.CampusPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampus)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DCFSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private grilDataSet grilDataSet;
        private System.Windows.Forms.BindingSource campusBindingSource;
        private grilDataSetTableAdapters.campusTableAdapter campusTableAdapter;
        private System.Windows.Forms.Button BackToMenuBT;
        private System.Windows.Forms.BindingSource buildingBindingSource;
        private grilDataSetTableAdapters.BuildingTableAdapter buildingTableAdapter;
        private System.Windows.Forms.BindingSource fKCampusBindingSource;
        private System.Windows.Forms.BindingSource featuresBindingSource;
        private grilDataSetTableAdapters.FeaturesTableAdapter featuresTableAdapter;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private grilDataSetTableAdapters.SemesterTableAdapter semesterTableAdapter;
        private grilDataViewsSet grilDataViewsSet;
        private grilDataViewsSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource campusBindingSource1;
        private System.Windows.Forms.BindingSource roomsByCampusBindingSource;
        private grilDataViewsSetTableAdapters.RoomsByCampusTableAdapter roomsByCampusTableAdapter;
        private System.Windows.Forms.BindingSource buildingsByCampusBindingSource;
        private grilDataViewsSetTableAdapters.BuildingsByCampusTableAdapter buildingsByCampusTableAdapter;
        private grilDataSet grilDataSet1;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private grilDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource allRoomsBindingSource;
        private grilDataViewsSetTableAdapters.AllRoomsTableAdapter allRoomsTableAdapter;
        private grilDataSetTableAdapters.RoomFeaturesTableAdapter roomFeaturesTableAdapter;
        private System.Windows.Forms.TabPage DegreeClassPage;
        private System.Windows.Forms.TabPage FacultyPage;
        private System.Windows.Forms.TabPage SemestersPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteSemesterBT;
        private System.Windows.Forms.Button addNewSemesterBT;
        private System.Windows.Forms.Button saveSemesterBT;
        private System.Windows.Forms.DateTimePicker enddaSemesterPicker;
        private System.Windows.Forms.DateTimePicker begdaSemesterPicker;
        private System.Windows.Forms.ComboBox semesterTypeCB;
        private System.Windows.Forms.ComboBox SemesterYearCB;
        private System.Windows.Forms.DataGridView SemesterDataGridView;
        private System.Windows.Forms.TabPage FeaturesPage;
        private System.Windows.Forms.Button removeFeatBT;
        private System.Windows.Forms.Label featureLabel;
        private System.Windows.Forms.Button addFeatureBT;
        private System.Windows.Forms.DataGridView features_gridView;
        private System.Windows.Forms.TabPage RoomsPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button removeFeatureFromRoomBT;
        private System.Windows.Forms.Button addFeatureToRoomBT;
        private System.Windows.Forms.DataGridView featuresMenuGrid;
        private System.Windows.Forms.DataGridView roomFeaturesGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button roomDeleteBT;
        private System.Windows.Forms.Button roomNewBT;
        private System.Windows.Forms.Button roomSaveBT;
        private System.Windows.Forms.Button roomEditBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox roomCampusTB;
        private System.Windows.Forms.ComboBox roomBuildingCB;
        private System.Windows.Forms.TextBox roomFloorTB;
        private System.Windows.Forms.TextBox roomNameTB;
        private System.Windows.Forms.TextBox roomIDTB;
        private System.Windows.Forms.ComboBox campusNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView roomsDataGrid;
        private System.Windows.Forms.ComboBox roomsCampusCB;
        private System.Windows.Forms.TabPage CampusPage;
        private System.Windows.Forms.Button newCampusBT;
        private System.Windows.Forms.DataGridView dataGridBuilding;
        private System.Windows.Forms.DataGridView dataGridCampus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView facultyGrid;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private grilDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.DataGridView degreeGrid;
        private System.Windows.Forms.BindingSource degreeBindingSource;
        private grilDataSetTableAdapters.DegreeTableAdapter degreeTableAdapter;
        private System.Windows.Forms.Button deleteFacultyBT;
        private System.Windows.Forms.Button addFacultyBT;
        private System.Windows.Forms.Button delDegBT;
        private System.Windows.Forms.Button newDegBT;
        private System.Windows.Forms.Button saveDegBT;
        private System.Windows.Forms.Button editDegBT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox degFacCB;
        private System.Windows.Forms.TextBox degNameTB;
        private System.Windows.Forms.TextBox degIDTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox classDegCB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView classDegGrid;
        private System.Windows.Forms.BindingSource degreeClassBindingSource;
        private grilDataSetTableAdapters.DegreeClassTableAdapter degreeClassTableAdapter;
        private System.Windows.Forms.TextBox degreeClassIDTextBox;
        private System.Windows.Forms.TextBox degreeClassNameTextBox;
        private System.Windows.Forms.NumericUpDown numberOfStudentsNumericUpDown;
        private System.Windows.Forms.ComboBox startingSemesterComboBox;
        private System.Windows.Forms.NumericUpDown durationNumericUpDown;
        private System.Windows.Forms.CheckBox summerCheckBox;
        private System.Windows.Forms.NumericUpDown weeklyHoursNumericUpDown;
        private grilDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button delClassBT;
        private System.Windows.Forms.Button saveClassBT;
        private System.Windows.Forms.Button editClassBT;
        private System.Windows.Forms.Button newClassBT;
        private System.Windows.Forms.ComboBox classMegamaCB;
        private System.Windows.Forms.BindingSource degreeBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button DCFremove;
        private System.Windows.Forms.Button DCFadd;
        private System.Windows.Forms.DataGridView FeaturesMenu;
        private System.Windows.Forms.DataGridView DCFeatures;
        private System.Windows.Forms.BindingSource dCFeaturesBindingSource;
        private grilDataViewsSetTableAdapters.DCFeaturesTableAdapter dCFeaturesTableAdapter;
        private System.Windows.Forms.BindingSource DCFSource;
        private grilDataSetTableAdapters.DegreeClassFeaturesTableAdapter degreeClassFeaturesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebrewYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qualifierReqDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qualifierReqDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeaturesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebrewYearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeClassIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeClassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfStudentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn summerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weeklyHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox classFacCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusIDDataGridViewTextBoxColumn1;
    }
}