using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private void loginexit_Click(object sender, EventArgs e)
        {
            // Closing whole Program.
            Application.Exit();
        }

        private void asadmin_Click(object sender, EventArgs e)
        {
            // opening Adming login page and closing current class.
            AdminLogin obj = new AdminLogin();
            obj.Show();
            this.Close();
        }

        private void asemployee_Click(object sender, EventArgs e)
        {
            // opening Stafflogin class closing current one
            StaffLogin obj = new StaffLogin();
            obj.Show();
            this.Close();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
