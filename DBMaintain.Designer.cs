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
            this.degreeClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.degreeClassNameTextBox = new System.Windows.Forms.TextBox();
            this.weeklyHoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.summerCheckBox = new System.Windows.Forms.CheckBox();
            this.durationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startingSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfStudentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.delClassBT = new System.Windows.Forms.Button();
            this.saveClassBT = new System.Windows.Forms.Button();
            this.editClassBT = new System.Windows.Forms.Button();
            this.newClassBT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.classDegGrid = new System.Windows.Forms.DataGridView();
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
            this.newCampusBT = new System.Windows.Forms.Button();
            this.dataGridBuilding = new System.Windows.Forms.DataGridView();
            this.buildingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridCampus = new System.Windows.Forms.DataGridView();
            this.campusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.facultyTableAdapter = new Final_Project.grilDataSetTableAdapters.FacultyTableAdapter();
            this.degreeTableAdapter = new Final_Project.grilDataSetTableAdapters.DegreeTableAdapter();
            this.degreeClassTableAdapter = new Final_Project.grilDataSetTableAdapters.DegreeClassTableAdapter();
            this.tableAdapterManager1 = new Final_Project.grilDataSetTableAdapters.TableAdapterManager();
            degreeClassIDLabel = new System.Windows.Forms.Label();
            degreeClassNameLabel = new System.Windows.Forms.Label();
            degreeIDLabel = new System.Windows.Forms.Label();
            numberOfStudentsLabel = new System.Windows.Forms.Label();
            startingSemesterLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            summerLabel = new System.Windows.Forms.Label();
            weeklyHoursLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDegGrid)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuilding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampus)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // degreeClassIDLabel
            // 
            degreeClassIDLabel.AutoSize = true;
            degreeClassIDLabel.Location = new System.Drawing.Point(239, 0);
            degreeClassIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            degreeClassIDLabel.Name = "degreeClassIDLabel";
            degreeClassIDLabel.Size = new System.Drawing.Size(91, 20);
            degreeClassIDLabel.TabIndex = 0;
            degreeClassIDLabel.Text = "מזהה מחזור:";
            // 
            // degreeClassNameLabel
            // 
            degreeClassNameLabel.AutoSize = true;
            degreeClassNameLabel.Location = new System.Drawing.Point(253, 33);
            degreeClassNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            degreeClassNameLabel.Name = "degreeClassNameLabel";
            degreeClassNameLabel.Size = new System.Drawing.Size(77, 20);
            degreeClassNameLabel.TabIndex = 2;
            degreeClassNameLabel.Text = "שם מחזור:";
            // 
            // degreeIDLabel
            // 
            degreeIDLabel.AutoSize = true;
            degreeIDLabel.Location = new System.Drawing.Point(281, 66);
            degreeIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            degreeIDLabel.Name = "degreeIDLabel";
            degreeIDLabel.Size = new System.Drawing.Size(49, 20);
            degreeIDLabel.TabIndex = 4;
            degreeIDLabel.Text = "מגמה:";
            // 
            // numberOfStudentsLabel
            // 
            numberOfStudentsLabel.AutoSize = true;
            numberOfStudentsLabel.Location = new System.Drawing.Point(254, 99);
            numberOfStudentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numberOfStudentsLabel.Name = "numberOfStudentsLabel";
            numberOfStudentsLabel.Size = new System.Drawing.Size(76, 33);
            numberOfStudentsLabel.TabIndex = 6;
            numberOfStudentsLabel.Text = "מספר סטודנטים:";
            // 
            // startingSemesterLabel
            // 
            startingSemesterLabel.AutoSize = true;
            startingSemesterLabel.Location = new System.Drawing.Point(219, 132);
            startingSemesterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            startingSemesterLabel.Name = "startingSemesterLabel";
            startingSemesterLabel.Size = new System.Drawing.Size(111, 20);
            startingSemesterLabel.TabIndex = 8;
            startingSemesterLabel.Text = "סמסטר התחלה:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(247, 165);
            durationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(83, 33);
            durationLabel.TabIndex = 10;
            durationLabel.Text = "אורך בסמסטרים:";
            // 
            // summerLabel
            // 
            summerLabel.AutoSize = true;
            summerLabel.Location = new System.Drawing.Point(242, 198);
            summerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            summerLabel.Name = "summerLabel";
            summerLabel.Size = new System.Drawing.Size(88, 33);
            summerLabel.TabIndex = 12;
            summerLabel.Text = "האם לומדים בקיץ:";
            // 
            // weeklyHoursLabel
            // 
            weeklyHoursLabel.AutoSize = true;
            weeklyHoursLabel.Location = new System.Drawing.Point(248, 231);
            weeklyHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            weeklyHoursLabel.Name = "weeklyHoursLabel";
            weeklyHoursLabel.Size = new System.Drawing.Size(82, 33);
            weeklyHoursLabel.TabIndex = 14;
            weeklyHoursLabel.Text = "כמות שעות שבועיות";
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
            this.BackToMenuBT.Location = new System.Drawing.Point(873, 9);
            this.BackToMenuBT.Margin = new System.Windows.Forms.Padding(2);
            this.BackToMenuBT.Name = "BackToMenuBT";
            this.BackToMenuBT.Size = new System.Drawing.Size(56, 46);
            this.BackToMenuBT.TabIndex = 1;
            this.BackToMenuBT.Text = "חזרה לתפריט";
            this.BackToMenuBT.UseVisualStyleBackColor = true;
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
            this.DegreeClassPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DegreeClassPage.Location = new System.Drawing.Point(4, 29);
            this.DegreeClassPage.Margin = new System.Windows.Forms.Padding(2);
            this.DegreeClassPage.Name = "DegreeClassPage";
            this.DegreeClassPage.Size = new System.Drawing.Size(912, 493);
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
            this.groupBox4.Location = new System.Drawing.Point(10, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(370, 487);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "פרטי המחזור";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.97285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.02715F));
            this.tableLayoutPanel1.Controls.Add(degreeClassIDLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.classMegamaCB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.degreeClassIDTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(degreeClassNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.degreeClassNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.weeklyHoursNumericUpDown, 1, 7);
            this.tableLayoutPanel1.Controls.Add(weeklyHoursLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.summerCheckBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(summerLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.durationNumericUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(durationLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.startingSemesterComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(startingSemesterLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.numberOfStudentsNumericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(degreeIDLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(numberOfStudentsLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 264);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // classMegamaCB
            // 
            this.classMegamaCB.DataSource = this.degreeBindingSource1;
            this.classMegamaCB.DisplayMember = "DegreeName";
            this.classMegamaCB.Enabled = false;
            this.classMegamaCB.FormattingEnabled = true;
            this.classMegamaCB.Location = new System.Drawing.Point(2, 68);
            this.classMegamaCB.Margin = new System.Windows.Forms.Padding(2);
            this.classMegamaCB.Name = "classMegamaCB";
            this.classMegamaCB.Size = new System.Drawing.Size(209, 28);
            this.classMegamaCB.TabIndex = 17;
            // 
            // degreeBindingSource1
            // 
            this.degreeBindingSource1.DataMember = "Degree";
            this.degreeBindingSource1.DataSource = this.grilDataSet;
            // 
            // degreeClassIDTextBox
            // 
            this.degreeClassIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeClassBindingSource, "DegreeClassID", true));
            this.degreeClassIDTextBox.Enabled = false;
            this.degreeClassIDTextBox.Location = new System.Drawing.Point(2, 2);
            this.degreeClassIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.degreeClassIDTextBox.Name = "degreeClassIDTextBox";
            this.degreeClassIDTextBox.Size = new System.Drawing.Size(209, 26);
            this.degreeClassIDTextBox.TabIndex = 1;
            // 
            // degreeClassBindingSource
            // 
            this.degreeClassBindingSource.DataMember = "DegreeClass";
            this.degreeClassBindingSource.DataSource = this.grilDataSet;
            // 
            // degreeClassNameTextBox
            // 
            this.degreeClassNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeClassBindingSource, "DegreeClassName", true));
            this.degreeClassNameTextBox.Enabled = false;
            this.degreeClassNameTextBox.Location = new System.Drawing.Point(2, 35);
            this.degreeClassNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.degreeClassNameTextBox.Name = "degreeClassNameTextBox";
            this.degreeClassNameTextBox.Size = new System.Drawing.Size(209, 26);
            this.degreeClassNameTextBox.TabIndex = 3;
            // 
            // weeklyHoursNumericUpDown
            // 
            this.weeklyHoursNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.degreeClassBindingSource, "WeeklyHours", true));
            this.weeklyHoursNumericUpDown.Enabled = false;
            this.weeklyHoursNumericUpDown.Location = new System.Drawing.Point(3, 233);
            this.weeklyHoursNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.weeklyHoursNumericUpDown.Name = "weeklyHoursNumericUpDown";
            this.weeklyHoursNumericUpDown.Size = new System.Drawing.Size(208, 26);
            this.weeklyHoursNumericUpDown.TabIndex = 15;
            // 
            // summerCheckBox
            // 
            this.summerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.degreeClassBindingSource, "Summer", true));
            this.summerCheckBox.Enabled = false;
            this.summerCheckBox.Location = new System.Drawing.Point(124, 200);
            this.summerCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.summerCheckBox.Name = "summerCheckBox";
            this.summerCheckBox.Size = new System.Drawing.Size(87, 20);
            this.summerCheckBox.TabIndex = 13;
            this.summerCheckBox.Text = "לא";
            this.summerCheckBox.UseVisualStyleBackColor = true;
            this.summerCheckBox.CheckedChanged += new System.EventHandler(this.summerCheckBox_CheckedChanged);
            // 
            // durationNumericUpDown
            // 
            this.durationNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.degreeClassBindingSource, "Duration", true));
            this.durationNumericUpDown.Enabled = false;
            this.durationNumericUpDown.Location = new System.Drawing.Point(3, 167);
            this.durationNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.durationNumericUpDown.Name = "durationNumericUpDown";
            this.durationNumericUpDown.Size = new System.Drawing.Size(208, 26);
            this.durationNumericUpDown.TabIndex = 11;
            // 
            // startingSemesterComboBox
            // 
            this.startingSemesterComboBox.DataSource = this.semesterBindingSource;
            this.startingSemesterComboBox.DisplayMember = "SemesterFullName";
            this.startingSemesterComboBox.Enabled = false;
            this.startingSemesterComboBox.FormattingEnabled = true;
            this.startingSemesterComboBox.Location = new System.Drawing.Point(2, 134);
            this.startingSemesterComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.startingSemesterComboBox.Name = "startingSemesterComboBox";
            this.startingSemesterComboBox.Size = new System.Drawing.Size(209, 28);
            this.startingSemesterComboBox.TabIndex = 9;
            // 
            // numberOfStudentsNumericUpDown
            // 
            this.numberOfStudentsNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.degreeClassBindingSource, "NumberOfStudents", true));
            this.numberOfStudentsNumericUpDown.Enabled = false;
            this.numberOfStudentsNumericUpDown.Location = new System.Drawing.Point(3, 101);
            this.numberOfStudentsNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfStudentsNumericUpDown.Name = "numberOfStudentsNumericUpDown";
            this.numberOfStudentsNumericUpDown.Size = new System.Drawing.Size(208, 26);
            this.numberOfStudentsNumericUpDown.TabIndex = 7;
            // 
            // delClassBT
            // 
            this.delClassBT.Location = new System.Drawing.Point(3, 297);
            this.delClassBT.Margin = new System.Windows.Forms.Padding(2);
            this.delClassBT.Name = "delClassBT";
            this.delClassBT.Size = new System.Drawing.Size(65, 40);
            this.delClassBT.TabIndex = 16;
            this.delClassBT.Text = "מחק";
            this.delClassBT.UseVisualStyleBackColor = true;
            this.delClassBT.Click += new System.EventHandler(this.delClassBT_Click);
            // 
            // saveClassBT
            // 
            this.saveClassBT.Location = new System.Drawing.Point(92, 297);
            this.saveClassBT.Margin = new System.Windows.Forms.Padding(2);
            this.saveClassBT.Name = "saveClassBT";
            this.saveClassBT.Size = new System.Drawing.Size(65, 40);
            this.saveClassBT.TabIndex = 16;
            this.saveClassBT.Text = "שמור";
            this.saveClassBT.UseVisualStyleBackColor = true;
            this.saveClassBT.Click += new System.EventHandler(this.saveClassBT_Click);
            // 
            // editClassBT
            // 
            this.editClassBT.Location = new System.Drawing.Point(182, 297);
            this.editClassBT.Margin = new System.Windows.Forms.Padding(2);
            this.editClassBT.Name = "editClassBT";
            this.editClassBT.Size = new System.Drawing.Size(65, 40);
            this.editClassBT.TabIndex = 16;
            this.editClassBT.Text = "ערוך";
            this.editClassBT.UseVisualStyleBackColor = true;
            this.editClassBT.Click += new System.EventHandler(this.editClassBT_Click);
            // 
            // newClassBT
            // 
            this.newClassBT.Location = new System.Drawing.Point(271, 297);
            this.newClassBT.Margin = new System.Windows.Forms.Padding(2);
            this.newClassBT.Name = "newClassBT";
            this.newClassBT.Size = new System.Drawing.Size(65, 40);
            this.newClassBT.TabIndex = 16;
            this.newClassBT.Text = "חדש";
            this.newClassBT.UseVisualStyleBackColor = true;
            this.newClassBT.Click += new System.EventHandler(this.newClassBT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.classDegGrid);
            this.groupBox3.Controls.Add(this.classDegCB);
            this.groupBox3.Controls.Add(this.classFacCB);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Location = new System.Drawing.Point(386, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(506, 487);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "מחזורים";
            // 
            // classDegGrid
            // 
            this.classDegGrid.AllowUserToAddRows = false;
            this.classDegGrid.AllowUserToDeleteRows = false;
            this.classDegGrid.AutoGenerateColumns = false;
            this.classDegGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classDegGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.classDegGrid.Location = new System.Drawing.Point(10, 48);
            this.classDegGrid.Margin = new System.Windows.Forms.Padding(2);
            this.classDegGrid.Name = "classDegGrid";
            this.classDegGrid.ReadOnly = true;
            this.classDegGrid.RowTemplate.Height = 24;
            this.classDegGrid.Size = new System.Drawing.Size(496, 429);
            this.classDegGrid.TabIndex = 2;
            this.classDegGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.classDegGrid_RowEnter);
            // 
            // hebrewYearDataGridViewTextBoxColumn1
            // 
            this.hebrewYearDataGridViewTextBoxColumn1.DataPropertyName = "HebrewYear";
            this.hebrewYearDataGridViewTextBoxColumn1.HeaderText = "שנה";
            this.hebrewYearDataGridViewTextBoxColumn1.Name = "hebrewYearDataGridViewTextBoxColumn1";
            this.hebrewYearDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // semesterTypeDataGridViewTextBoxColumn1
            // 
            this.semesterTypeDataGridViewTextBoxColumn1.DataPropertyName = "SemesterType";
            this.semesterTypeDataGridViewTextBoxColumn1.HeaderText = "סוג סמסטר";
            this.semesterTypeDataGridViewTextBoxColumn1.Name = "semesterTypeDataGridViewTextBoxColumn1";
            this.semesterTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // degreeClassIDDataGridViewTextBoxColumn
            // 
            this.degreeClassIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.HeaderText = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.Name = "degreeClassIDDataGridViewTextBoxColumn";
            this.degreeClassIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeClassIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // degreeClassNameDataGridViewTextBoxColumn
            // 
            this.degreeClassNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeClassNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeClassName";
            this.degreeClassNameDataGridViewTextBoxColumn.HeaderText = "שם מחזור";
            this.degreeClassNameDataGridViewTextBoxColumn.Name = "degreeClassNameDataGridViewTextBoxColumn";
            this.degreeClassNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeIDDataGridViewTextBoxColumn1
            // 
            this.degreeIDDataGridViewTextBoxColumn1.DataPropertyName = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn1.HeaderText = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn1.Name = "degreeIDDataGridViewTextBoxColumn1";
            this.degreeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.degreeIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numberOfStudentsDataGridViewTextBoxColumn
            // 
            this.numberOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.HeaderText = "NumberOfStudents";
            this.numberOfStudentsDataGridViewTextBoxColumn.Name = "numberOfStudentsDataGridViewTextBoxColumn";
            this.numberOfStudentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfStudentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // startingSemesterDataGridViewTextBoxColumn
            // 
            this.startingSemesterDataGridViewTextBoxColumn.DataPropertyName = "StartingSemester";
            this.startingSemesterDataGridViewTextBoxColumn.HeaderText = "StartingSemester";
            this.startingSemesterDataGridViewTextBoxColumn.Name = "startingSemesterDataGridViewTextBoxColumn";
            this.startingSemesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.startingSemesterDataGridViewTextBoxColumn.Visible = false;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn.Visible = false;
            // 
            // summerDataGridViewCheckBoxColumn
            // 
            this.summerDataGridViewCheckBoxColumn.DataPropertyName = "Summer";
            this.summerDataGridViewCheckBoxColumn.HeaderText = "Summer";
            this.summerDataGridViewCheckBoxColumn.Name = "summerDataGridViewCheckBoxColumn";
            this.summerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.summerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // weeklyHoursDataGridViewTextBoxColumn
            // 
            this.weeklyHoursDataGridViewTextBoxColumn.DataPropertyName = "WeeklyHours";
            this.weeklyHoursDataGridViewTextBoxColumn.HeaderText = "WeeklyHours";
            this.weeklyHoursDataGridViewTextBoxColumn.Name = "weeklyHoursDataGridViewTextBoxColumn";
            this.weeklyHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.weeklyHoursDataGridViewTextBoxColumn.Visible = false;
            // 
            // classDegCB
            // 
            this.classDegCB.DataSource = this.degreeBindingSource;
            this.classDegCB.DisplayMember = "DegreeName";
            this.classDegCB.FormattingEnabled = true;
            this.classDegCB.Location = new System.Drawing.Point(10, 20);
            this.classDegCB.Margin = new System.Windows.Forms.Padding(2);
            this.classDegCB.Name = "classDegCB";
            this.classDegCB.Size = new System.Drawing.Size(186, 28);
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
            this.classFacCB.FormattingEnabled = true;
            this.classFacCB.Location = new System.Drawing.Point(251, 20);
            this.classFacCB.Margin = new System.Windows.Forms.Padding(2);
            this.classFacCB.Name = "classFacCB";
            this.classFacCB.Size = new System.Drawing.Size(186, 28);
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
            this.label18.Location = new System.Drawing.Point(205, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "מגמה:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(446, 24);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
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
            this.FacultyPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FacultyPage.Location = new System.Drawing.Point(4, 29);
            this.FacultyPage.Margin = new System.Windows.Forms.Padding(2);
            this.FacultyPage.Name = "FacultyPage";
            this.FacultyPage.Size = new System.Drawing.Size(912, 493);
            this.FacultyPage.TabIndex = 5;
            this.FacultyPage.Text = "פקולטות ומגמות";
            this.FacultyPage.UseVisualStyleBackColor = true;
            // 
            // delDegBT
            // 
            this.delDegBT.Location = new System.Drawing.Point(32, 439);
            this.delDegBT.Margin = new System.Windows.Forms.Padding(2);
            this.delDegBT.Name = "delDegBT";
            this.delDegBT.Size = new System.Drawing.Size(56, 24);
            this.delDegBT.TabIndex = 11;
            this.delDegBT.Text = "מחק";
            this.delDegBT.UseVisualStyleBackColor = true;
            this.delDegBT.Click += new System.EventHandler(this.delDegBT_Click);
            // 
            // newDegBT
            // 
            this.newDegBT.Location = new System.Drawing.Point(32, 415);
            this.newDegBT.Margin = new System.Windows.Forms.Padding(2);
            this.newDegBT.Name = "newDegBT";
            this.newDegBT.Size = new System.Drawing.Size(56, 24);
            this.newDegBT.TabIndex = 10;
            this.newDegBT.Text = "חדש";
            this.newDegBT.UseVisualStyleBackColor = true;
            this.newDegBT.Click += new System.EventHandler(this.newDegBT_Click);
            // 
            // saveDegBT
            // 
            this.saveDegBT.Location = new System.Drawing.Point(101, 439);
            this.saveDegBT.Margin = new System.Windows.Forms.Padding(2);
            this.saveDegBT.Name = "saveDegBT";
            this.saveDegBT.Size = new System.Drawing.Size(56, 24);
            this.saveDegBT.TabIndex = 9;
            this.saveDegBT.Text = "שמור";
            this.saveDegBT.UseVisualStyleBackColor = true;
            this.saveDegBT.Click += new System.EventHandler(this.saveDegBT_Click);
            // 
            // editDegBT
            // 
            this.editDegBT.Location = new System.Drawing.Point(101, 415);
            this.editDegBT.Margin = new System.Windows.Forms.Padding(2);
            this.editDegBT.Name = "editDegBT";
            this.editDegBT.Size = new System.Drawing.Size(56, 24);
            this.editDegBT.TabIndex = 8;
            this.editDegBT.Text = "ערוך";
            this.editDegBT.UseVisualStyleBackColor = true;
            this.editDegBT.Click += new System.EventHandler(this.editDegBT_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(214, 415);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "שם פקולטה";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 415);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "שם מגמה";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(424, 415);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "מזהה מגמה";
            // 
            // degFacCB
            // 
            this.degFacCB.DataSource = this.facultyBindingSource;
            this.degFacCB.DisplayMember = "FacultyName";
            this.degFacCB.Enabled = false;
            this.degFacCB.FormattingEnabled = true;
            this.degFacCB.Location = new System.Drawing.Point(170, 441);
            this.degFacCB.Margin = new System.Windows.Forms.Padding(2);
            this.degFacCB.Name = "degFacCB";
            this.degFacCB.Size = new System.Drawing.Size(104, 28);
            this.degFacCB.TabIndex = 6;
            // 
            // degNameTB
            // 
            this.degNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeBindingSource, "DegreeName", true));
            this.degNameTB.Enabled = false;
            this.degNameTB.Location = new System.Drawing.Point(278, 441);
            this.degNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.degNameTB.Name = "degNameTB";
            this.degNameTB.Size = new System.Drawing.Size(128, 26);
            this.degNameTB.TabIndex = 4;
            // 
            // degIDTB
            // 
            this.degIDTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreeBindingSource, "DegreeID", true));
            this.degIDTB.Enabled = false;
            this.degIDTB.Location = new System.Drawing.Point(409, 441);
            this.degIDTB.Margin = new System.Windows.Forms.Padding(2);
            this.degIDTB.Name = "degIDTB";
            this.degIDTB.Size = new System.Drawing.Size(76, 26);
            this.degIDTB.TabIndex = 3;
            // 
            // deleteFacultyBT
            // 
            this.deleteFacultyBT.Location = new System.Drawing.Point(747, 405);
            this.deleteFacultyBT.Margin = new System.Windows.Forms.Padding(2);
            this.deleteFacultyBT.Name = "deleteFacultyBT";
            this.deleteFacultyBT.Size = new System.Drawing.Size(56, 46);
            this.deleteFacultyBT.TabIndex = 2;
            this.deleteFacultyBT.Text = "מחק פקולטה";
            this.deleteFacultyBT.UseVisualStyleBackColor = true;
            this.deleteFacultyBT.Click += new System.EventHandler(this.deleteFacultyBT_Click);
            // 
            // addFacultyBT
            // 
            this.addFacultyBT.Location = new System.Drawing.Point(847, 405);
            this.addFacultyBT.Margin = new System.Windows.Forms.Padding(2);
            this.addFacultyBT.Name = "addFacultyBT";
            this.addFacultyBT.Size = new System.Drawing.Size(56, 46);
            this.addFacultyBT.TabIndex = 2;
            this.addFacultyBT.Text = "הוסף פקולטה";
            this.addFacultyBT.UseVisualStyleBackColor = true;
            this.addFacultyBT.Click += new System.EventHandler(this.addFacultyBT_Click);
            // 
            // degreeGrid
            // 
            this.degreeGrid.AllowUserToAddRows = false;
            this.degreeGrid.AllowUserToDeleteRows = false;
            this.degreeGrid.AutoGenerateColumns = false;
            this.degreeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.degreeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeIDDataGridViewTextBoxColumn,
            this.degreeNameDataGridViewTextBoxColumn,
            this.facultyIDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.degreeGrid.DataSource = this.degreeBindingSource;
            this.degreeGrid.Location = new System.Drawing.Point(20, 11);
            this.degreeGrid.Margin = new System.Windows.Forms.Padding(2);
            this.degreeGrid.Name = "degreeGrid";
            this.degreeGrid.RowTemplate.Height = 24;
            this.degreeGrid.Size = new System.Drawing.Size(467, 389);
            this.degreeGrid.TabIndex = 1;
            // 
            // degreeIDDataGridViewTextBoxColumn
            // 
            this.degreeIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeID";
            this.degreeIDDataGridViewTextBoxColumn.HeaderText = "מזהה מגמה";
            this.degreeIDDataGridViewTextBoxColumn.Name = "degreeIDDataGridViewTextBoxColumn";
            this.degreeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeNameDataGridViewTextBoxColumn
            // 
            this.degreeNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeName";
            this.degreeNameDataGridViewTextBoxColumn.HeaderText = "שם מגמה";
            this.degreeNameDataGridViewTextBoxColumn.Name = "degreeNameDataGridViewTextBoxColumn";
            // 
            // facultyIDDataGridViewTextBoxColumn1
            // 
            this.facultyIDDataGridViewTextBoxColumn1.DataPropertyName = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn1.HeaderText = "מזהה פקולטה";
            this.facultyIDDataGridViewTextBoxColumn1.Name = "facultyIDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FacultyName";
            this.dataGridViewTextBoxColumn1.HeaderText = "שם פקולטה";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // facultyGrid
            // 
            this.facultyGrid.AllowUserToAddRows = false;
            this.facultyGrid.AllowUserToDeleteRows = false;
            this.facultyGrid.AutoGenerateColumns = false;
            this.facultyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facultyIDDataGridViewTextBoxColumn,
            this.FacultyName});
            this.facultyGrid.DataSource = this.facultyBindingSource;
            this.facultyGrid.Location = new System.Drawing.Point(620, 11);
            this.facultyGrid.Margin = new System.Windows.Forms.Padding(2);
            this.facultyGrid.Name = "facultyGrid";
            this.facultyGrid.RowTemplate.Height = 24;
            this.facultyGrid.Size = new System.Drawing.Size(284, 389);
            this.facultyGrid.TabIndex = 0;
            this.facultyGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_CellValueChanged);
            this.facultyGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_RowEnter);
            this.facultyGrid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.facultyGrid_RowValidated);
            // 
            // facultyIDDataGridViewTextBoxColumn
            // 
            this.facultyIDDataGridViewTextBoxColumn.DataPropertyName = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn.HeaderText = "מזהה פקולטה";
            this.facultyIDDataGridViewTextBoxColumn.Name = "facultyIDDataGridViewTextBoxColumn";
            this.facultyIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FacultyName
            // 
            this.FacultyName.DataPropertyName = "FacultyName";
            this.FacultyName.HeaderText = "שם פקולטה";
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
            this.SemestersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SemestersPage.Location = new System.Drawing.Point(4, 29);
            this.SemestersPage.Margin = new System.Windows.Forms.Padding(2);
            this.SemestersPage.Name = "SemestersPage";
            this.SemestersPage.Size = new System.Drawing.Size(912, 493);
            this.SemestersPage.TabIndex = 4;
            this.SemestersPage.Text = "סמסטרים";
            this.SemestersPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ת. סיום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ת. תחילה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "סוג";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "שנה";
            // 
            // deleteSemesterBT
            // 
            this.deleteSemesterBT.Location = new System.Drawing.Point(8, 394);
            this.deleteSemesterBT.Name = "deleteSemesterBT";
            this.deleteSemesterBT.Size = new System.Drawing.Size(75, 30);
            this.deleteSemesterBT.TabIndex = 3;
            this.deleteSemesterBT.Text = "מחק";
            this.deleteSemesterBT.UseVisualStyleBackColor = true;
            this.deleteSemesterBT.Click += new System.EventHandler(this.deleteSemesterBT_Click);
            // 
            // addNewSemesterBT
            // 
            this.addNewSemesterBT.Location = new System.Drawing.Point(92, 394);
            this.addNewSemesterBT.Name = "addNewSemesterBT";
            this.addNewSemesterBT.Size = new System.Drawing.Size(75, 30);
            this.addNewSemesterBT.TabIndex = 3;
            this.addNewSemesterBT.Text = "חדש";
            this.addNewSemesterBT.UseVisualStyleBackColor = true;
            this.addNewSemesterBT.Click += new System.EventHandler(this.addNewSemesterBT_Click);
            // 
            // saveSemesterBT
            // 
            this.saveSemesterBT.Location = new System.Drawing.Point(176, 394);
            this.saveSemesterBT.Name = "saveSemesterBT";
            this.saveSemesterBT.Size = new System.Drawing.Size(75, 30);
            this.saveSemesterBT.TabIndex = 3;
            this.saveSemesterBT.Text = "שמור";
            this.saveSemesterBT.UseVisualStyleBackColor = true;
            this.saveSemesterBT.Click += new System.EventHandler(this.saveSemesterBT_Click);
            // 
            // enddaSemesterPicker
            // 
            this.enddaSemesterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddaSemesterPicker.Location = new System.Drawing.Point(260, 396);
            this.enddaSemesterPicker.Name = "enddaSemesterPicker";
            this.enddaSemesterPicker.Size = new System.Drawing.Size(118, 26);
            this.enddaSemesterPicker.TabIndex = 2;
            // 
            // begdaSemesterPicker
            // 
            this.begdaSemesterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.begdaSemesterPicker.Location = new System.Drawing.Point(387, 396);
            this.begdaSemesterPicker.Name = "begdaSemesterPicker";
            this.begdaSemesterPicker.Size = new System.Drawing.Size(118, 26);
            this.begdaSemesterPicker.TabIndex = 2;
            // 
            // semesterTypeCB
            // 
            this.semesterTypeCB.FormattingEnabled = true;
            this.semesterTypeCB.Items.AddRange(new object[] {
            "חורף",
            "אביב",
            "קיץ"});
            this.semesterTypeCB.Location = new System.Drawing.Point(514, 395);
            this.semesterTypeCB.Name = "semesterTypeCB";
            this.semesterTypeCB.Size = new System.Drawing.Size(121, 28);
            this.semesterTypeCB.TabIndex = 1;
            // 
            // SemesterYearCB
            // 
            this.SemesterYearCB.FormattingEnabled = true;
            this.SemesterYearCB.Items.AddRange(new object[] {
            "תשפא",
            "תשפב",
            "תשפג",
            "תשפד",
            "תשפה",
            "תשפו",
            "תשפז"});
            this.SemesterYearCB.Location = new System.Drawing.Point(644, 395);
            this.SemesterYearCB.Name = "SemesterYearCB";
            this.SemesterYearCB.Size = new System.Drawing.Size(121, 28);
            this.SemesterYearCB.TabIndex = 1;
            // 
            // SemesterDataGridView
            // 
            this.SemesterDataGridView.AllowUserToAddRows = false;
            this.SemesterDataGridView.AllowUserToDeleteRows = false;
            this.SemesterDataGridView.AutoGenerateColumns = false;
            this.SemesterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SemesterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.semesterIDDataGridViewTextBoxColumn,
            this.hebrewYearDataGridViewTextBoxColumn,
            this.semesterTypeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.SemesterDataGridView.DataSource = this.semesterBindingSource;
            this.SemesterDataGridView.Location = new System.Drawing.Point(8, 3);
            this.SemesterDataGridView.Name = "SemesterDataGridView";
            this.SemesterDataGridView.ReadOnly = true;
            this.SemesterDataGridView.Size = new System.Drawing.Size(883, 354);
            this.SemesterDataGridView.TabIndex = 0;
            this.SemesterDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SemesterDataGridView_RowEnter);
            // 
            // semesterIDDataGridViewTextBoxColumn
            // 
            this.semesterIDDataGridViewTextBoxColumn.DataPropertyName = "SemesterID";
            this.semesterIDDataGridViewTextBoxColumn.HeaderText = "מזהה סמסטר";
            this.semesterIDDataGridViewTextBoxColumn.Name = "semesterIDDataGridViewTextBoxColumn";
            this.semesterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hebrewYearDataGridViewTextBoxColumn
            // 
            this.hebrewYearDataGridViewTextBoxColumn.DataPropertyName = "HebrewYear";
            this.hebrewYearDataGridViewTextBoxColumn.HeaderText = "שנה עברית";
            this.hebrewYearDataGridViewTextBoxColumn.Name = "hebrewYearDataGridViewTextBoxColumn";
            this.hebrewYearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterTypeDataGridViewTextBoxColumn
            // 
            this.semesterTypeDataGridViewTextBoxColumn.DataPropertyName = "SemesterType";
            this.semesterTypeDataGridViewTextBoxColumn.HeaderText = "סוג סמסטר";
            this.semesterTypeDataGridViewTextBoxColumn.Name = "semesterTypeDataGridViewTextBoxColumn";
            this.semesterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "תאריך תחילה";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "תאריך סיום";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FeaturesPage
            // 
            this.FeaturesPage.Controls.Add(this.removeFeatBT);
            this.FeaturesPage.Controls.Add(this.featureLabel);
            this.FeaturesPage.Controls.Add(this.addFeatureBT);
            this.FeaturesPage.Controls.Add(this.features_gridView);
            this.FeaturesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FeaturesPage.Location = new System.Drawing.Point(4, 29);
            this.FeaturesPage.Margin = new System.Windows.Forms.Padding(2);
            this.FeaturesPage.Name = "FeaturesPage";
            this.FeaturesPage.Size = new System.Drawing.Size(912, 493);
            this.FeaturesPage.TabIndex = 3;
            this.FeaturesPage.Text = "מאפיינים";
            this.FeaturesPage.UseVisualStyleBackColor = true;
            // 
            // removeFeatBT
            // 
            this.removeFeatBT.Location = new System.Drawing.Point(35, 195);
            this.removeFeatBT.Margin = new System.Windows.Forms.Padding(2);
            this.removeFeatBT.Name = "removeFeatBT";
            this.removeFeatBT.Size = new System.Drawing.Size(75, 62);
            this.removeFeatBT.TabIndex = 3;
            this.removeFeatBT.Text = "מחק";
            this.removeFeatBT.UseVisualStyleBackColor = true;
            this.removeFeatBT.Click += new System.EventHandler(this.removeFeatBT_Click);
            // 
            // featureLabel
            // 
            this.featureLabel.AutoSize = true;
            this.featureLabel.Location = new System.Drawing.Point(35, 304);
            this.featureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.featureLabel.Name = "featureLabel";
            this.featureLabel.Size = new System.Drawing.Size(51, 20);
            this.featureLabel.TabIndex = 2;
            this.featureLabel.Text = "label1";
            // 
            // addFeatureBT
            // 
            this.addFeatureBT.Location = new System.Drawing.Point(35, 53);
            this.addFeatureBT.Name = "addFeatureBT";
            this.addFeatureBT.Size = new System.Drawing.Size(75, 88);
            this.addFeatureBT.TabIndex = 1;
            this.addFeatureBT.Text = "הוסף מאפיין חדש";
            this.addFeatureBT.UseVisualStyleBackColor = true;
            this.addFeatureBT.Click += new System.EventHandler(this.addFeatureBT_Click);
            // 
            // features_gridView
            // 
            this.features_gridView.AllowUserToAddRows = false;
            this.features_gridView.AutoGenerateColumns = false;
            this.features_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.features_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featuresIDDataGridViewTextBoxColumn,
            this.featureNameDataGridViewTextBoxColumn,
            this.qualifierReqDataGridViewCheckBoxColumn});
            this.features_gridView.DataSource = this.featuresBindingSource;
            this.features_gridView.Location = new System.Drawing.Point(149, 25);
            this.features_gridView.Margin = new System.Windows.Forms.Padding(2);
            this.features_gridView.Name = "features_gridView";
            this.features_gridView.RowHeadersWidth = 51;
            this.features_gridView.RowTemplate.Height = 24;
            this.features_gridView.Size = new System.Drawing.Size(592, 357);
            this.features_gridView.TabIndex = 0;
            this.features_gridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.features_gridView_RowEnter);
            this.features_gridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.features_gridView_RowValidated);
            // 
            // featuresIDDataGridViewTextBoxColumn
            // 
            this.featuresIDDataGridViewTextBoxColumn.DataPropertyName = "FeaturesID";
            this.featuresIDDataGridViewTextBoxColumn.HeaderText = "מזהה מאפיין";
            this.featuresIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.featuresIDDataGridViewTextBoxColumn.Name = "featuresIDDataGridViewTextBoxColumn";
            this.featuresIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // featureNameDataGridViewTextBoxColumn
            // 
            this.featureNameDataGridViewTextBoxColumn.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.featureNameDataGridViewTextBoxColumn.Name = "featureNameDataGridViewTextBoxColumn";
            this.featureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // qualifierReqDataGridViewCheckBoxColumn
            // 
            this.qualifierReqDataGridViewCheckBoxColumn.DataPropertyName = "QualifierReq";
            this.qualifierReqDataGridViewCheckBoxColumn.HeaderText = "נדרש מספר?";
            this.qualifierReqDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.qualifierReqDataGridViewCheckBoxColumn.Name = "qualifierReqDataGridViewCheckBoxColumn";
            this.qualifierReqDataGridViewCheckBoxColumn.Width = 125;
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
            this.RoomsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RoomsPage.Location = new System.Drawing.Point(4, 29);
            this.RoomsPage.Margin = new System.Windows.Forms.Padding(2);
            this.RoomsPage.Name = "RoomsPage";
            this.RoomsPage.Size = new System.Drawing.Size(912, 493);
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
            this.groupBox2.Location = new System.Drawing.Point(2, 188);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(593, 292);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "מאפיינים";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "מאפיינים לחדר";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "תפריט מאפיינים";
            // 
            // removeFeatureFromRoomBT
            // 
            this.removeFeatureFromRoomBT.Location = new System.Drawing.Point(290, 140);
            this.removeFeatureFromRoomBT.Margin = new System.Windows.Forms.Padding(2);
            this.removeFeatureFromRoomBT.Name = "removeFeatureFromRoomBT";
            this.removeFeatureFromRoomBT.Size = new System.Drawing.Size(44, 32);
            this.removeFeatureFromRoomBT.TabIndex = 2;
            this.removeFeatureFromRoomBT.Text = "-->";
            this.removeFeatureFromRoomBT.UseVisualStyleBackColor = true;
            this.removeFeatureFromRoomBT.Click += new System.EventHandler(this.removeFeatureFromRoomBT_Click);
            // 
            // addFeatureToRoomBT
            // 
            this.addFeatureToRoomBT.AllowDrop = true;
            this.addFeatureToRoomBT.Location = new System.Drawing.Point(290, 94);
            this.addFeatureToRoomBT.Margin = new System.Windows.Forms.Padding(2);
            this.addFeatureToRoomBT.Name = "addFeatureToRoomBT";
            this.addFeatureToRoomBT.Size = new System.Drawing.Size(44, 32);
            this.addFeatureToRoomBT.TabIndex = 2;
            this.addFeatureToRoomBT.Text = "<--";
            this.addFeatureToRoomBT.UseVisualStyleBackColor = true;
            this.addFeatureToRoomBT.Click += new System.EventHandler(this.addFeatureToRoomBT_Click);
            // 
            // featuresMenuGrid
            // 
            this.featuresMenuGrid.AllowUserToAddRows = false;
            this.featuresMenuGrid.AllowUserToDeleteRows = false;
            this.featuresMenuGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.featuresMenuGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.featuresMenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.featuresMenuGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.featureNameDataGridViewTextBoxColumn2,
            this.qualifierReqDataGridViewCheckBoxColumn1});
            this.featuresMenuGrid.DataSource = this.featuresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.featuresMenuGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.featuresMenuGrid.Location = new System.Drawing.Point(4, 46);
            this.featuresMenuGrid.Margin = new System.Windows.Forms.Padding(2);
            this.featuresMenuGrid.MultiSelect = false;
            this.featuresMenuGrid.Name = "featuresMenuGrid";
            this.featuresMenuGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.featuresMenuGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.featuresMenuGrid.RowTemplate.Height = 24;
            this.featuresMenuGrid.ShowCellErrors = false;
            this.featuresMenuGrid.ShowCellToolTips = false;
            this.featuresMenuGrid.ShowEditingIcon = false;
            this.featuresMenuGrid.ShowRowErrors = false;
            this.featuresMenuGrid.Size = new System.Drawing.Size(268, 241);
            this.featuresMenuGrid.TabIndex = 1;
            this.featuresMenuGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.featuresMenuGrid_RowEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "FeaturesID";
            this.Column1.HeaderText = "FeaturesID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 5;
            // 
            // featureNameDataGridViewTextBoxColumn2
            // 
            this.featureNameDataGridViewTextBoxColumn2.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn2.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn2.Name = "featureNameDataGridViewTextBoxColumn2";
            this.featureNameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // qualifierReqDataGridViewCheckBoxColumn1
            // 
            this.qualifierReqDataGridViewCheckBoxColumn1.DataPropertyName = "QualifierReq";
            this.qualifierReqDataGridViewCheckBoxColumn1.HeaderText = "דורש ערך?";
            this.qualifierReqDataGridViewCheckBoxColumn1.Name = "qualifierReqDataGridViewCheckBoxColumn1";
            this.qualifierReqDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // roomFeaturesGridView
            // 
            this.roomFeaturesGridView.AllowUserToAddRows = false;
            this.roomFeaturesGridView.AllowUserToDeleteRows = false;
            this.roomFeaturesGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFeaturesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.roomFeaturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomFeaturesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn1,
            this.FeaturesID,
            this.roomNameDataGridViewTextBoxColumn1,
            this.featureNameDataGridViewTextBoxColumn1,
            this.qualifierDataGridViewTextBoxColumn});
            this.roomFeaturesGridView.DataSource = this.allRoomsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomFeaturesGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.roomFeaturesGridView.Location = new System.Drawing.Point(338, 46);
            this.roomFeaturesGridView.Margin = new System.Windows.Forms.Padding(2);
            this.roomFeaturesGridView.Name = "roomFeaturesGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomFeaturesGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.roomFeaturesGridView.RowTemplate.Height = 24;
            this.roomFeaturesGridView.ShowCellErrors = false;
            this.roomFeaturesGridView.ShowCellToolTips = false;
            this.roomFeaturesGridView.ShowEditingIcon = false;
            this.roomFeaturesGridView.ShowRowErrors = false;
            this.roomFeaturesGridView.Size = new System.Drawing.Size(250, 241);
            this.roomFeaturesGridView.TabIndex = 0;
            this.roomFeaturesGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomFeaturesGridView_CellValidated);
            this.roomFeaturesGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomFeaturesGridView_RowEnter);
            // 
            // roomIDDataGridViewTextBoxColumn1
            // 
            this.roomIDDataGridViewTextBoxColumn1.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn1.Name = "roomIDDataGridViewTextBoxColumn1";
            this.roomIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // FeaturesID
            // 
            this.FeaturesID.DataPropertyName = "FeaturesID";
            this.FeaturesID.HeaderText = "FeaturesID";
            this.FeaturesID.Name = "FeaturesID";
            this.FeaturesID.ReadOnly = true;
            this.FeaturesID.Visible = false;
            // 
            // roomNameDataGridViewTextBoxColumn1
            // 
            this.roomNameDataGridViewTextBoxColumn1.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn1.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn1.Name = "roomNameDataGridViewTextBoxColumn1";
            this.roomNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roomNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // featureNameDataGridViewTextBoxColumn1
            // 
            this.featureNameDataGridViewTextBoxColumn1.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn1.HeaderText = "שם מאפיין";
            this.featureNameDataGridViewTextBoxColumn1.Name = "featureNameDataGridViewTextBoxColumn1";
            this.featureNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qualifierDataGridViewTextBoxColumn
            // 
            this.qualifierDataGridViewTextBoxColumn.DataPropertyName = "Qualifier";
            this.qualifierDataGridViewTextBoxColumn.HeaderText = "ערך מאפיין";
            this.qualifierDataGridViewTextBoxColumn.Name = "qualifierDataGridViewTextBoxColumn";
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
            this.groupBox1.Location = new System.Drawing.Point(2, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(593, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי החדר";
            // 
            // roomDeleteBT
            // 
            this.roomDeleteBT.Location = new System.Drawing.Point(190, 105);
            this.roomDeleteBT.Margin = new System.Windows.Forms.Padding(2);
            this.roomDeleteBT.Name = "roomDeleteBT";
            this.roomDeleteBT.Size = new System.Drawing.Size(56, 28);
            this.roomDeleteBT.TabIndex = 6;
            this.roomDeleteBT.Text = "מחק";
            this.roomDeleteBT.UseVisualStyleBackColor = true;
            this.roomDeleteBT.Click += new System.EventHandler(this.roomDeleteBT_Click);
            // 
            // roomNewBT
            // 
            this.roomNewBT.Location = new System.Drawing.Point(190, 76);
            this.roomNewBT.Margin = new System.Windows.Forms.Padding(2);
            this.roomNewBT.Name = "roomNewBT";
            this.roomNewBT.Size = new System.Drawing.Size(56, 28);
            this.roomNewBT.TabIndex = 6;
            this.roomNewBT.Text = "צור חדש";
            this.roomNewBT.UseVisualStyleBackColor = true;
            this.roomNewBT.Click += new System.EventHandler(this.roomNewBT_Click);
            // 
            // roomSaveBT
            // 
            this.roomSaveBT.Location = new System.Drawing.Point(190, 48);
            this.roomSaveBT.Margin = new System.Windows.Forms.Padding(2);
            this.roomSaveBT.Name = "roomSaveBT";
            this.roomSaveBT.Size = new System.Drawing.Size(56, 28);
            this.roomSaveBT.TabIndex = 6;
            this.roomSaveBT.Text = "שמור";
            this.roomSaveBT.UseVisualStyleBackColor = true;
            this.roomSaveBT.Click += new System.EventHandler(this.roomSaveBT_Click);
            // 
            // roomEditBT
            // 
            this.roomEditBT.Location = new System.Drawing.Point(190, 20);
            this.roomEditBT.Margin = new System.Windows.Forms.Padding(2);
            this.roomEditBT.Name = "roomEditBT";
            this.roomEditBT.Size = new System.Drawing.Size(56, 28);
            this.roomEditBT.TabIndex = 6;
            this.roomEditBT.Text = "ערוך";
            this.roomEditBT.UseVisualStyleBackColor = true;
            this.roomEditBT.Click += new System.EventHandler(this.roomEditBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "בניין";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "קמפוס";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "קומה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "שם החדר";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "מזהה חדר";
            // 
            // roomCampusTB
            // 
            this.roomCampusTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "campusName", true));
            this.roomCampusTB.Enabled = false;
            this.roomCampusTB.Location = new System.Drawing.Point(262, 136);
            this.roomCampusTB.Margin = new System.Windows.Forms.Padding(2);
            this.roomCampusTB.Name = "roomCampusTB";
            this.roomCampusTB.ReadOnly = true;
            this.roomCampusTB.Size = new System.Drawing.Size(146, 26);
            this.roomCampusTB.TabIndex = 4;
            // 
            // roomBuildingCB
            // 
            this.roomBuildingCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "BuildingName", true));
            this.roomBuildingCB.DataSource = this.buildingBindingSource;
            this.roomBuildingCB.DisplayMember = "BuildingName";
            this.roomBuildingCB.Enabled = false;
            this.roomBuildingCB.FormattingEnabled = true;
            this.roomBuildingCB.Location = new System.Drawing.Point(262, 106);
            this.roomBuildingCB.Margin = new System.Windows.Forms.Padding(2);
            this.roomBuildingCB.Name = "roomBuildingCB";
            this.roomBuildingCB.Size = new System.Drawing.Size(146, 28);
            this.roomBuildingCB.TabIndex = 3;
            // 
            // roomFloorTB
            // 
            this.roomFloorTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "Floor", true));
            this.roomFloorTB.Enabled = false;
            this.roomFloorTB.Location = new System.Drawing.Point(262, 77);
            this.roomFloorTB.Margin = new System.Windows.Forms.Padding(2);
            this.roomFloorTB.Name = "roomFloorTB";
            this.roomFloorTB.Size = new System.Drawing.Size(146, 26);
            this.roomFloorTB.TabIndex = 2;
            // 
            // roomNameTB
            // 
            this.roomNameTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "RoomName", true));
            this.roomNameTB.Enabled = false;
            this.roomNameTB.Location = new System.Drawing.Point(262, 49);
            this.roomNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.roomNameTB.Name = "roomNameTB";
            this.roomNameTB.Size = new System.Drawing.Size(146, 26);
            this.roomNameTB.TabIndex = 1;
            // 
            // roomIDTB
            // 
            this.roomIDTB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsByCampusBindingSource, "RoomID", true));
            this.roomIDTB.Enabled = false;
            this.roomIDTB.Location = new System.Drawing.Point(262, 20);
            this.roomIDTB.Margin = new System.Windows.Forms.Padding(2);
            this.roomIDTB.Name = "roomIDTB";
            this.roomIDTB.ReadOnly = true;
            this.roomIDTB.Size = new System.Drawing.Size(146, 26);
            this.roomIDTB.TabIndex = 0;
            // 
            // campusNameComboBox
            // 
            this.campusNameComboBox.DataSource = this.buildingsByCampusBindingSource;
            this.campusNameComboBox.DisplayMember = "BuildingName";
            this.campusNameComboBox.FormattingEnabled = true;
            this.campusNameComboBox.Location = new System.Drawing.Point(694, 51);
            this.campusNameComboBox.Name = "campusNameComboBox";
            this.campusNameComboBox.Size = new System.Drawing.Size(151, 28);
            this.campusNameComboBox.TabIndex = 5;
            this.campusNameComboBox.SelectedIndexChanged += new System.EventHandler(this.campusNameComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(850, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "בניין:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "קמפוס:";
            // 
            // roomsDataGrid
            // 
            this.roomsDataGrid.AllowUserToAddRows = false;
            this.roomsDataGrid.AllowUserToDeleteRows = false;
            this.roomsDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.roomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn});
            this.roomsDataGrid.DataSource = this.roomsByCampusBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomsDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.roomsDataGrid.Location = new System.Drawing.Point(601, 87);
            this.roomsDataGrid.Name = "roomsDataGrid";
            this.roomsDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.roomsDataGrid.ShowCellErrors = false;
            this.roomsDataGrid.ShowCellToolTips = false;
            this.roomsDataGrid.ShowEditingIcon = false;
            this.roomsDataGrid.ShowRowErrors = false;
            this.roomsDataGrid.Size = new System.Drawing.Size(290, 392);
            this.roomsDataGrid.TabIndex = 1;
            this.roomsDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGrid_RowEnter);
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomIDDataGridViewTextBoxColumn.Width = 43;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "שם חדר";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNameDataGridViewTextBoxColumn.Width = 86;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "קומה";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.ReadOnly = true;
            this.floorDataGridViewTextBoxColumn.Width = 67;
            // 
            // roomsCampusCB
            // 
            this.roomsCampusCB.DataSource = this.campusBindingSource1;
            this.roomsCampusCB.DisplayMember = "campusName";
            this.roomsCampusCB.FormattingEnabled = true;
            this.roomsCampusCB.Location = new System.Drawing.Point(694, 12);
            this.roomsCampusCB.Name = "roomsCampusCB";
            this.roomsCampusCB.Size = new System.Drawing.Size(151, 28);
            this.roomsCampusCB.TabIndex = 0;
            this.roomsCampusCB.SelectedIndexChanged += new System.EventHandler(this.roomsCampusCB_SelectionChangeCommitted);
            // 
            // CampusPage
            // 
            this.CampusPage.Controls.Add(this.newCampusBT);
            this.CampusPage.Controls.Add(this.dataGridBuilding);
            this.CampusPage.Controls.Add(this.dataGridCampus);
            this.CampusPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CampusPage.Location = new System.Drawing.Point(4, 29);
            this.CampusPage.Margin = new System.Windows.Forms.Padding(2);
            this.CampusPage.Name = "CampusPage";
            this.CampusPage.Padding = new System.Windows.Forms.Padding(2);
            this.CampusPage.Size = new System.Drawing.Size(912, 493);
            this.CampusPage.TabIndex = 0;
            this.CampusPage.Text = "קמפוסים ובניינים";
            this.CampusPage.UseVisualStyleBackColor = true;
            // 
            // newCampusBT
            // 
            this.newCampusBT.Location = new System.Drawing.Point(323, 5);
            this.newCampusBT.Name = "newCampusBT";
            this.newCampusBT.Size = new System.Drawing.Size(79, 54);
            this.newCampusBT.TabIndex = 2;
            this.newCampusBT.Text = "קמפוס חדש";
            this.newCampusBT.UseVisualStyleBackColor = true;
            this.newCampusBT.Click += new System.EventHandler(this.newCampusBT_Click);
            // 
            // dataGridBuilding
            // 
            this.dataGridBuilding.AutoGenerateColumns = false;
            this.dataGridBuilding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridBuilding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuilding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildingIDDataGridViewTextBoxColumn,
            this.buildingNameDataGridViewTextBoxColumn,
            this.campusIDDataGridViewTextBoxColumn1});
            this.dataGridBuilding.DataSource = this.buildingBindingSource;
            this.dataGridBuilding.Location = new System.Drawing.Point(452, 215);
            this.dataGridBuilding.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridBuilding.Name = "dataGridBuilding";
            this.dataGridBuilding.RowHeadersWidth = 51;
            this.dataGridBuilding.RowTemplate.Height = 24;
            this.dataGridBuilding.Size = new System.Drawing.Size(321, 272);
            this.dataGridBuilding.TabIndex = 1;
            // 
            // buildingIDDataGridViewTextBoxColumn
            // 
            this.buildingIDDataGridViewTextBoxColumn.DataPropertyName = "BuildingID";
            this.buildingIDDataGridViewTextBoxColumn.HeaderText = "מזהה בניין";
            this.buildingIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingIDDataGridViewTextBoxColumn.Name = "buildingIDDataGridViewTextBoxColumn";
            this.buildingIDDataGridViewTextBoxColumn.Width = 104;
            // 
            // buildingNameDataGridViewTextBoxColumn
            // 
            this.buildingNameDataGridViewTextBoxColumn.DataPropertyName = "BuildingName";
            this.buildingNameDataGridViewTextBoxColumn.HeaderText = "שם בניין";
            this.buildingNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.buildingNameDataGridViewTextBoxColumn.Name = "buildingNameDataGridViewTextBoxColumn";
            this.buildingNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // campusIDDataGridViewTextBoxColumn1
            // 
            this.campusIDDataGridViewTextBoxColumn1.DataPropertyName = "CampusID";
            this.campusIDDataGridViewTextBoxColumn1.HeaderText = "מזהה קמפוס";
            this.campusIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.campusIDDataGridViewTextBoxColumn1.Name = "campusIDDataGridViewTextBoxColumn1";
            this.campusIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.campusIDDataGridViewTextBoxColumn1.Width = 113;
            // 
            // dataGridCampus
            // 
            this.dataGridCampus.AllowUserToAddRows = false;
            this.dataGridCampus.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridCampus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCampus.AutoGenerateColumns = false;
            this.dataGridCampus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCampus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCampus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.campusIDDataGridViewTextBoxColumn,
            this.campusNameDataGridViewTextBoxColumn,
            this.deleteButton});
            this.dataGridCampus.DataSource = this.campusBindingSource;
            this.dataGridCampus.Location = new System.Drawing.Point(407, 5);
            this.dataGridCampus.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridCampus.MultiSelect = false;
            this.dataGridCampus.Name = "dataGridCampus";
            this.dataGridCampus.RowHeadersWidth = 51;
            this.dataGridCampus.RowTemplate.Height = 24;
            this.dataGridCampus.Size = new System.Drawing.Size(369, 147);
            this.dataGridCampus.TabIndex = 0;
            this.dataGridCampus.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCampus_RowEnter);
            this.dataGridCampus.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCampus_RowValidated);
            this.dataGridCampus.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridCampus_UserDeletedRow);
            // 
            // campusIDDataGridViewTextBoxColumn
            // 
            this.campusIDDataGridViewTextBoxColumn.DataPropertyName = "campusID";
            this.campusIDDataGridViewTextBoxColumn.HeaderText = "מזהה קמפוס";
            this.campusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusIDDataGridViewTextBoxColumn.Name = "campusIDDataGridViewTextBoxColumn";
            this.campusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.campusIDDataGridViewTextBoxColumn.Width = 113;
            // 
            // campusNameDataGridViewTextBoxColumn
            // 
            this.campusNameDataGridViewTextBoxColumn.DataPropertyName = "campusName";
            this.campusNameDataGridViewTextBoxColumn.HeaderText = "שם קמפוס";
            this.campusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.campusNameDataGridViewTextBoxColumn.Name = "campusNameDataGridViewTextBoxColumn";
            this.campusNameDataGridViewTextBoxColumn.Width = 99;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "מחק";
            this.deleteButton.MinimumWidth = 6;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Width = 44;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CampusPage);
            this.tabControl1.Controls.Add(this.RoomsPage);
            this.tabControl1.Controls.Add(this.FeaturesPage);
            this.tabControl1.Controls.Add(this.SemestersPage);
            this.tabControl1.Controls.Add(this.FacultyPage);
            this.tabControl1.Controls.Add(this.DegreeClassPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(9, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 526);
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
            // DBMaintain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 576);
            this.Controls.Add(this.BackToMenuBT);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DBMaintain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "אילוצון - תחזוקת טבלאות";
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
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyHoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfStudentsNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDegGrid)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuilding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCampus)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebrewYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage FeaturesPage;
        private System.Windows.Forms.Button removeFeatBT;
        private System.Windows.Forms.Label featureLabel;
        private System.Windows.Forms.Button addFeatureBT;
        private System.Windows.Forms.DataGridView features_gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn featuresIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qualifierReqDataGridViewCheckBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox roomsCampusCB;
        private System.Windows.Forms.TabPage CampusPage;
        private System.Windows.Forms.Button newCampusBT;
        private System.Windows.Forms.DataGridView dataGridBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridCampus;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView facultyGrid;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private grilDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.DataGridView degreeGrid;
        private System.Windows.Forms.BindingSource degreeBindingSource;
        private grilDataSetTableAdapters.DegreeTableAdapter degreeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacultyName;
        private System.Windows.Forms.Button deleteFacultyBT;
        private System.Windows.Forms.Button addFacultyBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.ComboBox classFacCB;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn qualifierReqDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeaturesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}