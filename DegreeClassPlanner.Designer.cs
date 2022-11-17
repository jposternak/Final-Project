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
            this.luz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.roomCB = new System.Windows.Forms.ComboBox();
            this.grilDataSet = new Final_Project.grilDataSet();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomTableAdapter = new Final_Project.grilDataSetTableAdapters.RoomTableAdapter();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(225, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1045, 100);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "פקולטה";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "מגמה";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "מחזור";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "שנת לימודים";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "סמסטר";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semesterLB
            // 
            this.semesterLB.AutoSize = true;
            this.semesterLB.Location = new System.Drawing.Point(154, 30);
            this.semesterLB.Name = "semesterLB";
            this.semesterLB.Size = new System.Drawing.Size(44, 16);
            this.semesterLB.TabIndex = 0;
            this.semesterLB.Text = "label1";
            this.semesterLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shanaLB
            // 
            this.shanaLB.AutoSize = true;
            this.shanaLB.Location = new System.Drawing.Point(353, 30);
            this.shanaLB.Name = "shanaLB";
            this.shanaLB.Size = new System.Drawing.Size(44, 16);
            this.shanaLB.TabIndex = 0;
            this.shanaLB.Text = "label1";
            this.shanaLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mahzorLB
            // 
            this.mahzorLB.AutoSize = true;
            this.mahzorLB.Location = new System.Drawing.Point(552, 30);
            this.mahzorLB.Name = "mahzorLB";
            this.mahzorLB.Size = new System.Drawing.Size(44, 16);
            this.mahzorLB.TabIndex = 0;
            this.mahzorLB.Text = "label1";
            this.mahzorLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // megamaLB
            // 
            this.megamaLB.AutoSize = true;
            this.megamaLB.Location = new System.Drawing.Point(751, 30);
            this.megamaLB.Name = "megamaLB";
            this.megamaLB.Size = new System.Drawing.Size(44, 16);
            this.megamaLB.TabIndex = 0;
            this.megamaLB.Text = "label1";
            this.megamaLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // facultyLB
            // 
            this.facultyLB.AutoSize = true;
            this.facultyLB.Location = new System.Drawing.Point(950, 30);
            this.facultyLB.Name = "facultyLB";
            this.facultyLB.Size = new System.Drawing.Size(44, 16);
            this.facultyLB.TabIndex = 0;
            this.facultyLB.Text = "label1";
            this.facultyLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 125);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.add);
            this.splitContainer1.Panel1.Controls.Add(this.TimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.dayCB);
            this.splitContainer1.Panel1.Controls.Add(this.roomCB);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.luz);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1490, 872);
            this.splitContainer1.SplitterDistance = 496;
            this.splitContainer1.TabIndex = 1;
            // 
            // luz
            // 
            chartArea1.Name = "ChartArea1";
            this.luz.ChartAreas.Add(chartArea1);
            this.luz.Location = new System.Drawing.Point(21, 28);
            this.luz.Name = "luz";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.luz.Series.Add(series1);
            this.luz.Size = new System.Drawing.Size(948, 819);
            this.luz.TabIndex = 0;
            this.luz.Text = "chart1";
            // 
            // roomCB
            // 
            this.roomCB.DataSource = this.roomBindingSource;
            this.roomCB.DisplayMember = "RoomName";
            this.roomCB.FormattingEnabled = true;
            this.roomCB.Location = new System.Drawing.Point(140, 158);
            this.roomCB.Name = "roomCB";
            this.roomCB.Size = new System.Drawing.Size(260, 24);
            this.roomCB.TabIndex = 0;
            // 
            // grilDataSet
            // 
            this.grilDataSet.DataSetName = "grilDataSet";
            this.grilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.grilDataSet;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
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
            this.dayCB.Location = new System.Drawing.Point(140, 213);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(260, 24);
            this.dayCB.TabIndex = 1;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(175, 286);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.RightToLeftLayout = true;
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(200, 22);
            this.TimePicker.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(203, 348);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(172, 137);
            this.add.TabIndex = 3;
            this.add.Text = "הוסף";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // DegreeClassPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 984);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DegreeClassPlanner";
            this.Text = "DegreeClassPlanner";
            this.Load += new System.EventHandler(this.DegreeClassPlanner_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox roomCB;
        private grilDataSet grilDataSet;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private grilDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.ComboBox dayCB;
    }
}