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
            this.DBMaintBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.DBMaintBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBMaintBT.Font = new System.Drawing.Font("Rubik Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DBMaintBT.Image = global::Final_Project.Properties.Resources.icons8_database_administrator_50;
            this.DBMaintBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DBMaintBT.Location = new System.Drawing.Point(536, 2);
            this.DBMaintBT.Margin = new System.Windows.Forms.Padding(2);
            this.DBMaintBT.Name = "DBMaintBT";
            this.DBMaintBT.Size = new System.Drawing.Size(530, 87);
            this.DBMaintBT.TabIndex = 0;
            this.DBMaintBT.Text = "ניהול המידע ותחזוק הטבלאות";
            this.DBMaintBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DBMaintBT.UseVisualStyleBackColor = true;
            this.DBMaintBT.Click += new System.EventHandler(this.DBMaintBT_Click);
            // 
            // SchedulerBT
            // 
            this.SchedulerBT.AutoSize = true;
            this.SchedulerBT.BackgroundImage = global::Final_Project.Properties.Resources.blue;
            this.SchedulerBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchedulerBT.Font = new System.Drawing.Font("Rubik Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SchedulerBT.Image = global::Final_Project.Properties.Resources.icons8_schedule_50;
            this.SchedulerBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SchedulerBT.Location = new System.Drawing.Point(3, 3);
            this.SchedulerBT.Name = "SchedulerBT";
            this.SchedulerBT.Size = new System.Drawing.Size(528, 85);
            this.SchedulerBT.TabIndex = 1;
            this.SchedulerBT.Text = "מערכת תכנון שבועי";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 535);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1068, 91);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::Final_Project.Properties.Resources.background;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1072, 628);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Final_Project.Properties.Resources.background1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.main_menu;
            this.pictureBox1.InitialImage = global::Final_Project.Properties.Resources.ilutzon;
            this.pictureBox1.Location = new System.Drawing.Point(2, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(975, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "גרסה 2.0\r\n\r\nיוצרים:\r\nיונתן פוסטרנק\r\nגיא רפאל יונה";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 628);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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