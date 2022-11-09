using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConnectBT_Click(object sender, EventArgs e)
        {
            string ConnectionString;
            SqlConnection cnn;

            ConnectionString = $"Data Source={HostAddressTB.Text};Initial Catalog=gril;" +
                $"User Id={UserNameTB.Text};Password={PasswordTB.Text}";

            cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            openMenuForm(cnn);

        }

        private void openMenuForm(SqlConnection cnn)
        {
            MenuForm mf = new MenuForm();
            this.Hide();
            mf.Show();
            
            
        }
    }
}
