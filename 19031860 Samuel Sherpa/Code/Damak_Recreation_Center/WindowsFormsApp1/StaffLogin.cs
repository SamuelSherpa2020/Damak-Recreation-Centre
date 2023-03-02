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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void asadmin_Click(object sender, EventArgs e)
        {
            if(Txtstaffpassword.Text == "staff")
            {
                //validating password of staff
                StaffPanel obj = new StaffPanel();
                obj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password is below in hin","Wrong Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //opening Mainlogin page and closing current one
            MainLogin obj = new MainLogin();
            obj.Show();
            this.Close();
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
