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
            this.SuspendLayout();
            // 
            // DBMaintBT
            // 
            this.DBMaintBT.Location = new System.Drawing.Point(43, 84);
            this.DBMaintBT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DBMaintBT.Name = "DBMaintBT";
            this.DBMaintBT.Size = new System.Drawing.Size(236, 282);
            this.DBMaintBT.TabIndex = 0;
            this.DBMaintBT.Text = "תחזק טבלאות מערכת";
            this.DBMaintBT.UseVisualStyleBackColor = true;
            this.DBMaintBT.Click += new System.EventHandler(this.DBMaintBT_Click);
            // 
            // SchedulerBT
            // 
            this.SchedulerBT.Location = new System.Drawing.Point(407, 101);
            this.SchedulerBT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SchedulerBT.Name = "SchedulerBT";
            this.SchedulerBT.Size = new System.Drawing.Size(301, 265);
            this.SchedulerBT.TabIndex = 1;
            this.SchedulerBT.Text = "פתח תכנון שבועי";
            this.SchedulerBT.UseVisualStyleBackColor = true;
            this.SchedulerBT.Click += new System.EventHandler(this.SchedulerBT_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SchedulerBT);
            this.Controls.Add(this.DBMaintBT);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "אילוצון - תפריט פעולות";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DBMaintBT;
        private System.Windows.Forms.Button SchedulerBT;
    }
}