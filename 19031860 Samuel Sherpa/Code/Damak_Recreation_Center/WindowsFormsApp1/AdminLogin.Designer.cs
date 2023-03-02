
namespace WindowsFormsApp1
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.button1 = new System.Windows.Forms.Button();
            this.asadmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtadminpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminpicturebox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Go back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // asadmin
            // 
            this.asadmin.BackColor = System.Drawing.Color.Plum;
            this.asadmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asadmin.Location = new System.Drawing.Point(418, 103);
            this.asadmin.Name = "asadmin";
            this.asadmin.Size = new System.Drawing.Size(51, 32);
            this.asadmin.TabIndex = 12;
            this.asadmin.Text = "OK";
            this.asadmin.UseVisualStyleBackColor = false;
            this.asadmin.Click += new System.EventHandler(this.asadmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "hint: admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txtadminpassword
            // 
            this.Txtadminpassword.Location = new System.Drawing.Point(382, 75);
            this.Txtadminpassword.Name = "Txtadminpassword";
            this.Txtadminpassword.PasswordChar = '*';
            this.Txtadminpassword.Size = new System.Drawing.Size(124, 22);
            this.Txtadminpassword.TabIndex = 9;
            this.Txtadminpassword.TextChanged += new System.EventHandler(this.Txtadminpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Passcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminpicturebox
            // 
            this.adminpicturebox.Image = global::WindowsFormsApp1.Properties.Resources.admin;
            this.adminpicturebox.Location = new System.Drawing.Point(0, -1);
            this.adminpicturebox.Name = "adminpicturebox";
            this.adminpicturebox.Size = new System.Drawing.Size(316, 221);
            this.adminpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.adminpicturebox.TabIndex = 10;
            this.adminpicturebox.TabStop = false;
            this.adminpicturebox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.asadmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminpicturebox);
            this.Controls.Add(this.Txtadminpassword);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button asadmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox adminpicturebox;
        private System.Windows.Forms.TextBox Txtadminpassword;
        private System.Windows.Forms.Label label1;
    }
}