using Microsoft.Azure.KeyVault.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            // automatically displaying ticket price rate from .CSV file
            BindData("ticketrate.csv");

            // Display first item as default in combobox
            this.cbCustomerType.SelectedIndex = 0;
        }

        // Method to load .csv file data in datagridview.
        private void BindData(String filePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //first line to create header of the csv file
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For storing Data
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;
                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dt.Rows.Add(dr);
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    Dgdisplayticketrate.DataSource = dt;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void saveUpdatedTicketprice(object sender, EventArgs e)
        {
            string category = cbCustomerType.SelectedItem.ToString();
            string oneHr = Txtonehour.Text;
            string twoHr = Txttwohour.Text;
            string threeHr = Txtthreehour.Text;
            string fourHr = Txtfourhour.Text;
            string greaterFiveHr = Txtwholeday.Text;

            if (oneHr.Trim() != "" && twoHr.Trim() != "" && threeHr.Trim() != "" && fourHr.Trim() != "" && greaterFiveHr.Trim() != "")
            {
                string ticketRateData = category + ", " + oneHr.Trim() + ", " + twoHr.Trim() + ", " + threeHr.Trim() + ", " + fourHr.Trim() + ", " + greaterFiveHr.Trim();
                
                string[] oldTikcketRate = File.ReadAllLines("ticketrate.csv");

                if (category.Trim() == "Child (5-12)")
                {
                    oldTikcketRate[1] = ticketRateData;
                }
                else if (category.Trim() == "Adult > 12")
                {
                    oldTikcketRate[2] = ticketRateData;
                }
                else if (category.Trim() == "Group of 5")
                {
                    oldTikcketRate[3] = ticketRateData;
                }
                else if (category.Trim() == "Group of 10")
                {
                    oldTikcketRate[4] = ticketRateData;
                }
                else if (category.Trim() == "Group of 20")
                {
                    oldTikcketRate[5] = ticketRateData;
                }
                File.WriteAllLines("ticketrate.csv", oldTikcketRate);
                MessageBox.Show("Ticket Price Rate Updated Successfully !!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Display updated ticket rate data in data grid view
                BindData("ticketrate.csv");

                //Clear text fields 
                cbCustomerType.SelectedIndex = 0;
                Txtonehour.Text = "";
                Txttwohour.Text = "";
                Txtthreehour.Text = "";
                Txtfourhour.Text = "";
                Txtwholeday.Text = "";
            }
            else
            {
                MessageBox.Show("All the Textfields are empty", "Empty Field !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void txtOneHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Method to allow only integer value input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number type input", "Invalid Input !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTwoHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number type input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtThreeHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtFourHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number type input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtfiveHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainLogin obj = new MainLogin();
            obj.Show();
            this.Close();
        }

        private void Admin_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }

        private void Txtfourhour_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
