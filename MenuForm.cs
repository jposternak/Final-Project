using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void DBMaintBT_Click(object sender, EventArgs e)
        {
            DBMaintain dbfrom = new DBMaintain();
            dbfrom.Show();

        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            finally { }
        }

        private void SchedulerBT_Click(object sender, EventArgs e)
        {
            Scheduler dbfrom = new Scheduler();
            dbfrom.Show();
        }
    }
}
