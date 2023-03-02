
namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.Lbladminpanel = new System.Windows.Forms.Label();
            this.Dgdisplayticketrate = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnupdaterate = new System.Windows.Forms.Button();
            this.Ticketrate = new System.Windows.Forms.Label();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.Txtonehour = new System.Windows.Forms.TextBox();
            this.Txttwohour = new System.Windows.Forms.TextBox();
            this.Txtthreehour = new System.Windows.Forms.TextBox();
            this.Txtfourhour = new System.Windows.Forms.TextBox();
            this.Onehour = new System.Windows.Forms.Label();
            this.threehour = new System.Windows.Forms.Label();
            this.fourhour = new System.Windows.Forms.Label();
            this.wholeday = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.twohour = new System.Windows.Forms.Label();
            this.Txtwholeday = new System.Windows.Forms.TextBox();
            this.UpdateTicketRate = new System.Windows.Forms.Label();
            this.Lbldmkrecreationcentre = new System.Windows.Forms.Label();
            this.behindTicketRatePanel = new System.Windows.Forms.Panel();
            this.AdminGoback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgdisplayticketrate)).BeginInit();
            this.panel1.SuspendLayout();
            this.behindTicketRatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbladminpanel
            // 
            this.Lbladminpanel.AutoSize = true;
            this.Lbladminpanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbladminpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbladminpanel.Location = new System.Drawing.Point(7, 39);
            this.Lbladminpanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbladminpanel.Name = "Lbladminpanel";
            this.Lbladminpanel.Size = new System.Drawing.Size(134, 23);
            this.Lbladminpanel.TabIndex = 3;
            this.Lbladminpanel.Text = "Admin Panel";
            // 
            // Dgdisplayticketrate
            // 
            this.Dgdisplayticketrate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgdisplayticketrate.Location = new System.Drawing.Point(17, 48);
            this.Dgdisplayticketrate.Margin = new System.Windows.Forms.Padding(4);
            this.Dgdisplayticketrate.Name = "Dgdisplayticketrate";
            this.Dgdisplayticketrate.RowHeadersWidth = 51;
            this.Dgdisplayticketrate.Size = new System.Drawing.Size(857, 239);
            this.Dgdisplayticketrate.TabIndex = 11;
            this.Dgdisplayticketrate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnupdaterate
            // 
            this.btnupdaterate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnupdaterate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdaterate.ForeColor = System.Drawing.Color.Black;
            this.btnupdaterate.Location = new System.Drawing.Point(29, 383);
            this.btnupdaterate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdaterate.Name = "btnupdaterate";
            this.btnupdaterate.Size = new System.Drawing.Size(176, 43);
            this.btnupdaterate.TabIndex = 13;
            this.btnupdaterate.Text = "Update Rate";
            this.btnupdaterate.UseVisualStyleBackColor = false;
            this.btnupdaterate.Click += new System.EventHandler(this.saveUpdatedTicketprice);
            // 
            // Ticketrate
            // 
            this.Ticketrate.AutoSize = true;
            this.Ticketrate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticketrate.ForeColor = System.Drawing.Color.Black;
            this.Ticketrate.Location = new System.Drawing.Point(13, 15);
            this.Ticketrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ticketrate.Name = "Ticketrate";
            this.Ticketrate.Size = new System.Drawing.Size(117, 23);
            this.Ticketrate.TabIndex = 14;
            this.Ticketrate.Text = "Ticket Rate";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Items.AddRange(new object[] {
            "Child (5-12)",
            "Adult > 12",
            "Group of 5",
            "Group of 10",
            "Group of 20"});
            this.cbCustomerType.Location = new System.Drawing.Point(109, 55);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(4);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(108, 26);
            this.cbCustomerType.TabIndex = 15;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(10, 57);
            this.category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(90, 19);
            this.category.TabIndex = 16;
            this.category.Text = "Category:";
            // 
            // Txtonehour
            // 
            this.Txtonehour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtonehour.Location = new System.Drawing.Point(108, 111);
            this.Txtonehour.Margin = new System.Windows.Forms.Padding(4);
            this.Txtonehour.Name = "Txtonehour";
            this.Txtonehour.Size = new System.Drawing.Size(108, 26);
            this.Txtonehour.TabIndex = 17;
            this.Txtonehour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOneHr_KeyPress);
            // 
            // Txttwohour
            // 
            this.Txttwohour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttwohour.Location = new System.Drawing.Point(108, 169);
            this.Txttwohour.Margin = new System.Windows.Forms.Padding(4);
            this.Txttwohour.Name = "Txttwohour";
            this.Txttwohour.Size = new System.Drawing.Size(108, 26);
            this.Txttwohour.TabIndex = 18;
            this.Txttwohour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTwoHr_KeyPress);
            // 
            // Txtthreehour
            // 
            this.Txtthreehour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtthreehour.Location = new System.Drawing.Point(108, 225);
            this.Txtthreehour.Margin = new System.Windows.Forms.Padding(4);
            this.Txtthreehour.Name = "Txtthreehour";
            this.Txtthreehour.Size = new System.Drawing.Size(108, 26);
            this.Txtthreehour.TabIndex = 19;
            this.Txtthreehour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThreeHr_KeyPress);
            // 
            // Txtfourhour
            // 
            this.Txtfourhour.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtfourhour.Location = new System.Drawing.Point(108, 282);
            this.Txtfourhour.Margin = new System.Windows.Forms.Padding(4);
            this.Txtfourhour.Name = "Txtfourhour";
            this.Txtfourhour.Size = new System.Drawing.Size(108, 26);
            this.Txtfourhour.TabIndex = 20;
            this.Txtfourhour.TextChanged += new System.EventHandler(this.Txtfourhour_TextChanged);
            this.Txtfourhour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFourHr_KeyPress);
            // 
            // Onehour
            // 
            this.Onehour.AutoSize = true;
            this.Onehour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onehour.Location = new System.Drawing.Point(33, 114);
            this.Onehour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Onehour.Name = "Onehour";
            this.Onehour.Size = new System.Drawing.Size(67, 19);
            this.Onehour.TabIndex = 21;
            this.Onehour.Text = "1 Hour:";
            // 
            // threehour
            // 
            this.threehour.AutoSize = true;
            this.threehour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threehour.Location = new System.Drawing.Point(25, 228);
            this.threehour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threehour.Name = "threehour";
            this.threehour.Size = new System.Drawing.Size(75, 19);
            this.threehour.TabIndex = 22;
            this.threehour.Text = "3 Hours:";
            // 
            // fourhour
            // 
            this.fourhour.AutoSize = true;
            this.fourhour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourhour.Location = new System.Drawing.Point(25, 285);
            this.fourhour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fourhour.Name = "fourhour";
            this.fourhour.Size = new System.Drawing.Size(75, 19);
            this.fourhour.TabIndex = 23;
            this.fourhour.Text = "4 Hours:";
            // 
            // wholeday
            // 
            this.wholeday.AutoSize = true;
            this.wholeday.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeday.Location = new System.Drawing.Point(2, 339);
            this.wholeday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wholeday.Name = "wholeday";
            this.wholeday.Size = new System.Drawing.Size(98, 19);
            this.wholeday.TabIndex = 24;
            this.wholeday.Text = "Whole Day";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.twohour);
            this.panel1.Controls.Add(this.Txtwholeday);
            this.panel1.Controls.Add(this.UpdateTicketRate);
            this.panel1.Controls.Add(this.btnupdaterate);
            this.panel1.Controls.Add(this.wholeday);
            this.panel1.Controls.Add(this.Txtfourhour);
            this.panel1.Controls.Add(this.fourhour);
            this.panel1.Controls.Add(this.Txtthreehour);
            this.panel1.Controls.Add(this.threehour);
            this.panel1.Controls.Add(this.Txttwohour);
            this.panel1.Controls.Add(this.Onehour);
            this.panel1.Controls.Add(this.Txtonehour);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.cbCustomerType);
            this.panel1.Location = new System.Drawing.Point(3, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 429);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // twohour
            // 
            this.twohour.AutoSize = true;
            this.twohour.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twohour.Location = new System.Drawing.Point(25, 171);
            this.twohour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.twohour.Name = "twohour";
            this.twohour.Size = new System.Drawing.Size(75, 19);
            this.twohour.TabIndex = 28;
            this.twohour.Text = "2 Hours:";
            this.twohour.Click += new System.EventHandler(this.label9_Click);
            // 
            // Txtwholeday
            // 
            this.Txtwholeday.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtwholeday.Location = new System.Drawing.Point(108, 337);
            this.Txtwholeday.Margin = new System.Windows.Forms.Padding(4);
            this.Txtwholeday.Name = "Txtwholeday";
            this.Txtwholeday.Size = new System.Drawing.Size(108, 26);
            this.Txtwholeday.TabIndex = 27;
            this.Txtwholeday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiveHr_KeyPress);
            // 
            // UpdateTicketRate
            // 
            this.UpdateTicketRate.AutoSize = true;
            this.UpdateTicketRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTicketRate.ForeColor = System.Drawing.Color.Black;
            this.UpdateTicketRate.Location = new System.Drawing.Point(37, 15);
            this.UpdateTicketRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateTicketRate.Name = "UpdateTicketRate";
            this.UpdateTicketRate.Size = new System.Drawing.Size(194, 23);
            this.UpdateTicketRate.TabIndex = 26;
            this.UpdateTicketRate.Text = "Update Ticket Rate";
            // 
            // Lbldmkrecreationcentre
            // 
            this.Lbldmkrecreationcentre.AutoSize = true;
            this.Lbldmkrecreationcentre.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbldmkrecreationcentre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbldmkrecreationcentre.Location = new System.Drawing.Point(326, 19);
            this.Lbldmkrecreationcentre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbldmkrecreationcentre.Name = "Lbldmkrecreationcentre";
            this.Lbldmkrecreationcentre.Size = new System.Drawing.Size(515, 34);
            this.Lbldmkrecreationcentre.TabIndex = 27;
            this.Lbldmkrecreationcentre.Text = "\" Damak Recreation Centre System \" ";
            // 
            // behindTicketRatePanel
            // 
            this.behindTicketRatePanel.BackColor = System.Drawing.Color.White;
            this.behindTicketRatePanel.Controls.Add(this.Dgdisplayticketrate);
            this.behindTicketRatePanel.Controls.Add(this.Ticketrate);
            this.behindTicketRatePanel.Location = new System.Drawing.Point(254, 71);
            this.behindTicketRatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.behindTicketRatePanel.Name = "behindTicketRatePanel";
            this.behindTicketRatePanel.Size = new System.Drawing.Size(898, 315);
            this.behindTicketRatePanel.TabIndex = 28;
            this.behindTicketRatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AdminGoback
            // 
            this.AdminGoback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AdminGoback.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminGoback.Location = new System.Drawing.Point(271, 457);
            this.AdminGoback.Name = "AdminGoback";
            this.AdminGoback.Size = new System.Drawing.Size(93, 43);
            this.AdminGoback.TabIndex = 30;
            this.AdminGoback.Text = "Go back";
            this.AdminGoback.UseVisualStyleBackColor = false;
            this.AdminGoback.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1162, 503);
            this.Controls.Add(this.Lbladminpanel);
            this.Controls.Add(this.Lbldmkrecreationcentre);
            this.Controls.Add(this.AdminGoback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.behindTicketRatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed_1);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgdisplayticketrate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.behindTicketRatePanel.ResumeLayout(false);
            this.behindTicketRatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbladminpanel;
        private System.Windows.Forms.DataGridView Dgdisplayticketrate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnupdaterate;
        private System.Windows.Forms.Label Ticketrate;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox Txtonehour;
        private System.Windows.Forms.TextBox Txttwohour;
        private System.Windows.Forms.TextBox Txtthreehour;
        private System.Windows.Forms.TextBox Txtfourhour;
        private System.Windows.Forms.Label Onehour;
        private System.Windows.Forms.Label threehour;
        private System.Windows.Forms.Label fourhour;
        private System.Windows.Forms.Label wholeday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UpdateTicketRate;
        private System.Windows.Forms.Label twohour;
        private System.Windows.Forms.TextBox Txtwholeday;
        private System.Windows.Forms.Label Lbldmkrecreationcentre;
        private System.Windows.Forms.Panel behindTicketRatePanel;
        private System.Windows.Forms.Button AdminGoback;
    }
}