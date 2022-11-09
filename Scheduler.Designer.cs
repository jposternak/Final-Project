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
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBlockDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsByCampusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockItraTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExecBindingSource)).BeginInit();
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
            this.luz.Dock = System.Windows.Forms.DockStyle.Left;
            this.luz.Location = new System.Drawing.Point(0, 0);
            this.luz.Name = "luz";
            this.luz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeColumn;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.luz.Series.Add(series1);
            this.luz.Size = new System.Drawing.Size(1013, 748);
            this.luz.TabIndex = 0;
            this.luz.Text = "chart1";
            this.luz.Click += new System.EventHandler(this.luz_Click);
            this.luz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luz_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.luz);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 748);
            this.panel1.TabIndex = 6;
            // 
            // treeRooms
            // 
            this.treeRooms.Location = new System.Drawing.Point(3, 57);
            this.treeRooms.Name = "treeRooms";
            this.treeRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeRooms.RightToLeftLayout = true;
            this.treeRooms.Size = new System.Drawing.Size(202, 373);
            this.treeRooms.TabIndex = 4;
            this.treeRooms.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeRooms_NodeMouseDoubleClick);
            // 
            // campusCB
            // 
            this.campusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.campusCB.DataSource = this.campusBindingSource;
            this.campusCB.DisplayMember = "campusName";
            this.campusCB.FormattingEnabled = true;
            this.campusCB.Location = new System.Drawing.Point(78, 30);
            this.campusCB.Name = "campusCB";
            this.campusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.campusCB.Size = new System.Drawing.Size(202, 21);
            this.campusCB.TabIndex = 5;
            this.campusCB.SelectedIndexChanged += new System.EventHandler(this.campusCB_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.semesterCB);
            this.flowLayoutPanel1.Controls.Add(this.campusCB);
            this.flowLayoutPanel1.Controls.Add(this.treeRooms);
            this.flowLayoutPanel1.Controls.Add(this.blockItraTable);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(941, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 748);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // semesterCB
            // 
            this.semesterCB.DataSource = this.semesterBindingSource;
            this.semesterCB.DisplayMember = "SemesterFullName";
            this.semesterCB.Dock = System.Windows.Forms.DockStyle.Right;
            this.semesterCB.FormattingEnabled = true;
            this.semesterCB.Location = new System.Drawing.Point(78, 3);
            this.semesterCB.Name = "semesterCB";
            this.semesterCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.semesterCB.Size = new System.Drawing.Size(202, 21);
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
            this.blockItraTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.blockItraTable.Location = new System.Drawing.Point(3, 436);
            this.blockItraTable.Name = "blockItraTable";
            this.blockItraTable.ReadOnly = true;
            this.blockItraTable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blockItraTable.Size = new System.Drawing.Size(277, 150);
            this.blockItraTable.TabIndex = 7;
            // 
            // degreeClassIDDataGridViewTextBoxColumn
            // 
            this.degreeClassIDDataGridViewTextBoxColumn.DataPropertyName = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.HeaderText = "DegreeClassID";
            this.degreeClassIDDataGridViewTextBoxColumn.Name = "degreeClassIDDataGridViewTextBoxColumn";
            this.degreeClassIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.degreeClassIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // mahzorDataGridViewTextBoxColumn
            // 
            this.mahzorDataGridViewTextBoxColumn.DataPropertyName = "mahzor";
            this.mahzorDataGridViewTextBoxColumn.HeaderText = "mahzor";
            this.mahzorDataGridViewTextBoxColumn.Name = "mahzorDataGridViewTextBoxColumn";
            this.mahzorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // degreeNameDataGridViewTextBoxColumn
            // 
            this.degreeNameDataGridViewTextBoxColumn.DataPropertyName = "DegreeName";
            this.degreeNameDataGridViewTextBoxColumn.HeaderText = "DegreeName";
            this.degreeNameDataGridViewTextBoxColumn.Name = "degreeNameDataGridViewTextBoxColumn";
            this.degreeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterIDDataGridViewTextBoxColumn
            // 
            this.semesterIDDataGridViewTextBoxColumn.DataPropertyName = "semesterID";
            this.semesterIDDataGridViewTextBoxColumn.HeaderText = "semesterID";
            this.semesterIDDataGridViewTextBoxColumn.Name = "semesterIDDataGridViewTextBoxColumn";
            this.semesterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tihnunDataGridViewTextBoxColumn
            // 
            this.tihnunDataGridViewTextBoxColumn.DataPropertyName = "tihnun";
            this.tihnunDataGridViewTextBoxColumn.HeaderText = "tihnun";
            this.tihnunDataGridViewTextBoxColumn.Name = "tihnunDataGridViewTextBoxColumn";
            this.tihnunDataGridViewTextBoxColumn.ReadOnly = true;
            this.tihnunDataGridViewTextBoxColumn.Visible = false;
            // 
            // bitzuaDataGridViewTextBoxColumn
            // 
            this.bitzuaDataGridViewTextBoxColumn.DataPropertyName = "bitzua";
            this.bitzuaDataGridViewTextBoxColumn.HeaderText = "bitzua";
            this.bitzuaDataGridViewTextBoxColumn.Name = "bitzuaDataGridViewTextBoxColumn";
            this.bitzuaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bitzuaDataGridViewTextBoxColumn.Visible = false;
            // 
            // itraDataGridViewTextBoxColumn
            // 
            this.itraDataGridViewTextBoxColumn.DataPropertyName = "itra";
            this.itraDataGridViewTextBoxColumn.HeaderText = "itra";
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
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 748);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.semesterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockItraTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExecBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeRooms;
        private System.Windows.Forms.ComboBox campusCB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox semesterCB;
        private System.Windows.Forms.BindingSource semesterBindingSource;
        private grilDataSetTableAdapters.SemesterTableAdapter semesterTableAdapter;
        private System.Windows.Forms.DataGridView blockItraTable;
        private System.Windows.Forms.BindingSource degreeClassPlanExecBindingSource;
        private grilDataViewsSetTableAdapters.DegreeClassPlanExecTableAdapter degreeClassPlanExecTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeClassIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorSemesterYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahzorSemesterTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degreeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tihnunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitzuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itraDataGridViewTextBoxColumn;
    }
}