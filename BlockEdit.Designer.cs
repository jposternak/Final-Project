namespace Final_Project
{
    partial class BlockEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomIDTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.roomNameTB = new System.Windows.Forms.TextBox();
            this.campusTB = new System.Windows.Forms.TextBox();
            this.buildingTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.roomFloorTB = new System.Windows.Forms.TextBox();
            this.scheduleBlockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grilDataViewsSet = new Final_Project.grilDataViewsSet();
            this.scheduleBlockDetailsTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.ScheduleBlockDetailsTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomFeaturesGV = new System.Windows.Forms.DataGridView();
            this.featureNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuildingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeatureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeaturesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allRoomsTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.AllRoomsTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dayOfWeek = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.inUse = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.editBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.facultyTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.megamaTB = new System.Windows.Forms.TextBox();
            this.itraTB = new System.Windows.Forms.TextBox();
            this.shibutzTB = new System.Windows.Forms.TextBox();
            this.mahzorTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBlockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomFeaturesGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allRoomsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(37, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(283, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי החדר";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.7037F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.2963F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.roomIDTB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roomNameTB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.campusTB, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buildingTB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.roomFloorTB, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "שדה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "מזהה חדר";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "שם חדר";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomIDTB
            // 
            this.roomIDTB.Enabled = false;
            this.roomIDTB.Location = new System.Drawing.Point(3, 30);
            this.roomIDTB.Name = "roomIDTB";
            this.roomIDTB.Size = new System.Drawing.Size(172, 22);
            this.roomIDTB.TabIndex = 7;
            this.roomIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "ערך";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNameTB
            // 
            this.roomNameTB.Enabled = false;
            this.roomNameTB.Location = new System.Drawing.Point(3, 57);
            this.roomNameTB.Name = "roomNameTB";
            this.roomNameTB.Size = new System.Drawing.Size(172, 22);
            this.roomNameTB.TabIndex = 7;
            this.roomNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // campusTB
            // 
            this.campusTB.Enabled = false;
            this.campusTB.Location = new System.Drawing.Point(3, 138);
            this.campusTB.Name = "campusTB";
            this.campusTB.Size = new System.Drawing.Size(172, 22);
            this.campusTB.TabIndex = 7;
            this.campusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buildingTB
            // 
            this.buildingTB.Enabled = false;
            this.buildingTB.Location = new System.Drawing.Point(3, 111);
            this.buildingTB.Name = "buildingTB";
            this.buildingTB.Size = new System.Drawing.Size(172, 22);
            this.buildingTB.TabIndex = 7;
            this.buildingTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "קמפוס";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "בניין";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "קומה";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomFloorTB
            // 
            this.roomFloorTB.Enabled = false;
            this.roomFloorTB.Location = new System.Drawing.Point(3, 84);
            this.roomFloorTB.Name = "roomFloorTB";
            this.roomFloorTB.Size = new System.Drawing.Size(172, 22);
            this.roomFloorTB.TabIndex = 7;
            this.roomFloorTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scheduleBlockDetailsBindingSource
            // 
            this.scheduleBlockDetailsBindingSource.DataMember = "ScheduleBlockDetails";
            this.scheduleBlockDetailsBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // grilDataViewsSet
            // 
            this.grilDataViewsSet.DataSetName = "grilDataViewsSet";
            this.grilDataViewsSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBlockDetailsTableAdapter
            // 
            this.scheduleBlockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomFeaturesGV);
            this.groupBox2.Location = new System.Drawing.Point(37, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(283, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "מאפייני החדר";
            // 
            // roomFeaturesGV
            // 
            this.roomFeaturesGV.AllowUserToAddRows = false;
            this.roomFeaturesGV.AllowUserToDeleteRows = false;
            this.roomFeaturesGV.AutoGenerateColumns = false;
            this.roomFeaturesGV.CausesValidation = false;
            this.roomFeaturesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomFeaturesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.featureNameDataGridViewTextBoxColumn,
            this.qualifierDataGridViewTextBoxColumn,
            this.RoomName,
            this.Floor,
            this.BuildingName,
            this.FeatureName,
            this.Qualifier,
            this.CampusName,
            this.FeaturesID});
            this.roomFeaturesGV.DataSource = this.allRoomsBindingSource;
            this.roomFeaturesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomFeaturesGV.Location = new System.Drawing.Point(3, 18);
            this.roomFeaturesGV.Name = "roomFeaturesGV";
            this.roomFeaturesGV.ReadOnly = true;
            this.roomFeaturesGV.RowHeadersWidth = 51;
            this.roomFeaturesGV.RowTemplate.Height = 24;
            this.roomFeaturesGV.ShowCellErrors = false;
            this.roomFeaturesGV.ShowCellToolTips = false;
            this.roomFeaturesGV.ShowEditingIcon = false;
            this.roomFeaturesGV.ShowRowErrors = false;
            this.roomFeaturesGV.Size = new System.Drawing.Size(277, 292);
            this.roomFeaturesGV.TabIndex = 0;
            // 
            // featureNameDataGridViewTextBoxColumn
            // 
            this.featureNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.featureNameDataGridViewTextBoxColumn.DataPropertyName = "FeatureName";
            this.featureNameDataGridViewTextBoxColumn.HeaderText = "מאפיין";
            this.featureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.featureNameDataGridViewTextBoxColumn.Name = "featureNameDataGridViewTextBoxColumn";
            this.featureNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualifierDataGridViewTextBoxColumn
            // 
            this.qualifierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qualifierDataGridViewTextBoxColumn.DataPropertyName = "Qualifier";
            this.qualifierDataGridViewTextBoxColumn.HeaderText = "ערך";
            this.qualifierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qualifierDataGridViewTextBoxColumn.Name = "qualifierDataGridViewTextBoxColumn";
            this.qualifierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "RoomName";
            this.RoomName.MinimumWidth = 6;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            this.RoomName.Visible = false;
            this.RoomName.Width = 125;
            // 
            // Floor
            // 
            this.Floor.DataPropertyName = "Floor";
            this.Floor.HeaderText = "Floor";
            this.Floor.MinimumWidth = 6;
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Visible = false;
            this.Floor.Width = 125;
            // 
            // BuildingName
            // 
            this.BuildingName.DataPropertyName = "BuildingName";
            this.BuildingName.HeaderText = "BuildingName";
            this.BuildingName.MinimumWidth = 6;
            this.BuildingName.Name = "BuildingName";
            this.BuildingName.ReadOnly = true;
            this.BuildingName.Visible = false;
            this.BuildingName.Width = 125;
            // 
            // FeatureName
            // 
            this.FeatureName.DataPropertyName = "FeatureName";
            this.FeatureName.HeaderText = "FeatureName";
            this.FeatureName.MinimumWidth = 6;
            this.FeatureName.Name = "FeatureName";
            this.FeatureName.ReadOnly = true;
            this.FeatureName.Visible = false;
            this.FeatureName.Width = 125;
            // 
            // Qualifier
            // 
            this.Qualifier.DataPropertyName = "Qualifier";
            this.Qualifier.HeaderText = "Qualifier";
            this.Qualifier.MinimumWidth = 6;
            this.Qualifier.Name = "Qualifier";
            this.Qualifier.ReadOnly = true;
            this.Qualifier.Visible = false;
            this.Qualifier.Width = 125;
            // 
            // CampusName
            // 
            this.CampusName.DataPropertyName = "CampusName";
            this.CampusName.HeaderText = "CampusName";
            this.CampusName.MinimumWidth = 6;
            this.CampusName.Name = "CampusName";
            this.CampusName.ReadOnly = true;
            this.CampusName.Visible = false;
            this.CampusName.Width = 125;
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
            // allRoomsBindingSource
            // 
            this.allRoomsBindingSource.DataMember = "AllRooms";
            this.allRoomsBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // allRoomsTableAdapter
            // 
            this.allRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Location = new System.Drawing.Point(344, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(662, 107);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "פרטי הבלוק";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dayOfWeek, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.time, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.semester, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.inUse, 3, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(524, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "יום בשבוע";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(384, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "שעה";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(216, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "סמסטר";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "האם קיים שיבוץ לקורס";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dayOfWeek.AutoSize = true;
            this.dayOfWeek.Location = new System.Drawing.Point(528, 30);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(66, 16);
            this.dayOfWeek.TabIndex = 0;
            this.dayOfWeek.Text = "יום בשבוע";
            this.dayOfWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(368, 30);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(66, 16);
            this.time.TabIndex = 0;
            this.time.Text = "יום בשבוע";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester
            // 
            this.semester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(208, 30);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(66, 16);
            this.semester.TabIndex = 0;
            this.semester.Text = "יום בשבוע";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inUse
            // 
            this.inUse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inUse.AutoSize = true;
            this.inUse.Location = new System.Drawing.Point(48, 30);
            this.inUse.Name = "inUse";
            this.inUse.Size = new System.Drawing.Size(66, 16);
            this.inUse.TabIndex = 0;
            this.inUse.Text = "יום בשבוע";
            this.inUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.editBT);
            this.groupBox4.Controls.Add(this.saveBT);
            this.groupBox4.Controls.Add(this.deleteBT);
            this.groupBox4.Controls.Add(this.tableLayoutPanel3);
            this.groupBox4.Location = new System.Drawing.Point(344, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(656, 193);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "פרטי המחזור ששובץ";
            // 
            // editBT
            // 
            this.editBT.Location = new System.Drawing.Point(18, 14);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(75, 55);
            this.editBT.TabIndex = 1;
            this.editBT.Text = "ערוך";
            this.editBT.UseVisualStyleBackColor = true;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(18, 77);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(75, 55);
            this.saveBT.TabIndex = 1;
            this.saveBT.Text = "שמור שינויים";
            this.saveBT.UseVisualStyleBackColor = true;
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(18, 156);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(75, 23);
            this.deleteBT.TabIndex = 1;
            this.deleteBT.Text = "מחק בלוק";
            this.deleteBT.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27322F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.72678F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.facultyTB, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.megamaTB, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.itraTB, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.shibutzTB, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.mahzorTB, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(358, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 166);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "שדה";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "פקולטה";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(201, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "מגמת לימודים";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facultyTB
            // 
            this.facultyTB.Enabled = false;
            this.facultyTB.Location = new System.Drawing.Point(3, 30);
            this.facultyTB.Name = "facultyTB";
            this.facultyTB.Size = new System.Drawing.Size(140, 22);
            this.facultyTB.TabIndex = 7;
            this.facultyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(113, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "ערך";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // megamaTB
            // 
            this.megamaTB.Enabled = false;
            this.megamaTB.Location = new System.Drawing.Point(3, 57);
            this.megamaTB.Name = "megamaTB";
            this.megamaTB.Size = new System.Drawing.Size(140, 22);
            this.megamaTB.TabIndex = 7;
            this.megamaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itraTB
            // 
            this.itraTB.Enabled = false;
            this.itraTB.Location = new System.Drawing.Point(3, 138);
            this.itraTB.Name = "itraTB";
            this.itraTB.Size = new System.Drawing.Size(140, 22);
            this.itraTB.TabIndex = 7;
            this.itraTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shibutzTB
            // 
            this.shibutzTB.Enabled = false;
            this.shibutzTB.Location = new System.Drawing.Point(3, 111);
            this.shibutzTB.Name = "shibutzTB";
            this.shibutzTB.Size = new System.Drawing.Size(140, 22);
            this.shibutzTB.TabIndex = 7;
            this.shibutzTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mahzorTB
            // 
            this.mahzorTB.Enabled = false;
            this.mahzorTB.Location = new System.Drawing.Point(3, 84);
            this.mahzorTB.Name = "mahzorTB";
            this.mahzorTB.Size = new System.Drawing.Size(140, 22);
            this.mahzorTB.TabIndex = 7;
            this.mahzorTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(160, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "סך שעות שטרם שובצו";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(178, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "סך שעות משובצות";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "מחזור";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Items.AddRange(new object[] {
            "בקרוב..."});
            this.listBox.Location = new System.Drawing.Point(344, 400);
            this.listBox.Name = "listBox";
            this.listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox.Size = new System.Drawing.Size(656, 148);
            this.listBox.TabIndex = 1;
            // 
            // BlockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 651);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlockEdit";
            this.Text = "BlockEdit";
            this.Load += new System.EventHandler(this.BlockEdit_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBlockDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomFeaturesGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allRoomsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomIDTB;
        private System.Windows.Forms.TextBox roomNameTB;
        private System.Windows.Forms.TextBox buildingTB;
        private System.Windows.Forms.TextBox campusTB;
        private grilDataViewsSet grilDataViewsSet;
        private System.Windows.Forms.BindingSource scheduleBlockDetailsBindingSource;
        private grilDataViewsSetTableAdapters.ScheduleBlockDetailsTableAdapter scheduleBlockDetailsTableAdapter;
        private System.Windows.Forms.TextBox roomFloorTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView roomFeaturesGV;
        private System.Windows.Forms.BindingSource allRoomsBindingSource;
        private grilDataViewsSetTableAdapters.AllRoomsTableAdapter allRoomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn featureNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuildingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeatureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeaturesID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dayOfWeek;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.Label inUse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox facultyTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox megamaTB;
        private System.Windows.Forms.TextBox shibutzTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox mahzorTB;
        private System.Windows.Forms.TextBox itraTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.ListBox listBox;
    }
}