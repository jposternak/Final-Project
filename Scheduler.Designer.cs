namespace Final_Project
{
    partial class Scheduler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grilDataViewsSet = new Final_Project.grilDataViewsSet();
            this.scheduleBlockDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBlockDetailsTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.ScheduleBlockDetailsTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsByCampusTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.BuildingsByCampusTableAdapter();
            this.roomsByCampusTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.RoomsByCampusTableAdapter();
            this.campusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grilDataSet = new Final_Project.grilDataSet();
            this.campusTableAdapter = new Final_Project.grilDataSetTableAdapters.campusTableAdapter();
            this.buildingsByCampusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.treeRooms = new System.Windows.Forms.TreeView();
            this.campusCB = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.semesterCB = new System.Windows.Forms.ComboBox();
            this.semesterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blockItraTable = new System.Windows.Forms.DataGridView();
            this.degreeClassIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahzorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.degreeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tihnunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitzuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degreeClassPlanExecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.semesterTableAdapter = new Final_Project.grilDataSetTableAdapters.SemesterTableAdapter();
            this.degreeClassPlanExecTableAdapter = new Final_Project.grilDataViewsSetTableAdapters.DegreeClassPlanExecTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBlockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsByCampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockItraTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExecBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grilDataViewsSet
            // 
            this.grilDataViewsSet.DataSetName = "grilDataViewsSet";
            this.grilDataViewsSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBlockDetailsBindingSource
            // 
            this.scheduleBlockDetailsBindingSource.DataMember = "ScheduleBlockDetails";
            this.scheduleBlockDetailsBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // scheduleBlockDetailsTableAdapter
            // 
            this.scheduleBlockDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "RoomsByCampus";
            this.roomsBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // buildingsByCampusTableAdapter
            // 
            this.buildingsByCampusTableAdapter.ClearBeforeFill = true;
            // 
            // roomsByCampusTableAdapter
            // 
            this.roomsByCampusTableAdapter.ClearBeforeFill = true;
            // 
            // campusBindingSource
            // 
            this.campusBindingSource.DataMember = "campus";
            this.campusBindingSource.DataSource = this.grilDataSet;
            // 
            // grilDataSet
            // 
            this.grilDataSet.DataSetName = "grilDataSet";
            this.grilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // campusTableAdapter
            // 
            this.campusTableAdapter.ClearBeforeFill = true;
            // 
            // buildingsByCampusBindingSource
            // 
            this.buildingsByCampusBindingSource.DataMember = "BuildingsByCampus";
            this.buildingsByCampusBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // luz
            // 
            chartArea1.Name = "ChartArea1";
            this.luz.ChartAreas.Add(chartArea1);
            this.luz.Location = new System.Drawing.Point(13, 13);
            this.luz.Margin = new System.Windows.Forms.Padding(4);
            this.luz.Name = "luz";
            this.luz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.luz.Series.Add(series1);
            this.luz.Size = new System.Drawing.Size(1166, 860);
            this.luz.TabIndex = 0;
            this.luz.Text = "chart1";
            this.luz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luz_MouseClick);
            // 
            // treeRooms
            // 
            this.treeRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRooms.Location = new System.Drawing.Point(4, 44);
            this.treeRooms.Margin = new System.Windows.Forms.Padding(4);
            this.treeRooms.Name = "treeRooms";
            this.treeRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeRooms.RightToLeftLayout = true;
            this.treeRooms.Size = new System.Drawing.Size(376, 582);
            this.treeRooms.TabIndex = 4;
            this.treeRooms.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeRooms_NodeMouseDoubleClick);
            // 
            // campusCB
            // 
            this.campusCB.DataSource = this.campusBindingSource;
            this.campusCB.DisplayMember = "campusName";
            this.campusCB.FormattingEnabled = true;
            this.campusCB.Location = new System.Drawing.Point(31, 4);
            this.campusCB.Margin = new System.Windows.Forms.Padding(4);
            this.campusCB.Name = "campusCB";
            this.campusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.campusCB.Size = new System.Drawing.Size(252, 24);
            this.campusCB.TabIndex = 5;
            this.campusCB.SelectedIndexChanged += new System.EventHandler(this.campusCB_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1593, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 1112);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // semesterCB
            // 
            this.semesterCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semesterCB.DataSource = this.semesterBindingSource;
            this.semesterCB.DisplayMember = "SemesterFullName";
            this.semesterCB.FormattingEnabled = true;
            this.semesterCB.Location = new System.Drawing.Point(17, 4);
            this.semesterCB.Margin = new System.Windows.Forms.Padding(4);
            this.semesterCB.Name = "semesterCB";
            this.semesterCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semesterCB.Size = new System.Drawing.Size(252, 24);
            this.semesterCB.TabIndex = 6;
            this.semesterCB.SelectedIndexChanged += new System.EventHandler(this.semesterCB_SelectedIndexChanged);
            // 
            // semesterBindingSource
            // 
            this.semesterBindingSource.DataMember = "Semester";
            this.semesterBindingSource.DataSource = this.grilDataSet;
            // 
            // blockItraTable
            // 
            this.blockItraTable.AllowUserToAddRows = false;
            this.blockItraTable.AllowUserToDeleteRows = false;
            this.blockItraTable.AutoGenerateColumns = false;
            this.blockItraTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockItraTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.degreeClassIDDataGridViewTextBoxColumn,
            this.mahzorDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.degreeNameDataGridViewTextBoxColumn,
            this.semesterIDDataGridViewTextBoxColumn,
            this.tihnunDataGridViewTextBoxColumn,
            this.bitzuaDataGridViewTextBoxColumn,
            this.itraDataGridViewTextBoxColumn});
            this.blockItraTable.DataSource = this.degreeClassPlanExecBindingSource;
            this.blockItraTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockItraTable.Location = new System.Drawing.Point(4, 67);
            this.blockItraTable.Margin = new System.Windows.Forms.Padding(4);
            this.blockItraTable.MultiSelect = false;
            this.blockItraTable.Name = "blockItraTable";
            this.blockItraTable.ReadOnly = true;
            this.blockItraTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blockItraTable.RowHeadersWidth = 51;
            this.blockItraTable.ShowCellErrors = false;
            this.blockItraTable.ShowCellToolTips = false;
            this.blockItraTable.ShowEditingIcon = false;
            this.blockItraTable.ShowRowErrors = false;
            this.blockItraTable.Size = new System.Drawing.Size(379, 559);
            this.blockItraTable.TabIndex = 7;
            this.blockItraTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blockItraTable_CellDoubleClick);
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
            // mahzorDataGridViewTextBoxColumn
            // 
            this.mahzorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mahzorDataGridViewTextBoxColumn.DataPropertyName = "mahzor";
            this.mahzorDataGridViewTextBoxColumn.FillWeight = 77.62803F;
            this.mahzorDataGridViewTextBoxColumn.HeaderText = "מחזור";
            this.mahzorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mahzorDataGridViewTextBoxColumn.Name = "mahzorDataGridViewTextBoxColumn";
            this.mahzorDataGridViewTextBoxColumn.ReadOnly = true;
            this.mahzorDataGridViewTextBoxColumn.Visible = false;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // degreeNameDataGridViewTextBoxColumn
            // 
            this.degreeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.degreeNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeName";
            this.degreeNameDataGridViewTextBoxColumn.FillWeight = 93.79731F;
            this.degreeNameDataGridViewTextBoxColumn.HeaderText = "מגמה";
            this.degreeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.degreeNameDataGridViewTextBoxColumn.Name = "degreeNameDataGridViewTextBoxColumn";
            this.degreeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterIDDataGridViewTextBoxColumn
            // 
            this.semesterIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.semesterIDDataGridViewTextBoxColumn.DataPropertyName = "semesterID";
            this.semesterIDDataGridViewTextBoxColumn.FillWeight = 109.4708F;
            this.semesterIDDataGridViewTextBoxColumn.HeaderText = "מזהה סמסטר";
            this.semesterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterIDDataGridViewTextBoxColumn.Name = "semesterIDDataGridViewTextBoxColumn";
            this.semesterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tihnunDataGridViewTextBoxColumn
            // 
            this.tihnunDataGridViewTextBoxColumn.DataPropertyName = "tihnun";
            this.tihnunDataGridViewTextBoxColumn.HeaderText = "tihnun";
            this.tihnunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tihnunDataGridViewTextBoxColumn.Name = "tihnunDataGridViewTextBoxColumn";
            this.tihnunDataGridViewTextBoxColumn.ReadOnly = true;
            this.tihnunDataGridViewTextBoxColumn.Visible = false;
            this.tihnunDataGridViewTextBoxColumn.Width = 125;
            // 
            // bitzuaDataGridViewTextBoxColumn
            // 
            this.bitzuaDataGridViewTextBoxColumn.DataPropertyName = "bitzua";
            this.bitzuaDataGridViewTextBoxColumn.HeaderText = "bitzua";
            this.bitzuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bitzuaDataGridViewTextBoxColumn.Name = "bitzuaDataGridViewTextBoxColumn";
            this.bitzuaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bitzuaDataGridViewTextBoxColumn.Visible = false;
            this.bitzuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // itraDataGridViewTextBoxColumn
            // 
            this.itraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itraDataGridViewTextBoxColumn.DataPropertyName = "itra";
            this.itraDataGridViewTextBoxColumn.FillWeight = 119.1039F;
            this.itraDataGridViewTextBoxColumn.HeaderText = "יתרה";
            this.itraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itraDataGridViewTextBoxColumn.Name = "itraDataGridViewTextBoxColumn";
            this.itraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // degreeClassPlanExecBindingSource
            // 
            this.degreeClassPlanExecBindingSource.DataMember = "DegreeClassPlanExec";
            this.degreeClassPlanExecBindingSource.DataSource = this.grilDataViewsSet;
            // 
            // semesterTableAdapter
            // 
            this.semesterTableAdapter.ClearBeforeFill = true;
            // 
            // degreeClassPlanExecTableAdapter
            // 
            this.degreeClassPlanExecTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(1177, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 819);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "בחירת חדר";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.treeRooms, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 630);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.campusCB, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(378, 34);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(290, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "בחירת קמפוס:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "בחירת מחזור";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.blockItraTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(387, 630);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.semesterCB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(381, 57);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "בחירת סמסטר:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1593, 1112);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.luz);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Scheduler";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.Scheduler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBlockDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsByCampusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockItraTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExecBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private grilDataViewsSet grilDataViewsSet;
        private System.Windows.Forms.BindingSource scheduleBlockDetailsBindingSource;
        private grilDataViewsSetTableAdapters.ScheduleBlockDetailsTableAdapter scheduleBlockDetailsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private grilDataViewsSetTableAdapters.BuildingsByCampusTableAdapter buildingsByCampusTableAdapter;
        private grilDataViewsSetTableAdapters.RoomsByCampusTableAdapter roomsByCampusTableAdapter;
        private grilDataSet grilDataSet;
        private System.Windows.Forms.BindingSource campusBindingSource;
        private grilDataSetTableAdapters.campusTableAdapter campusTableAdapter;
        private System.Windows.Forms.BindingSource buildingsByCampusBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart luz;
        private System.Windows.Forms.TreeView treeRooms;
        private System.Windows.Forms.ComboBox campusCB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox semesterCB;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private grilDataSetTableAdapters.SemesterTableAdapter semesterTableAdapter;
        private System.Windows.Forms.DataGridView blockItraTable;
        private System.Windows.Forms.BindingSource degreeClassPlanExecBindingSource;
        private grilDataViewsSetTableAdapters.DegreeClassPlanExecTableAdapter degreeClassPlanExecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorSemesterYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorSemesterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeClassIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tihnunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitzuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itraDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}