namespace Final_Project
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.DBMaintBT = new System.Windows.Forms.Button();
            this.SchedulerBT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DBMaintBT
            // 
            this.DBMaintBT.AutoSize = true;
            this.DBMaintBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBMaintBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DBMaintBT.Image = global::Final_Project.Properties.Resources.icons8_database_administrator_50;
            this.DBMaintBT.Location = new System.Drawing.Point(715, 2);
            this.DBMaintBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBMaintBT.Name = "DBMaintBT";
            this.DBMaintBT.Size = new System.Drawing.Size(705, 107);
            this.DBMaintBT.TabIndex = 0;
            this.DBMaintBT.Text = "תחזק טבלאות מערכת";
            this.DBMaintBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DBMaintBT.UseVisualStyleBackColor = true;
            this.DBMaintBT.Click += new System.EventHandler(this.DBMaintBT_Click);
            // 
            // SchedulerBT
            // 
            this.SchedulerBT.AutoSize = true;
            this.SchedulerBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchedulerBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SchedulerBT.Image = global::Final_Project.Properties.Resources.icons8_schedule_50;
            this.SchedulerBT.Location = new System.Drawing.Point(4, 4);
            this.SchedulerBT.Margin = new System.Windows.Forms.Padding(4);
            this.SchedulerBT.Name = "SchedulerBT";
            this.SchedulerBT.Size = new System.Drawing.Size(704, 103);
            this.SchedulerBT.TabIndex = 1;
            this.SchedulerBT.Text = "פתח תכנון שבועי";
            this.SchedulerBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SchedulerBT.UseVisualStyleBackColor = true;
            this.SchedulerBT.Click += new System.EventHandler(this.SchedulerBT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SchedulerBT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DBMaintBT, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 659);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1423, 111);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Final_Project.Properties.Resources.ilutzon_COLO;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1429, 773);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final_Project.Properties.Resources.ilutzon_COLO;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.ilutzon;
            this.pictureBox1.InitialImage = global::Final_Project.Properties.Resources.ilutzon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1423, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1362, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "גרסה 1.0";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1429, 773);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "אילוצון - תפריט פעולות";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DBMaintBT;
        private System.Windows.Forms.Button SchedulerBT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}