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
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();

            // Displaying ticket rate in Datagridview table
            BindData("ticketrate.csv");

            // Generating auto cusomer/ticket number
            countTicketidNo("customer.csv");


            // Displaying first item of combobox
            this.cbCategory.SelectedIndex = 0;
            this.cbTimeIn.SelectedIndex = 0;
            this.cbTimeOut.SelectedIndex = 0;

            //setting 00 time in minute
            this.txtTimeInMin.Text = "00";
            this.txtTimeOutMin.Text = "00";
            this.txtTime.Text = "0";

        }

        // Reading .csv file and displaying in datagridview table.
        private void BindData(String filePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //creating first header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //settings/creating data
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
                    DGdisplayticketrate2.DataSource = dt;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Hello  there, The ticketrate.csv file does not exist", "File Not Found!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Calculating total time spend by visitor
        private void updateTotalhourspend()
        {
            string timeInHour = txtTimeInHr.Text;
            string timeOutHour = txtTimeOutHr.Text;

            string timeInAMorPM = cbTimeIn.SelectedItem.ToString();
            string timeOutAMorPM = cbTimeOut.SelectedItem.ToString();
            try
            {          
                int intTimeInHr = Int32.Parse(timeInHour);
                int intTimeOutHr = Int32.Parse(timeOutHour);

                if (timeInAMorPM == "pm")
                {
                    if (intTimeInHr != 12)
                    {
                        intTimeInHr += 12;
                    }
                }

                if (timeOutAMorPM == "pm")
                {
                    if (intTimeOutHr != 12)
                    {
                        intTimeOutHr += 12;
                    }
                }
                int totalTime = intTimeOutHr - intTimeInHr;
                //int totalMin = intTimeOutMin - intTimeInMin;

                if (totalTime >= 0)
                {
                    txtTime.Text = totalTime.ToString();
                }
                else
                {
                    txtTime.Text = "0";
                }
            }
            catch (FormatException)
            {
                return;
            }
        }

        StaffPanel obj = new StaffPanel();

        private void btnSaveVisitorsDetails(object sender, EventArgs e)
        {
            string TicketId = txtTicketId.Text;
            string customerName = txtCustName.Text;
            string custNumber = txtContNumber.Text;
            string category = cbCategory.SelectedItem.ToString();
            string address = txtAddress.Text;
            string totalPeople = txtTotalPerson.Text;
            string totalTIme = txtTime.Text + " Hours";
            string timeIn = txtTimeInHr.Text + " " + cbTimeIn.SelectedItem;
            string timeOut = txtTimeOutHr.Text + " " + cbTimeOut.SelectedItem;
            string ticketRate = txtTicketRate.Text;
            string totalAmount = txtTotalAmount.Text;

            // date values
            string weeklyDate = dtpDate.Value.DayOfWeek.ToString(); // Day name
            string monthlyDate = dtpDate.Value.ToString("MMMM");    //Month Name
            string dayDate = dtpDate.Value.ToString("dd");          // Day date
            string yearDate = dtpDate.Value.ToString("yyyy");       // Year date
            string date = dayDate + " " + monthlyDate + " " + yearDate;

            if (customerName.Trim() != "" && custNumber.Trim() != "" && category.Trim() != "" && address.Trim() != "" && totalPeople.Trim() != "" && timeIn.Trim() != "" && timeOut.Trim() != "")
            {
                // Only 10 digit phone number is possible
                if (custNumber.Length != 10)
                {
                    MessageBox.Show("The number should contain 10 digits", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string FileName = "customer.csv";
                if (!File.Exists(FileName))
                {
                    string HeaderText = "Ticket Id" + ", " + "Customer Name" + ", " + "Contact Number" + ", " + "Address" + ", " + "Category" + ", " + "Date" + ", " + "Name of Day" + ", " + "Total People" + ", " + "Total Time" + ", "
                        + "Time In" + ", " + "Time Out" + ", " + "Ticket Rate" + ", " + "Total Amount" + Environment.NewLine;
                    File.WriteAllText(FileName, HeaderText);
                }
                string clientDetails = TicketId + ", " + customerName + ", " + custNumber + ", " + address + ", " + category + ", " + date + ", " + weeklyDate  + ", " + totalPeople + ", " + totalTIme + ", " + timeIn +
                  ", " + timeOut + ", " + ticketRate + ", " + totalAmount + "\n";
                File.AppendAllText(FileName, clientDetails);
                MessageBox.Show("Data Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Calling binddata() of staff class.
                obj.BindData(FileName);
                obj.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Please, Fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StaffPanel obj = new StaffPanel();
            obj.Show();
            this.Close();
        }

        // only int type is typed in phone number text
        private void txtContNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A number cannot contain letters", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //showing blue error color if number is less than 10 digit
        private void txtContNumber_TextChanged(object sender, EventArgs e)
        {
            if(txtContNumber.TextLength == 10)
            {
                txtContNumber.ForeColor = Color.Black;
            }
            else
            {
                txtContNumber.ForeColor = Color.Blue;
            }
        }

        // Function to allow only integier input in total person text field.
        private void txtTotalPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Method to auto count the ticket id of new visitors
        private void countTicketidNo(string fileName)
        {
            try
            {
                int count = 0;
                var lines = File.ReadAllLines(fileName);
                var list = new List<TicketRate>();
                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    var ticketRate = new TicketRate()
                    {
                        ages = values[0],
                        oneHour = values[1],
                        twoHours = values[2],
                        threeHours = values[3],
                        fourHours = values[4],
                        wholeDay = values[5]
                    };
                    list.Add(ticketRate);
                }
                list.ForEach(x =>
                {
                    count++;
                });
                txtTicketId.Text = count.ToString();
            }
            catch (FileNotFoundException)
            {
                txtTicketId.Text = "1"; // the system will create a new file and set the ticket id value 1 in text field;
            }
        }

        // Method to read the data from ticketrate.csv file and get ticket rate based on category and total time
        private void ReadCSVFile(String fileName, String category = "Child (5-12)", String strTotalTime = "0")
        {
            try
            {
                int totalTime = Int32.Parse(strTotalTime);
                var lines = File.ReadAllLines(fileName);
                var list = new List<TicketRate>();
                foreach (var line in lines)
                {
                    var values = line.Split(',');
                    var ticketRate = new TicketRate()
                    {
                        ages = values[0],
                        oneHour = values[1],
                        twoHours = values[2],
                        threeHours = values[3],
                        fourHours = values[4],
                        wholeDay = values[5]
                    };
                    list.Add(ticketRate);
                }

                // Update the ticket rate text field based on the age category and total time
                list.ForEach(x =>
                {
                    if (x.ages.ToLower() == category.ToLower())
                    {
                        if (totalTime > 0 && totalTime <= 1)
                        {
                            txtTicketRate.Text = x.oneHour;
                        }
                        else if (totalTime <= 2 && totalTime > 1)
                        {
                            txtTicketRate.Text = x.twoHours;
                        }
                        else if (totalTime <= 3 && totalTime > 2)
                        {
                            txtTicketRate.Text = x.threeHours;
                        }
                        else if (totalTime <= 4 && totalTime > 3)
                        {
                            txtTicketRate.Text = x.fourHours;
                        }
                        
                        else if (totalTime >= 5)
                        {
                            txtTicketRate.Text = x.wholeDay;
                        }
                        else
                        {
                            txtTicketRate.Text = "0";
                        }
                    }
                }
                );
            }
            catch (FormatException)
            {
                return;
            }
        }
                // Auto update total amount based on the total number of people
        private void txtTotalPerson_KeyUp(object sender, KeyEventArgs e)
        {
            string totalPerson = txtTotalPerson.Text;
            string ticketRate = txtTicketRate.Text;
            try
            {
                if (totalPerson != "")
                {
                    int intTotalPerson = Int32.Parse(totalPerson);
                    int intTicketRate = Int32.Parse(ticketRate);
                    if (intTotalPerson <= 4)
                    {
                        int intTotalPrice = intTotalPerson * intTicketRate;
                        string totalPrice = intTotalPrice.ToString();
                        txtTotalAmount.Text = totalPrice;
                    }
                    else
                    {
                        MessageBox.Show("Sorry!!, The total number of people greater than 5 cannot be entered.\nTo enter please, select Category of group in the above category", "Greater than 4 People", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTotalAmount.Text = "";
                        txtTotalPerson.Text = "";
                    }
                }
                else
                {
                    txtTotalAmount.Text = "";
                }
            }
            catch (FormatException)
            {
                return;
            }
        }


        // Method to auto Update total Amount based on ticket rate and number of people
        private void autoCalculateTotalAmount()
        {
            if (txtTotalPerson.Text != "")
            {
                int totalPerson = Int32.Parse(txtTotalPerson.Text);
                int ticketRate = Int32.Parse(txtTicketRate.Text);

                int totalAmount = totalPerson * ticketRate;

                txtTotalAmount.Text = totalAmount.ToString();
            }
            else
            {
                txtTotalAmount.Text = "";
            }
        }

          private void cbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Function ReadCSVFile called
            ReadCSVFile("ticketrate.csv", cbCategory.SelectedItem.ToString(), txtTime.Text);

            string category = cbCategory.SelectedItem.ToString();
            if (category == "Group of 5")
            {
                txtTotalPerson.ReadOnly = true;
                txtTotalPerson.Text = "5";
            }
            else if (category == "Group of 10")
            {
                txtTotalPerson.ReadOnly = true;
                txtTotalPerson.Text = "10";
            }
            else if (category == "Group of 15")
            {
                txtTotalPerson.ReadOnly = true;
                txtTotalPerson.Text = "15";
            }
            else if (category == "Group of 20")
            {
                txtTotalPerson.ReadOnly = true;
                txtTotalPerson.Text = "20";
            }
            else 
            {
                txtTotalPerson.ReadOnly = false;
                txtTotalPerson.Text = "";
            }

            // Method called to auto Update to total amount based on total number of people and ticket rate
            autoCalculateTotalAmount();
        }


       
        private void txtTimeIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtTimeOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please, enter the int number input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Counts total time on the basis of entered in and out time.
        private void cbTimeOut_SelectionChangeCommitted(object sender, EventArgs e)
        {
             updateTotalhourspend();
        }

        // Counts total time using time In data and Time out data
        private void cbTimeIn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Method autoUpdateTotalTime called to auto update total time
            updateTotalhourspend();
        }

        private void txtTimeOutHr_KeyUp(object sender, KeyEventArgs e)
        {
            // Method autoUpdateTotalTime called to auto update total time
            updateTotalhourspend();

            // Method ReadCSVFile called to set the ticket rate based on total time and category
            ReadCSVFile("ticketrate.csv", cbCategory.SelectedItem.ToString(), txtTime.Text);
        }

        private void txtTimeInHr_KeyUp(object sender, KeyEventArgs e)
        {
            // Method autoUpdateTotalTime called to auto update total time
            updateTotalhourspend();
        }

        private void txtTicketRate_TextChanged(object sender, EventArgs e)
        {
            // Method auto update total amount called
            autoCalculateTotalAmount();
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            // Method ReadCSVFile called, to set the ticket rate based on total time and category
            ReadCSVFile("ticketrate.csv", cbCategory.SelectedItem.ToString(), txtTime.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void txtTicketId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgDisplayTicketRate2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Customer_Load(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class TicketRate
    {
        public string ages { get; set; }
        public string oneHour { get; set; }
        public string twoHours { get; set; }
        public string threeHours { get; set; }
        public string fourHours { get; set; }
        public string wholeDay { get; set; }
    }
}
