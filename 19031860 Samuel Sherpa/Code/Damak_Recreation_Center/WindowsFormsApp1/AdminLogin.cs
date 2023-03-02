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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Opening Mainlogin class and closing current one.
            MainLogin obj = new MainLogin();
            obj.Show();
            this.Close();
        }

        private void asadmin_Click(object sender, EventArgs e)
        {

            //validating the password of admin
            if (Txtadminpassword.Text == "admin")
            {
                //opening admingpanel class
                AdminPanel obj = new AdminPanel();
                obj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is below in hin", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txtadminpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
