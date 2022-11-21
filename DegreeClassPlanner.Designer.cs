namespace Final_Project
{
    partial class DegreeClassPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DegreeClassPlanner));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.semesterLB = new System.Windows.Forms.Label();
            this.shanaLB = new System.Windows.Forms.Label();
            this.mahzorLB = new System.Windows.Forms.Label();
            this.megamaLB = new System.Windows.Forms.Label();
            this.facultyLB = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeRooms = new System.Windows.Forms.TreeView();
            this.add = new System.Windows.Forms.Button();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grilDataSet = new Final_Project.grilDataSet();
            this.luz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roomTableAdapter = new Final_Project.grilDataSetTableAdapters.RoomTableAdapter();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tihnunLB = new System.Windows.Forms.Label();
            this.bitzuaLB = new System.Windows.Forms.Label();
            this.itraLB = new System.Windows.Forms.Label();
            this.roomNameLB = new System.Windows.Forms.Label();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.roomLB = new System.Windows.Forms.Label();
            this.grilDataViewsSet = new Final_Project.grilDataViewsSet();
            this.degreeClassPlanExec3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExec3BindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1118, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי המחזור - סמסטר";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.semesterLB, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.shanaLB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mahzorLB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.megamaLB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.facultyLB, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(894, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "פקולטה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(672, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "מגמה";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(450, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "מחזור";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(228, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "תחילת שנת לימודים";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "סמסטר התחלה";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semesterLB
            // 
            this.semesterLB.AutoSize = true;
            this.semesterLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semesterLB.Location = new System.Drawing.Point(2, 24);
            this.semesterLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.semesterLB.Name = "semesterLB";
            this.semesterLB.Size = new System.Drawing.Size(222, 25);
            this.semesterLB.TabIndex = 0;
            this.semesterLB.Text = "label1";
            this.semesterLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shanaLB
            // 
            this.shanaLB.AutoSize = true;
            this.shanaLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shanaLB.Location = new System.Drawing.Point(228, 24);
            this.shanaLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shanaLB.Name = "shanaLB";
            this.shanaLB.Size = new System.Drawing.Size(218, 25);
            this.shanaLB.TabIndex = 0;
            this.shanaLB.Text = "label1";
            this.shanaLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mahzorLB
            // 
            this.mahzorLB.AutoSize = true;
            this.mahzorLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mahzorLB.Location = new System.Drawing.Point(450, 24);
            this.mahzorLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mahzorLB.Name = "mahzorLB";
            this.mahzorLB.Size = new System.Drawing.Size(218, 25);
            this.mahzorLB.TabIndex = 0;
            this.mahzorLB.Text = "label1";
            this.mahzorLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // megamaLB
            // 
            this.megamaLB.AutoSize = true;
            this.megamaLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.megamaLB.Location = new System.Drawing.Point(672, 24);
            this.megamaLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.megamaLB.Name = "megamaLB";
            this.megamaLB.Size = new System.Drawing.Size(218, 25);
            this.megamaLB.TabIndex = 0;
            this.megamaLB.Text = "label1";
            this.megamaLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facultyLB
            // 
            this.facultyLB.AutoSize = true;
            this.facultyLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facultyLB.Location = new System.Drawing.Point(894, 24);
            this.facultyLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facultyLB.Name = "facultyLB";
            this.facultyLB.Size = new System.Drawing.Size(218, 25);
            this.facultyLB.TabIndex = 0;
            this.facultyLB.Text = "label1";
            this.facultyLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(11, 157);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.add);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.luz);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1118, 638);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.8F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.2F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.startPicker, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.roomNameLB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dayCB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.roomLB, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 272);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 74);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "שעת תחילה";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayCB
            // 
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.dayCB.Location = new System.Drawing.Point(2, 29);
            this.dayCB.Margin = new System.Windows.Forms.Padding(2);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(119, 21);
            this.dayCB.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeRooms);
            this.groupBox2.Location = new System.Drawing.Point(90, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 233);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "הוספת הקצאה חדשה";
            // 
            // treeRooms
            // 
            this.treeRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRooms.Location = new System.Drawing.Point(3, 16);
            this.treeRooms.Name = "treeRooms";
            this.treeRooms.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeRooms.RightToLeftLayout = true;
            this.treeRooms.Size = new System.Drawing.Size(250, 214);
            this.treeRooms.TabIndex = 5;
            this.treeRooms.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeRooms_NodeMouseClick);
            // 
            // add
            // 
            this.add.Image = global::Final_Project.Properties.Resources.icons8_insert_page_50;
            this.add.Location = new System.Drawing.Point(21, 265);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(63, 81);
            this.add.TabIndex = 3;
            this.add.Text = "הוסף";
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.grilDataSet;
            // 
            // grilDataSet
            // 
            this.grilDataSet.DataSetName = "grilDataSet";
            this.grilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // luz
            // 
            chartArea1.Name = "ChartArea1";
            this.luz.ChartAreas.Add(chartArea1);
            this.luz.Location = new System.Drawing.Point(16, 23);
            this.luz.Margin = new System.Windows.Forms.Padding(2);
            this.luz.Name = "luz";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.luz.Series.Add(series1);
            this.luz.Size = new System.Drawing.Size(711, 665);
            this.luz.TabIndex = 0;
            this.luz.Text = "chart1";
            this.luz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.luz_MouseClick);
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tihnunLB, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.bitzuaLB, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.itraLB, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(96, 391);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(241, 95);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(189, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "תכנון:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(187, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "ביצוע:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(192, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "יתרה:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tihnunLB
            // 
            this.tihnunLB.AutoSize = true;
            this.tihnunLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tihnunLB.Location = new System.Drawing.Point(99, 0);
            this.tihnunLB.Name = "tihnunLB";
            this.tihnunLB.Size = new System.Drawing.Size(19, 20);
            this.tihnunLB.TabIndex = 0;
            this.tihnunLB.Text = "0";
            this.tihnunLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bitzuaLB
            // 
            this.bitzuaLB.AutoSize = true;
            this.bitzuaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bitzuaLB.Location = new System.Drawing.Point(99, 31);
            this.bitzuaLB.Name = "bitzuaLB";
            this.bitzuaLB.Size = new System.Drawing.Size(19, 20);
            this.bitzuaLB.TabIndex = 0;
            this.bitzuaLB.Text = "0";
            this.bitzuaLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itraLB
            // 
            this.itraLB.AutoSize = true;
            this.itraLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.itraLB.Location = new System.Drawing.Point(99, 62);
            this.itraLB.Name = "itraLB";
            this.itraLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itraLB.Size = new System.Drawing.Size(19, 20);
            this.itraLB.TabIndex = 0;
            this.itraLB.Text = "0";
            this.itraLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNameLB
            // 
            this.roomNameLB.AutoSize = true;
            this.roomNameLB.Location = new System.Drawing.Point(185, 27);
            this.roomNameLB.Name = "roomNameLB";
            this.roomNameLB.Size = new System.Drawing.Size(62, 13);
            this.roomNameLB.TabIndex = 6;
            this.roomNameLB.Text = "יום בשבוע";
            this.roomNameLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startPicker
            // 
            this.startPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startPicker.CustomFormat = "HH:MM";
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startPicker.Location = new System.Drawing.Point(2, 56);
            this.startPicker.Margin = new System.Windows.Forms.Padding(2);
            this.startPicker.Name = "startPicker";
            this.startPicker.RightToLeftLayout = true;
            this.startPicker.ShowUpDown = true;
            this.startPicker.Size = new System.Drawing.Size(119, 20);
            this.startPicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "חדר";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomLB
            // 
            this.roomLB.AutoSize = true;
            this.roomLB.Location = new System.Drawing.Point(93, 0);
            this.roomLB.Name = "roomLB";
            this.roomLB.Size = new System.Drawing.Size(27, 13);
            this.roomLB.TabIndex = 6;
            this.roomLB.Text = "חדר";
            this.roomLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grilDataViewsSet
            // 
            this.grilDataViewsSet.DataSetName = "grilDataViewsSet";
            this.grilDataViewsSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // degreeClassPlanExec3BindingSource
            // 
            this.degreeClassPlanExec3BindingSource.DataMember = "DegreeClassPlanExec3";
            this.degreeClassPlanExec3BindingSource.DataSource = this.grilDataViewsSet;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackgroundImage = global::Final_Project.Properties.Resources.ilutzon_COLO;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45098F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.54902F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, -1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1125, 84);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final_Project.Properties.Resources.ilutzon_COLO;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.ilutzon;
            this.pictureBox1.Location = new System.Drawing.Point(819, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Guttman Hatzvi", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(2, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(813, 84);
            this.label19.TabIndex = 1;
            this.label19.Text = "מסך תכנון הקצאות למחזור לימודים";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DegreeClassPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 810);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DegreeClassPlanner";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "תכנון מחזור בסמסטר";
            this.Load += new System.EventHandler(this.DegreeClassPlanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataViewsSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeClassPlanExec3BindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label semesterLB;
        private System.Windows.Forms.Label shanaLB;
        private System.Windows.Forms.Label mahzorLB;
        private System.Windows.Forms.Label megamaLB;
        private System.Windows.Forms.Label facultyLB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart luz;
        private grilDataSet grilDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private grilDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeRooms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tihnunLB;
        private System.Windows.Forms.BindingSource degreeClassPlanExec3BindingSource;
        private grilDataViewsSet grilDataViewsSet;
        private System.Windows.Forms.Label bitzuaLB;
        private System.Windows.Forms.Label itraLB;
        private System.Windows.Forms.Label roomNameLB;
        private System.Windows.Forms.DateTimePicker startPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label roomLB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
    }
}