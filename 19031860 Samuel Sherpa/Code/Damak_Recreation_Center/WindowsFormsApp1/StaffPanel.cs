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
    public partial class StaffPanel : Form
    {
        public StaffPanel()
        {
            InitializeComponent();
            // Displaying first item as default in the combobox
            this.cbSortby.SelectedIndex = 0;

            // display data of customers in the dataGridView
            BindData("customer.csv");

            //Hide Reports panel at first
            this.weeklyreportPanel.Hide();
            this.dailyreportPanel.Hide();
        }

        // Load customer form window and hide this window
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Addcustomer cstobj = new Addcustomer();
            cstobj.Show();
        }

        // Method to read the customer.csv file and display in the data grid view
        public void BindData(String filePath)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        dt.Columns.Add(new DataColumn(headerWord));
                    }
                    //For Data
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
                    DGcustomerdetails.DataSource = dt;
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No tikets and visitors are added yet", "No Visitors", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        // Bubble sort method  been used here.
        private int[] SystemBubbleSort(int[] ary)
        {
            int temp; // storing data temporarily
            for (int j = 0; j <= ary.Length - 2; j++)
            {
                for (int i = 0; i <= ary.Length - 2; i++)
                {
                    if (ary[i] > ary[i + 1])
                    {
                        temp = ary[i + 1];
                        ary[i + 1] = ary[i];
                        ary[i] = temp;
                    }
                }
            }
            return ary;
        }

        // Method to perform bubble sort on weekly data
        // The sorting algorithm goes here below down :- 
        private void performBubbleSort(string category)
        {
            int i = 0;
            int k = 1;

            // Created list to store multiple arrays of weekly data
            List<string[]> listOfWeeklyData = new List<string[]>();

            // Method called to get weekly data of total earning and total visitor
            int[] totalEarnNVisit = getWeeklyReportData();

            // Declear arrays and store weekly data based on week days          
            string[] sun = { "Sunday", totalEarnNVisit[0].ToString(), totalEarnNVisit[1].ToString() }; //Formate {days name, total earning, total visitors}
            string[] mon = { "Monday", totalEarnNVisit[2].ToString(), totalEarnNVisit[3].ToString() };
            string[] tue = { "Tuesday", totalEarnNVisit[4].ToString(), totalEarnNVisit[5].ToString() };
            string[] wed = { "Wednesday", totalEarnNVisit[6].ToString(), totalEarnNVisit[7].ToString() };
            string[] thu = { "Thursday", totalEarnNVisit[8].ToString(), totalEarnNVisit[9].ToString() };
            string[] fri = { "Friday", totalEarnNVisit[10].ToString(), totalEarnNVisit[11].ToString() };
            string[] sat = { "Saturday", totalEarnNVisit[12].ToString(), totalEarnNVisit[13].ToString() };

            // arrays added to the list
            listOfWeeklyData.Add(sun);
            listOfWeeklyData.Add(mon);
            listOfWeeklyData.Add(tue);
            listOfWeeklyData.Add(wed);
            listOfWeeklyData.Add(thu);
            listOfWeeklyData.Add(fri);
            listOfWeeklyData.Add(sat);

            //Decleared an array to store total earnings of each day
            int[] aryTotalData = new int[7];
            int categoryIndex = 1; //to store all data of total earnings

            if (category == "total visitors")
            {
                categoryIndex = 2; //to store all data of total visitors
            }

            foreach (var data in listOfWeeklyData)
            {
                aryTotalData[i] = Int32.Parse(data[categoryIndex]);
                i++;
            }

            int[] sortAryData = SystemBubbleSort(aryTotalData);

            string[] sortDataTableView = new string[8];   //created new array to store all the report data in sorted
            sortDataTableView[0] = "Day Name,Total Earnings,Total Visitor";     // Hearder to display data in the grid view.

            for (int j = 0; j < sortAryData.Length; j++)
            {
                if (j == sortAryData.Length - 1)
                {
                    foreach (var data in listOfWeeklyData)
                    {
                        if (sortAryData[j] == Int32.Parse(data[categoryIndex]))
                        {
                            sortDataTableView[k] = data[0] + "," + data[1] + "," + data[2];
                            k++;
                        }
                    }
                }
                else if (sortAryData[j] == sortAryData[j + 1])
                {
                    continue;
                }
                else
                {
                    foreach (var data in listOfWeeklyData)
                    {
                        if (sortAryData[j] == Int32.Parse(data[categoryIndex]))
                        {
                            sortDataTableView[k] = data[0] + "," + data[1] + "," + data[2];
                            k++;
                        }
                    }
                }
            }
            //return sortArrayyEarning;  
            displayReportDataInaTable(sortDataTableView, "weekly");
        }


        // Method to get all the date of the current week for generating weekly report
        private string[] getWeeklydate()
        {
            var today = DateTime.Now.Date;  // Random Date.
            int day = (int)today.DayOfWeek; //Number of the day in week. (0 - Sunday, 1 - Monday... and so On)

            int totalDaysOfWeekPassed = day + 1;    // week days number remain constant.

            // initilize new arrays aryDate to store all data of a week in array.
            string[] dtArray = new string[totalDaysOfWeekPassed];
            int index = 0;

            for (var i = -day; i < -day + totalDaysOfWeekPassed; i++)
            {
                dtArray[index] = today.AddDays(i).Date.ToString("dd" + " " + "MMMM" + " " + "yyyy");
                index++;
            }
            return dtArray;
        }

        //Method get required data in list from the customer.scv file
        private List<CustomerDetails> ReadCSVFile(string fileName)
        {
            try
            {
                var lines = File.ReadAllLines(fileName);

                var list = new List<CustomerDetails>();
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    var customerDetails = new CustomerDetails()
                    {
                        ticketId = data[0],
                        customerName = data[1],
                        category = data[4],
                        date = data[5],
                        nameOfDay = data[6],
                        totalPeople = data[7],
                        totalTime = data[8],
                        ticketRate = data[11],
                        totalAmount = data[12]
                    };
                    list.Add(customerDetails);
                }
                return list;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Customer File not found", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return new List<CustomerDetails>();
        }

        // Method to return all the total earning and visitors for weekly report
        private int[] getWeeklyReportData()
        {
            int sunEarning = 0;
            int sunVisitor = 0;
            int monEarning = 0;
            int monVisitor = 0;
            int tueEarning = 0;
            int tueVisitor = 0;
            int wedEarning = 0;
            int wedVisitor = 0;
            int thuEarning = 0;
            int thuVisitor = 0;
            int friEarning = 0;
            int friVisitor = 0;
            int satEarning = 0;
            int satVisitor = 0;

            string[] weekDates = getWeeklydate();

            List<CustomerDetails> data = ReadCSVFile("customer.csv");
            data.ForEach(x =>
            {
                for (int i = 0; i < weekDates.Length; i++)
                {
                    if (x.date.Trim().ToLower() == weekDates[i].ToLower()){
                        if (x.nameOfDay.Trim().ToLower() == "sunday")
                        {
                            sunEarning += Int32.Parse(x.totalAmount);
                            sunVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "monday")
                        {
                            monEarning += Int32.Parse(x.totalAmount);
                            monVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "tuesday")
                        {
                            tueEarning += Int32.Parse(x.totalAmount);
                            tueVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "wednesday")
                        {
                            wedEarning += Int32.Parse(x.totalAmount);
                            wedVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "thursday")
                        {
                            thuEarning += Int32.Parse(x.totalAmount);
                            thuVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "friday")
                        {
                            friEarning += Int32.Parse(x.totalAmount);
                            friVisitor += Int32.Parse(x.totalPeople);
                        }
                        else if (x.nameOfDay.Trim().ToLower() == "saturday")
                        {
                            satEarning += Int32.Parse(x.totalAmount);
                            satVisitor += Int32.Parse(x.totalPeople);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            });
            int[] totalEarningNPeople = new int[14] { sunEarning, sunVisitor, monEarning, monVisitor, tueEarning, tueVisitor, wedEarning, wedVisitor,
            thuEarning, thuVisitor, friEarning, friVisitor, satEarning, satVisitor};
            return totalEarningNPeople;
        }

        // Method to display Report data in data grid view
        private void displayReportDataInaTable(string[] weeklyData, string tableType)
        {
            DataTable dt = new DataTable();

            //Method weeklyReportData called to get weekly data stored in string array
            if (weeklyData.Length > 0)
            {
                //first line to create header
                string firstLine = weeklyData[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < weeklyData.Length; i++)
                {
                    string[] dataWords = weeklyData[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }

            if (dt.Rows.Count > 0 && tableType == "weekly")
            {
                dgvWeeklyReport.DataSource = dt;
            } 
            else if (dt.Rows.Count > 0 && tableType == "daily")
            {
                DGVdailyreport.DataSource = dt;
            }
        }

      

        //Method to get the date for current day and first day ie Sunday of the current week to display in the header of weekly report
        private string getCurrentWeekFirstDate()
        {
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
            int daysTillCurrentDay = currentDay - DayOfWeek.Sunday;
            DateTime currentWeekStartDate =
            DateTime.Now.AddDays(-daysTillCurrentDay);
            return currentWeekStartDate.ToString("dd" + " " + "MMMM" + " " + "yyyy") + " to " + DateTime.Now.ToString("dd" + " " + "MMMM" + " " + "yyyy");
        }

        // Generate weekly report
        private void generateWeeklyReport(object sender, EventArgs e)
        {
            // clear data from weekly bargraph to avoid displaying repetition of same data  when the weekly report button is clicked multiple times.
            foreach (var series in weeklyreportChart.Series)
            {
                series.Points.Clear();
            }

            //Display date of sunday and current day of the current week
            lblWeeklyDate.Text = getCurrentWeekFirstDate();

            //Display weekly report panel
            this.weeklyreportPanel.BringToFront();
            this.weeklyreportPanel.Show();

            //Hide daily report panel
            this.dailyreportPanel.SendToBack();
            this.dailyreportPanel.Hide();

            //method called to get the weekly report data
            int[] totalEarnNVisit = getWeeklyReportData();
            int sunEarn = totalEarnNVisit[0];
            int sunVisit = totalEarnNVisit[1];
            int monEarn = totalEarnNVisit[2];
            int monVisit = totalEarnNVisit[3];
            int tueEarn = totalEarnNVisit[4];
            int tueVisit = totalEarnNVisit[5];
            int wedEarn = totalEarnNVisit[6];
            int wedVisit = totalEarnNVisit[7];
            int thuEarn = totalEarnNVisit[8];
            int thuVisit = totalEarnNVisit[9];
            int friEarn = totalEarnNVisit[10];
            int friVisit = totalEarnNVisit[11];
            int satEarn = totalEarnNVisit[12];
            int satVisit = totalEarnNVisit[13];

            // Method dailyReportData is called and passed its return value to Method displayWeeklyDataInTable to display data in data grid view.
            displayReportDataInaTable(getWeeklyReportDataforgraph(), "weekly");

            //Method called to dispaly the bargraph for weekly report
            drawWeeklyBarChart(sunEarn, sunVisit, monEarn, monVisit, tueEarn, tueVisit, wedEarn, wedVisit, thuEarn, thuVisit, friEarn, friVisit, satEarn, satVisit);
        }

        // Function to read customer.csv file store in the object of the class CustomerDetails for daily report 
        private int[] ReadCustomerCSVFile(string fileName)
        {
            string todayDate = DateTime.Now.ToString("dd" + " " + "MMMM" + " " + "yyyy");
            int totalChild = 0;
            int totalAdult = 0;
            int totalGroupOf5 = 0;
            int totalGroupOf10 = 0;
            int totalGroupOf20 = 0;

            // Method ReadCSVFile called and stored data in CustomerDetails list
            List<CustomerDetails> list = ReadCSVFile("customer.csv");
            try
            {
                list.ForEach(x =>
                {
                    if (x.date.Trim() == todayDate)
                    {
                        if (x.category.Trim() == "Child (5-12)")
                        {
                            totalChild += Int32.Parse(x.totalPeople);
                        }
                        else if (x.category.Trim() == "Adult > 12")
                        {
                            totalAdult += Int32.Parse(x.totalPeople);
                        }
                        else if (x.category.Trim() == "Group of 5")
                        {
                            totalGroupOf5 += Int32.Parse(x.totalPeople);
                        }
                        else if (x.category.Trim() == "Group of 10")
                        {
                            totalGroupOf10 += Int32.Parse(x.totalPeople);
                        }
                        else if (x.category.Trim() == "Group of 20")
                        {
                            totalGroupOf20 += Int32.Parse(x.totalPeople);
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                );
            }
            catch (FormatException)
            {
            }
            int[] totalPeopleArray = new int[5] { totalChild, totalAdult, totalGroupOf5, totalGroupOf10, totalGroupOf20 };
            return totalPeopleArray;
        }

        // Display daily report
        private void displayDailyReport(object sender, EventArgs e)
        {
            // clear data from daily bargraph to avoid displaying repetition of same data  when the daily report button is clicked multiple times.
            foreach (var series in DailyReportChart.Series)
            {
                series.Points.Clear();
            }
          
            // Display current date
            lblDailyReport.Text = DateTime.Now.ToString("dd" + " " + "MMMM" + " " + "yyyy");

            // Display daily report panel

            dailyreportPanel.BringToFront();
            dailyreportPanel.Show();

            // Hide weekly report panel
            weeklyreportPanel.SendToBack();
            weeklyreportPanel.Hide();

            // Method dailyReportata called and passed its return value to Method displayWeeklyDataInTable to display data in data grid view.
            displayReportDataInaTable(getdailyReportData(), "daily");

            // Method called to get data from the customer.csv file
            ReadCustomerCSVFile("customer.csv");
            int[] totalPeople = ReadCustomerCSVFile("customer.csv");
            int totalChild = totalPeople[0];
            int totalAdult = totalPeople[1];
            int totalGroupOf5 = totalPeople[2];
            int totalGroupOf10 = totalPeople[3];
            int totalGroupOf20 = totalPeople[4];

            // to display daily repot in bargraph
            drawDailyBarChart(totalChild, totalAdult, totalGroupOf5, totalGroupOf10, totalGroupOf20);
        }

        // Method to get daily report data to display in data grid view
        private string[] getdailyReportData()
        {
            // Method called to get data from the customer.csv file
            ReadCustomerCSVFile("customer.csv");
            int[] totalPeople = ReadCustomerCSVFile("customer.csv");
            int totalChild = totalPeople[0];
            int totalAdult = totalPeople[1];
            int totalGroupOf5 = totalPeople[2];
            int totalGroupOf10 = totalPeople[3];
            int totalGroupOf20 = totalPeople[4];

            //Created new array to store daily report data for displayingin data grid view
            string[] dailyReportTableView = new string[6];
            dailyReportTableView[0] = "Category,Total Visitors";
            dailyReportTableView[1] = "Child (5-12)" + "," + totalPeople[0].ToString();
            dailyReportTableView[2] = "Adult > 12" + "," + totalPeople[1].ToString();
            dailyReportTableView[3] = "Group of 5" + "," + totalPeople[2].ToString();
            dailyReportTableView[4] = "Group of 10" + "," + totalPeople[3].ToString();
            dailyReportTableView[5] = "Groupo of 20" + "," + totalPeople[4].ToString();

            return dailyReportTableView;
        }


        // Weekly Report data to displayed in a data grid view.
        private string[] getWeeklyReportDataforgraph()
        {
            int[] totalEarnNVisit = getWeeklyReportData();

            string[] weeklyReportTableView = new string[8];
            weeklyReportTableView[0] = "Day Nam,Total Earning,Total Visitors";
            weeklyReportTableView[1] = "Sunday" + "," + totalEarnNVisit[0] + "," + totalEarnNVisit[1];
            weeklyReportTableView[2] = "Monday" + "," + totalEarnNVisit[2] + "," + totalEarnNVisit[3];
            weeklyReportTableView[3] = "Tuesday" + "," + totalEarnNVisit[4] + "," + totalEarnNVisit[5];
            weeklyReportTableView[4] = "Wednesday" + "," + totalEarnNVisit[6] + "," + totalEarnNVisit[7];
            weeklyReportTableView[5] = "Thursday" + "," + totalEarnNVisit[8] + "," + totalEarnNVisit[9];
            weeklyReportTableView[6] = "Friday" + "," + totalEarnNVisit[10] + "," + totalEarnNVisit[11];
            weeklyReportTableView[7] = "Saturday" + "," + totalEarnNVisit[12] + "," + totalEarnNVisit[13];

            return weeklyReportTableView;
        }

       
        //Sorting based on total earning, and days name
        private void cbSortby_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string category = cbSortby.SelectedItem.ToString().Trim();
            if (category == "Total Earnings") 
            {
                // Method called to perform sorting based on total earning and display in data grid view
                performBubbleSort("total earnings");
            }
            else if (category == "Total Visitors")
            {
                // Method called to perform sorting based on total earning and display in data grid view
                performBubbleSort("total visitors");
            }
            else if (category == "Week")
            {
                // Method dailyReportData called and passed its return value to Method displayWeeklyDataInTable to display data in data grid view.
                displayReportDataInaTable(getWeeklyReportDataforgraph(), "weekly");
            }
        }

        // Method to draw weekly bar chart 
        private void drawWeeklyBarChart(int sundayEarn, int sundayVisit, int mondayEarn, int mondayVisit, int tuedayEarn, int tuesdayVisit, int wedEarn, int wedVisit, int thuEarn, int thuVisit, int friEarn, int friVisit, int satEarn, int satVisit)
        {
            try
            {
                // Sunday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(sundayVisit);
                weeklyreportChart.Series["Total Visitors"].Points[0].AxisLabel = "SUN";
                weeklyreportChart.Series["Total Visitors"].Points[0].LegendText = "SUN";
                weeklyreportChart.Series["Total Visitors"].Points[0].Label = sundayVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(sundayEarn);
                weeklyreportChart.Series["Total Earning"].Points[0].Label = sundayEarn.ToString();

                // Monday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(mondayVisit);
                weeklyreportChart.Series["Total Visitors"].Points[1].AxisLabel = "MON";
                weeklyreportChart.Series["Total Visitors"].Points[1].LegendText = "MON";
                weeklyreportChart.Series["Total Visitors"].Points[1].Label = mondayVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(mondayEarn);
                weeklyreportChart.Series["Total Earning"].Points[1].Label = mondayEarn.ToString();

                // Tuesday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(tuesdayVisit);
                weeklyreportChart.Series["Total Visitors"].Points[2].AxisLabel = "TUE";
                weeklyreportChart.Series["Total Visitors"].Points[2].LegendText = "TUE";
                weeklyreportChart.Series["Total Visitors"].Points[2].Label = tuesdayVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(tuedayEarn);
                weeklyreportChart.Series["Total Earning"].Points[2].Label = tuedayEarn.ToString();

                // Wednesday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(wedVisit);
                weeklyreportChart.Series["Total Visitors"].Points[3].AxisLabel = "WED";
                weeklyreportChart.Series["Total Visitors"].Points[3].LegendText = "WED";
                weeklyreportChart.Series["Total Visitors"].Points[3].Label = wedVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(wedEarn);
                weeklyreportChart.Series["Total Earning"].Points[3].Label = wedEarn.ToString();

                // Thursday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(thuVisit);
                weeklyreportChart.Series["Total Visitors"].Points[4].AxisLabel = "THU";
                weeklyreportChart.Series["Total Visitors"].Points[4].LegendText = "THU";
                weeklyreportChart.Series["Total Visitors"].Points[4].Label = thuVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(thuEarn);
                weeklyreportChart.Series["Total Earning"].Points[4].Label = thuEarn.ToString();

                // Friday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(friVisit);
                weeklyreportChart.Series["Total Visitors"].Points[5].AxisLabel = "FRI";
                weeklyreportChart.Series["Total Visitors"].Points[5].LegendText = "FRI";
                weeklyreportChart.Series["Total Visitors"].Points[5].Label = friVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(friEarn);
                weeklyreportChart.Series["Total Earning"].Points[5].Label = friEarn.ToString();

                // Saturday bar
                weeklyreportChart.Series["Total Visitors"].Points.Add(satVisit);
                weeklyreportChart.Series["Total Visitors"].Points[6].AxisLabel = "SAT";
                weeklyreportChart.Series["Total Visitors"].Points[6].LegendText = "SAT";
                weeklyreportChart.Series["Total Visitors"].Points[6].Label = satVisit.ToString();

                weeklyreportChart.Series["Total Earning"].Points.Add(satEarn);
                weeklyreportChart.Series["Total Earning"].Points[6].Label = satEarn.ToString();

            }
            catch (ArgumentException)
            {
                return;
            }
        }
        // Create daily bar chart
        private void drawDailyBarChart(int child, int adult, int groupOf5, int groupOf10, int groupOf20)
        {
            DailyReportChart.Series["Category"].Points.Add(child);
            DailyReportChart.Series["Category"].Points[0].AxisLabel = "Child";
            DailyReportChart.Series["Category"].Points[0].LegendText = "Child";
            DailyReportChart.Series["Category"].Points[0].Label = child.ToString();

            DailyReportChart.Series["Category"].Points.Add(adult);
            DailyReportChart.Series["Category"].Points[1].AxisLabel = "Adult";
            DailyReportChart.Series["Category"].Points[1].LegendText = "Adult";
            DailyReportChart.Series["Category"].Points[1].Label = adult.ToString();

            DailyReportChart.Series["Category"].Points.Add(groupOf5);
            DailyReportChart.Series["Category"].Points[2].AxisLabel = "Group of 5";
            DailyReportChart.Series["Category"].Points[2].LegendText = "Group of 5";
            DailyReportChart.Series["Category"].Points[2].Label = groupOf5.ToString();

            DailyReportChart.Series["Category"].Points.Add(groupOf10);
            DailyReportChart.Series["Category"].Points[3].AxisLabel = "Group of 10";
            DailyReportChart.Series["Category"].Points[3].LegendText = "Group of 10";
            DailyReportChart.Series["Category"].Points[3].Label = groupOf10.ToString();

            DailyReportChart.Series["Category"].Points.Add(groupOf20);
            DailyReportChart.Series["Category"].Points[4].AxisLabel = "Group of 20";
            DailyReportChart.Series["Category"].Points[4].LegendText = "Group of 20";
            DailyReportChart.Series["Category"].Points[4].Label = groupOf20.ToString();
        }

       

        //Log out to the login window from the Staff Panel
        private void button1_Click(object sender, EventArgs e)
        {
                       MainLogin obj = new MainLogin();
            obj.Show();
            this.Close();
        }

        // Exit the application
        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvWeeklyReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelDailyReport_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvDailyReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Staff_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void lblWeeklyDate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StaffPanel_Load(object sender, EventArgs e)
        {

        }

        private void ExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DailyReportChart_Click(object sender, EventArgs e)
        {

        }
    }

    public class CustomerDetails
    {
        public string ticketId { get; set; }
        public string customerName { get; set; }
        public string category { get; set; }
        public string nameOfDay { get; set; }
        public string date { get; set; }
        public string totalPeople { get; set; }
        public string totalTime { get; set; }
        public string ticketRate { get; set; }
        public string totalAmount { get; set; }
    }
}
