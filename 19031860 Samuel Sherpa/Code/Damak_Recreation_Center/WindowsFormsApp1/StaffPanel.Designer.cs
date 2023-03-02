
namespace WindowsFormsApp1
{
    partial class StaffPanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitSystem = new System.Windows.Forms.Button();
            this.btngoback = new System.Windows.Forms.Button();
            this.btnWeeklyReport = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.DGcustomerdetails = new System.Windows.Forms.DataGridView();
            this.weeklyreportPanel = new System.Windows.Forms.Panel();
            this.lblWeeklyDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvWeeklyReport = new System.Windows.Forms.DataGridView();
            this.cbSortby = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weeklyreportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DailyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dailyreportPanel = new System.Windows.Forms.Panel();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.DGVdailyreport = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbldmkrecreationcentresystem = new System.Windows.Forms.Label();
            this.LblstaffPanel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGcustomerdetails)).BeginInit();
            this.weeklyreportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyreportChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportChart)).BeginInit();
            this.dailyreportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdailyreport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.ExitSystem);
            this.panel1.Controls.Add(this.btngoback);
            this.panel1.Controls.Add(this.btnWeeklyReport);
            this.panel1.Controls.Add(this.btnDailyReport);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Location = new System.Drawing.Point(1344, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 336);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExitSystem
            // 
            this.ExitSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitSystem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitSystem.Location = new System.Drawing.Point(14, 282);
            this.ExitSystem.Margin = new System.Windows.Forms.Padding(4);
            this.ExitSystem.Name = "ExitSystem";
            this.ExitSystem.Size = new System.Drawing.Size(163, 38);
            this.ExitSystem.TabIndex = 7;
            this.ExitSystem.Text = "Exit";
            this.ExitSystem.UseVisualStyleBackColor = false;
            this.ExitSystem.Click += new System.EventHandler(this.ExitSystem_Click);
            // 
            // btngoback
            // 
            this.btngoback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btngoback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoback.Location = new System.Drawing.Point(14, 219);
            this.btngoback.Margin = new System.Windows.Forms.Padding(4);
            this.btngoback.Name = "btngoback";
            this.btngoback.Size = new System.Drawing.Size(163, 38);
            this.btngoback.TabIndex = 6;
            this.btngoback.Text = " Go Back";
            this.btngoback.UseVisualStyleBackColor = false;
            this.btngoback.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWeeklyReport
            // 
            this.btnWeeklyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnWeeklyReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeeklyReport.Location = new System.Drawing.Point(14, 159);
            this.btnWeeklyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnWeeklyReport.Name = "btnWeeklyReport";
            this.btnWeeklyReport.Size = new System.Drawing.Size(163, 38);
            this.btnWeeklyReport.TabIndex = 5;
            this.btnWeeklyReport.Text = "Weekly Report";
            this.btnWeeklyReport.UseVisualStyleBackColor = false;
            this.btnWeeklyReport.Click += new System.EventHandler(this.generateWeeklyReport);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDailyReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.Location = new System.Drawing.Point(14, 99);
            this.btnDailyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(163, 38);
            this.btnDailyReport.TabIndex = 4;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.UseVisualStyleBackColor = false;
            this.btnDailyReport.Click += new System.EventHandler(this.displayDailyReport);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCustomer.Location = new System.Drawing.Point(14, 39);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(163, 38);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "(+) Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // DGcustomerdetails
            // 
            this.DGcustomerdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGcustomerdetails.Location = new System.Drawing.Point(23, 36);
            this.DGcustomerdetails.Margin = new System.Windows.Forms.Padding(4);
            this.DGcustomerdetails.Name = "DGcustomerdetails";
            this.DGcustomerdetails.ReadOnly = true;
            this.DGcustomerdetails.RowHeadersWidth = 51;
            this.DGcustomerdetails.Size = new System.Drawing.Size(1456, 271);
            this.DGcustomerdetails.TabIndex = 2;
            this.DGcustomerdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // weeklyreportPanel
            // 
            this.weeklyreportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.weeklyreportPanel.Controls.Add(this.lblWeeklyDate);
            this.weeklyreportPanel.Controls.Add(this.label3);
            this.weeklyreportPanel.Controls.Add(this.dgvWeeklyReport);
            this.weeklyreportPanel.Controls.Add(this.cbSortby);
            this.weeklyreportPanel.Controls.Add(this.label2);
            this.weeklyreportPanel.Controls.Add(this.weeklyreportChart);
            this.weeklyreportPanel.Location = new System.Drawing.Point(16, 430);
            this.weeklyreportPanel.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyreportPanel.Name = "weeklyreportPanel";
            this.weeklyreportPanel.Size = new System.Drawing.Size(1317, 401);
            this.weeklyreportPanel.TabIndex = 4;
            this.weeklyreportPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblWeeklyDate
            // 
            this.lblWeeklyDate.AutoSize = true;
            this.lblWeeklyDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyDate.Location = new System.Drawing.Point(14, 49);
            this.lblWeeklyDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyDate.Name = "lblWeeklyDate";
            this.lblWeeklyDate.Size = new System.Drawing.Size(139, 19);
            this.lblWeeklyDate.TabIndex = 9;
            this.lblWeeklyDate.Text = "dd  month  year";
            this.lblWeeklyDate.Click += new System.EventHandler(this.lblWeeklyDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weekly Report";
            // 
            // dgvWeeklyReport
            // 
            this.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyReport.Location = new System.Drawing.Point(45, 125);
            this.dgvWeeklyReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWeeklyReport.Name = "dgvWeeklyReport";
            this.dgvWeeklyReport.ReadOnly = true;
            this.dgvWeeklyReport.RowHeadersWidth = 51;
            this.dgvWeeklyReport.Size = new System.Drawing.Size(457, 257);
            this.dgvWeeklyReport.TabIndex = 5;
            this.dgvWeeklyReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeeklyReport_CellContentClick);
            // 
            // cbSortby
            // 
            this.cbSortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSortby.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortby.FormattingEnabled = true;
            this.cbSortby.Items.AddRange(new object[] {
            "Week",
            "Total Earnings",
            "Total Visitors"});
            this.cbSortby.Location = new System.Drawing.Point(298, 90);
            this.cbSortby.Margin = new System.Windows.Forms.Padding(4);
            this.cbSortby.Name = "cbSortby";
            this.cbSortby.Size = new System.Drawing.Size(204, 27);
            this.cbSortby.TabIndex = 7;
            this.cbSortby.SelectionChangeCommitted += new System.EventHandler(this.cbSortby_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sort By:";
            // 
            // weeklyreportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weeklyreportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyreportChart.Legends.Add(legend1);
            this.weeklyreportChart.Location = new System.Drawing.Point(545, 15);
            this.weeklyreportChart.Margin = new System.Windows.Forms.Padding(4);
            this.weeklyreportChart.Name = "weeklyreportChart";
            this.weeklyreportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Earning";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Visitors";
            this.weeklyreportChart.Series.Add(series1);
            this.weeklyreportChart.Series.Add(series2);
            this.weeklyreportChart.Size = new System.Drawing.Size(703, 367);
            this.weeklyreportChart.TabIndex = 4;
            this.weeklyreportChart.Text = "weeklyreportbargraph";
            title1.Name = "Weeklly Report";
            title1.Text = "Weekly Report Graph";
            this.weeklyreportChart.Titles.Add(title1);
            // 
            // DailyReportChart
            // 
            chartArea2.Name = "ChartArea1";
            this.DailyReportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DailyReportChart.Legends.Add(legend2);
            this.DailyReportChart.Location = new System.Drawing.Point(382, 15);
            this.DailyReportChart.Margin = new System.Windows.Forms.Padding(4);
            this.DailyReportChart.Name = "DailyReportChart";
            this.DailyReportChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Category";
            this.DailyReportChart.Series.Add(series3);
            this.DailyReportChart.Size = new System.Drawing.Size(750, 345);
            this.DailyReportChart.TabIndex = 3;
            this.DailyReportChart.Text = "dailyreportchart";
            title2.Name = "Title1";
            title2.Text = "Daily Report Graph";
            this.DailyReportChart.Titles.Add(title2);
            this.DailyReportChart.Click += new System.EventHandler(this.DailyReportChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visitors Details";
            // 
            // dailyreportPanel
            // 
            this.dailyreportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dailyreportPanel.Controls.Add(this.lblDailyReport);
            this.dailyreportPanel.Controls.Add(this.DGVdailyreport);
            this.dailyreportPanel.Controls.Add(this.label4);
            this.dailyreportPanel.Controls.Add(this.DailyReportChart);
            this.dailyreportPanel.Location = new System.Drawing.Point(19, 430);
            this.dailyreportPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dailyreportPanel.Name = "dailyreportPanel";
            this.dailyreportPanel.Size = new System.Drawing.Size(1159, 401);
            this.dailyreportPanel.TabIndex = 8;
            this.dailyreportPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDailyReport_Paint);
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyReport.Location = new System.Drawing.Point(13, 46);
            this.lblDailyReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(95, 19);
            this.lblDailyReport.TabIndex = 10;
            this.lblDailyReport.Text = "Day name";
            // 
            // DGVdailyreport
            // 
            this.DGVdailyreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdailyreport.Location = new System.Drawing.Point(15, 93);
            this.DGVdailyreport.Margin = new System.Windows.Forms.Padding(4);
            this.DGVdailyreport.Name = "DGVdailyreport";
            this.DGVdailyreport.RowHeadersWidth = 51;
            this.DGVdailyreport.Size = new System.Drawing.Size(350, 267);
            this.DGVdailyreport.TabIndex = 9;
            this.DGVdailyreport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDailyReport_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Daily Report:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lbldmkrecreationcentresystem
            // 
            this.Lbldmkrecreationcentresystem.AutoSize = true;
            this.Lbldmkrecreationcentresystem.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldmkrecreationcentresystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbldmkrecreationcentresystem.Location = new System.Drawing.Point(13, 9);
            this.Lbldmkrecreationcentresystem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbldmkrecreationcentresystem.Name = "Lbldmkrecreationcentresystem";
            this.Lbldmkrecreationcentresystem.Size = new System.Drawing.Size(471, 34);
            this.Lbldmkrecreationcentresystem.TabIndex = 27;
            this.Lbldmkrecreationcentresystem.Text = "Damak Recreation Centre System";
            // 
            // LblstaffPanel
            // 
            this.LblstaffPanel.AutoSize = true;
            this.LblstaffPanel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblstaffPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblstaffPanel.Location = new System.Drawing.Point(1317, 63);
            this.LblstaffPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblstaffPanel.Name = "LblstaffPanel";
            this.LblstaffPanel.Size = new System.Drawing.Size(178, 28);
            this.LblstaffPanel.TabIndex = 3;
            this.LblstaffPanel.Text = "The Staff Panel";
            this.LblstaffPanel.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DGcustomerdetails);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1519, 320);
            this.panel2.TabIndex = 31;
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1576, 869);
            this.Controls.Add(this.LblstaffPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dailyreportPanel);
            this.Controls.Add(this.Lbldmkrecreationcentresystem);
            this.Controls.Add(this.weeklyreportPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StaffPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing_1);
            this.Load += new System.EventHandler(this.StaffPanel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGcustomerdetails)).EndInit();
            this.weeklyreportPanel.ResumeLayout(false);
            this.weeklyreportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyreportChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportChart)).EndInit();
            this.dailyreportPanel.ResumeLayout(false);
            this.dailyreportPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdailyreport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridView DGcustomerdetails;
        private System.Windows.Forms.Panel weeklyreportPanel;
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyreportChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart DailyReportChart;
        private System.Windows.Forms.Button btnWeeklyReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSortby;
        private System.Windows.Forms.Panel dailyreportPanel;
        private System.Windows.Forms.DataGridView dgvWeeklyReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDailyReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWeeklyDate;
        private System.Windows.Forms.DataGridView DGVdailyreport;
        private System.Windows.Forms.Button btngoback;
        private System.Windows.Forms.Label Lbldmkrecreationcentresystem;
        private System.Windows.Forms.Label LblstaffPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitSystem;
    }
}