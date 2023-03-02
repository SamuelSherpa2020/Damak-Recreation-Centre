
namespace WindowsFormsApp1
{
    partial class Addcustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addcustomer));
            this.lblTicketNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DGdisplayticketrate2 = new System.Windows.Forms.DataGridView();
            this.txtTicketId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTotalPerson = new System.Windows.Forms.TextBox();
            this.txtTimeInHr = new System.Windows.Forms.TextBox();
            this.txtTimeOutHr = new System.Windows.Forms.TextBox();
            this.txtTicketRate = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTimeInMin = new System.Windows.Forms.TextBox();
            this.txtTimeOutMin = new System.Windows.Forms.TextBox();
            this.cbTimeOut = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTimeIn = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ticketformPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGdisplayticketrate2)).BeginInit();
            this.panel1.SuspendLayout();
            this.ticketformPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNo.Location = new System.Drawing.Point(15, 55);
            this.lblTicketNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(82, 19);
            this.lblTicketNo.TabIndex = 5;
            this.lblTicketNo.Text = "Ticket Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ticket Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Amount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Person: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Customer Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 263);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Address:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DGdisplayticketrate2
            // 
            this.DGdisplayticketrate2.AllowUserToOrderColumns = true;
            this.DGdisplayticketrate2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DGdisplayticketrate2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdisplayticketrate2.Location = new System.Drawing.Point(4, 46);
            this.DGdisplayticketrate2.Margin = new System.Windows.Forms.Padding(4);
            this.DGdisplayticketrate2.Name = "DGdisplayticketrate2";
            this.DGdisplayticketrate2.ReadOnly = true;
            this.DGdisplayticketrate2.RowHeadersWidth = 51;
            this.DGdisplayticketrate2.Size = new System.Drawing.Size(836, 194);
            this.DGdisplayticketrate2.TabIndex = 14;
            this.DGdisplayticketrate2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDisplayTicketRate2_CellContentClick);
            // 
            // txtTicketId
            // 
            this.txtTicketId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketId.Location = new System.Drawing.Point(194, 55);
            this.txtTicketId.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.ReadOnly = true;
            this.txtTicketId.Size = new System.Drawing.Size(204, 26);
            this.txtTicketId.TabIndex = 15;
            this.txtTicketId.TextChanged += new System.EventHandler(this.txtTicketId_TextChanged);
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(194, 162);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(204, 26);
            this.txtCustName.TabIndex = 16;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 103);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Time In:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(421, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Time Out:";
            // 
            // txtContNumber
            // 
            this.txtContNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContNumber.Location = new System.Drawing.Point(194, 214);
            this.txtContNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtContNumber.MaxLength = 10;
            this.txtContNumber.Name = "txtContNumber";
            this.txtContNumber.Size = new System.Drawing.Size(204, 26);
            this.txtContNumber.TabIndex = 21;
            this.txtContNumber.TextChanged += new System.EventHandler(this.txtContNumber_TextChanged);
            this.txtContNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContNumber_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(194, 263);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 26);
            this.txtAddress.TabIndex = 22;
            // 
            // txtTotalPerson
            // 
            this.txtTotalPerson.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPerson.Location = new System.Drawing.Point(194, 314);
            this.txtTotalPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPerson.MaxLength = 1;
            this.txtTotalPerson.Name = "txtTotalPerson";
            this.txtTotalPerson.Size = new System.Drawing.Size(204, 26);
            this.txtTotalPerson.TabIndex = 23;
            this.txtTotalPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPerson_KeyPress);
            this.txtTotalPerson.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTotalPerson_KeyUp);
            // 
            // txtTimeInHr
            // 
            this.txtTimeInHr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeInHr.Location = new System.Drawing.Point(557, 98);
            this.txtTimeInHr.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeInHr.MaxLength = 2;
            this.txtTimeInHr.Name = "txtTimeInHr";
            this.txtTimeInHr.Size = new System.Drawing.Size(41, 26);
            this.txtTimeInHr.TabIndex = 24;
            this.txtTimeInHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeIn_KeyPress);
            this.txtTimeInHr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimeInHr_KeyUp);
            // 
            // txtTimeOutHr
            // 
            this.txtTimeOutHr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOutHr.Location = new System.Drawing.Point(557, 150);
            this.txtTimeOutHr.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeOutHr.MaxLength = 2;
            this.txtTimeOutHr.Name = "txtTimeOutHr";
            this.txtTimeOutHr.Size = new System.Drawing.Size(41, 26);
            this.txtTimeOutHr.TabIndex = 25;
            this.txtTimeOutHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeOut_KeyPress);
            this.txtTimeOutHr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimeOutHr_KeyUp);
            // 
            // txtTicketRate
            // 
            this.txtTicketRate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketRate.Location = new System.Drawing.Point(557, 263);
            this.txtTicketRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtTicketRate.Name = "txtTicketRate";
            this.txtTicketRate.ReadOnly = true;
            this.txtTicketRate.Size = new System.Drawing.Size(204, 26);
            this.txtTicketRate.TabIndex = 27;
            this.txtTicketRate.TextChanged += new System.EventHandler(this.txtTicketRate_TextChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(557, 308);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(204, 26);
            this.txtTotalAmount.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.DGdisplayticketrate2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 261);
            this.panel1.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(317, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 34);
            this.label12.TabIndex = 33;
            this.label12.Text = "Ticket Price Rate";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Child (5-12)",
            "Adult > 12",
            "Group of 5",
            "Group of 10",
            "Group of 20"});
            this.cbCategory.Location = new System.Drawing.Point(194, 106);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(204, 26);
            this.cbCategory.TabIndex = 31;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbCategory.SelectionChangeCommitted += new System.EventHandler(this.cbCategory_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(425, 383);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSaveVisitorsDetails);
            // 
            // btnGoback
            // 
            this.btnGoback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGoback.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoback.ForeColor = System.Drawing.Color.Black;
            this.btnGoback.Location = new System.Drawing.Point(557, 383);
            this.btnGoback.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(110, 38);
            this.btnGoback.TabIndex = 35;
            this.btnGoback.Text = "Go Back";
            this.btnGoback.UseVisualStyleBackColor = false;
            this.btnGoback.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 28);
            this.label13.TabIndex = 34;
            this.label13.Text = "Ticket Form";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(557, 55);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 28);
            this.dtpDate.TabIndex = 36;
            this.dtpDate.Value = new System.DateTime(2022, 1, 3, 9, 52, 15, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(772, 404);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 23);
            this.label14.TabIndex = 37;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtTimeInMin
            // 
            this.txtTimeInMin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeInMin.Location = new System.Drawing.Point(658, 98);
            this.txtTimeInMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeInMin.MaxLength = 2;
            this.txtTimeInMin.Name = "txtTimeInMin";
            this.txtTimeInMin.Size = new System.Drawing.Size(47, 26);
            this.txtTimeInMin.TabIndex = 40;
            this.txtTimeInMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtTimeOutMin
            // 
            this.txtTimeOutMin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOutMin.Location = new System.Drawing.Point(658, 150);
            this.txtTimeOutMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeOutMin.MaxLength = 2;
            this.txtTimeOutMin.Name = "txtTimeOutMin";
            this.txtTimeOutMin.Size = new System.Drawing.Size(47, 26);
            this.txtTimeOutMin.TabIndex = 41;
            this.txtTimeOutMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // cbTimeOut
            // 
            this.cbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeOut.FormattingEnabled = true;
            this.cbTimeOut.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cbTimeOut.Location = new System.Drawing.Point(746, 147);
            this.cbTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimeOut.Name = "cbTimeOut";
            this.cbTimeOut.Size = new System.Drawing.Size(59, 26);
            this.cbTimeOut.TabIndex = 43;
            this.cbTimeOut.SelectionChangeCommitted += new System.EventHandler(this.cbTimeOut_SelectionChangeCommitted);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(633, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 24);
            this.label16.TabIndex = 44;
            this.label16.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(633, 154);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 24);
            this.label17.TabIndex = 45;
            this.label17.Text = ":";
            // 
            // cbTimeIn
            // 
            this.cbTimeIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeIn.FormattingEnabled = true;
            this.cbTimeIn.Items.AddRange(new object[] {
            "am",
            "pm"});
            this.cbTimeIn.Location = new System.Drawing.Point(746, 96);
            this.cbTimeIn.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimeIn.Name = "cbTimeIn";
            this.cbTimeIn.Size = new System.Drawing.Size(59, 26);
            this.cbTimeIn.TabIndex = 42;
            this.cbTimeIn.SelectionChangeCommitted += new System.EventHandler(this.cbTimeIn_SelectionChangeCommitted);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(557, 210);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.MaxLength = 2;
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(41, 26);
            this.txtTime.TabIndex = 46;
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(606, 214);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 19);
            this.label15.TabIndex = 47;
            this.label15.Text = "hrs";
            // 
            // ticketformPanel
            // 
            this.ticketformPanel.BackColor = System.Drawing.Color.White;
            this.ticketformPanel.Controls.Add(this.cbTimeOut);
            this.ticketformPanel.Controls.Add(this.txtTime);
            this.ticketformPanel.Controls.Add(this.cbTimeIn);
            this.ticketformPanel.Controls.Add(this.label15);
            this.ticketformPanel.Controls.Add(this.txtTimeOutMin);
            this.ticketformPanel.Controls.Add(this.label13);
            this.ticketformPanel.Controls.Add(this.txtTimeInMin);
            this.ticketformPanel.Controls.Add(this.lblTicketNo);
            this.ticketformPanel.Controls.Add(this.label16);
            this.ticketformPanel.Controls.Add(this.dtpDate);
            this.ticketformPanel.Controls.Add(this.label17);
            this.ticketformPanel.Controls.Add(this.txtTimeOutHr);
            this.ticketformPanel.Controls.Add(this.label4);
            this.ticketformPanel.Controls.Add(this.txtTimeInHr);
            this.ticketformPanel.Controls.Add(this.label8);
            this.ticketformPanel.Controls.Add(this.cbCategory);
            this.ticketformPanel.Controls.Add(this.btnSave);
            this.ticketformPanel.Controls.Add(this.txtTotalAmount);
            this.ticketformPanel.Controls.Add(this.btnGoback);
            this.ticketformPanel.Controls.Add(this.txtTicketRate);
            this.ticketformPanel.Controls.Add(this.label7);
            this.ticketformPanel.Controls.Add(this.label9);
            this.ticketformPanel.Controls.Add(this.label6);
            this.ticketformPanel.Controls.Add(this.txtTotalPerson);
            this.ticketformPanel.Controls.Add(this.label2);
            this.ticketformPanel.Controls.Add(this.txtAddress);
            this.ticketformPanel.Controls.Add(this.label10);
            this.ticketformPanel.Controls.Add(this.txtContNumber);
            this.ticketformPanel.Controls.Add(this.label11);
            this.ticketformPanel.Controls.Add(this.txtTicketId);
            this.ticketformPanel.Controls.Add(this.txtCustName);
            this.ticketformPanel.Controls.Add(this.label1);
            this.ticketformPanel.Controls.Add(this.label3);
            this.ticketformPanel.Controls.Add(this.label5);
            this.ticketformPanel.Location = new System.Drawing.Point(13, 282);
            this.ticketformPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ticketformPanel.Name = "ticketformPanel";
            this.ticketformPanel.Size = new System.Drawing.Size(828, 440);
            this.ticketformPanel.TabIndex = 49;
            this.ticketformPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Addcutomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(866, 735);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ticketformPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Addcutomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                ";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGdisplayticketrate2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ticketformPanel.ResumeLayout(false);
            this.ticketformPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGdisplayticketrate2;
        private System.Windows.Forms.TextBox txtTicketId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTotalPerson;
        private System.Windows.Forms.TextBox txtTimeInHr;
        private System.Windows.Forms.TextBox txtTimeOutHr;
        private System.Windows.Forms.TextBox txtTicketRate;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGoback;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTimeInMin;
        private System.Windows.Forms.TextBox txtTimeOutMin;
        private System.Windows.Forms.ComboBox cbTimeOut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTimeIn;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel ticketformPanel;
    }
}