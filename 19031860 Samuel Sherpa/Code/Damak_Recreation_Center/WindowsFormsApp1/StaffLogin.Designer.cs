
namespace WindowsFormsApp1
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            this.btnstaffgoback = new System.Windows.Forms.Button();
            this.btnstafflogin = new System.Windows.Forms.Button();
            this.Lblhintpassword = new System.Windows.Forms.Label();
            this.staffpicturebox = new System.Windows.Forms.PictureBox();
            this.Txtstaffpassword = new System.Windows.Forms.TextBox();
            this.LblPasscode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.staffpicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstaffgoback
            // 
            this.btnstaffgoback.BackColor = System.Drawing.Color.Plum;
            this.btnstaffgoback.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstaffgoback.Location = new System.Drawing.Point(452, 179);
            this.btnstaffgoback.Name = "btnstaffgoback";
            this.btnstaffgoback.Size = new System.Drawing.Size(91, 32);
            this.btnstaffgoback.TabIndex = 19;
            this.btnstaffgoback.Text = "Go back";
            this.btnstaffgoback.UseVisualStyleBackColor = false;
            this.btnstaffgoback.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnstafflogin
            // 
            this.btnstafflogin.BackColor = System.Drawing.Color.Plum;
            this.btnstafflogin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstafflogin.Location = new System.Drawing.Point(416, 105);
            this.btnstafflogin.Name = "btnstafflogin";
            this.btnstafflogin.Size = new System.Drawing.Size(51, 32);
            this.btnstafflogin.TabIndex = 18;
            this.btnstafflogin.Text = "OK";
            this.btnstafflogin.UseVisualStyleBackColor = false;
            this.btnstafflogin.Click += new System.EventHandler(this.asadmin_Click);
            // 
            // Lblhintpassword
            // 
            this.Lblhintpassword.AutoSize = true;
            this.Lblhintpassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhintpassword.Location = new System.Drawing.Point(320, 187);
            this.Lblhintpassword.Name = "Lblhintpassword";
            this.Lblhintpassword.Size = new System.Drawing.Size(67, 17);
            this.Lblhintpassword.TabIndex = 17;
            this.Lblhintpassword.Text = "hint: staff";
            // 
            // staffpicturebox
            // 
            this.staffpicturebox.Image = global::WindowsFormsApp1.Properties.Resources.employee;
            this.staffpicturebox.Location = new System.Drawing.Point(-2, 1);
            this.staffpicturebox.Name = "staffpicturebox";
            this.staffpicturebox.Size = new System.Drawing.Size(316, 221);
            this.staffpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffpicturebox.TabIndex = 16;
            this.staffpicturebox.TabStop = false;
            // 
            // Txtstaffpassword
            // 
            this.Txtstaffpassword.Location = new System.Drawing.Point(380, 77);
            this.Txtstaffpassword.Name = "Txtstaffpassword";
            this.Txtstaffpassword.PasswordChar = '*';
            this.Txtstaffpassword.Size = new System.Drawing.Size(124, 22);
            this.Txtstaffpassword.TabIndex = 15;
            // 
            // LblPasscode
            // 
            this.LblPasscode.AutoSize = true;
            this.LblPasscode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasscode.Location = new System.Drawing.Point(390, 42);
            this.LblPasscode.Name = "LblPasscode";
            this.LblPasscode.Size = new System.Drawing.Size(105, 23);
            this.LblPasscode.TabIndex = 14;
            this.LblPasscode.Text = "Passcode";
            // 
            // StaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 218);
            this.Controls.Add(this.btnstaffgoback);
            this.Controls.Add(this.btnstafflogin);
            this.Controls.Add(this.Lblhintpassword);
            this.Controls.Add(this.staffpicturebox);
            this.Controls.Add(this.Txtstaffpassword);
            this.Controls.Add(this.LblPasscode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffLogin";
            this.Load += new System.EventHandler(this.StaffLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffpicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstaffgoback;
        private System.Windows.Forms.Button btnstafflogin;
        private System.Windows.Forms.Label Lblhintpassword;
        private System.Windows.Forms.PictureBox staffpicturebox;
        private System.Windows.Forms.TextBox Txtstaffpassword;
        private System.Windows.Forms.Label LblPasscode;
    }
}