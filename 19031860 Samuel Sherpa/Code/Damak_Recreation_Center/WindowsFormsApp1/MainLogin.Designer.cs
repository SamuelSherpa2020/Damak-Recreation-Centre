
namespace WindowsFormsApp1
{
    partial class MainLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.loginexit = new System.Windows.Forms.Button();
            this.asemployee = new System.Windows.Forms.Button();
            this.asadmin = new System.Windows.Forms.Button();
            this.readytoLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginexit
            // 
            this.loginexit.BackColor = System.Drawing.Color.LightPink;
            this.loginexit.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginexit.Location = new System.Drawing.Point(817, 421);
            this.loginexit.Name = "loginexit";
            this.loginexit.Size = new System.Drawing.Size(63, 32);
            this.loginexit.TabIndex = 10;
            this.loginexit.Text = "Exit";
            this.loginexit.UseVisualStyleBackColor = false;
            this.loginexit.Click += new System.EventHandler(this.loginexit_Click);
            // 
            // asemployee
            // 
            this.asemployee.BackColor = System.Drawing.Color.Plum;
            this.asemployee.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asemployee.Location = new System.Drawing.Point(715, 169);
            this.asemployee.Name = "asemployee";
            this.asemployee.Size = new System.Drawing.Size(113, 32);
            this.asemployee.TabIndex = 9;
            this.asemployee.Text = "As Staff";
            this.asemployee.UseVisualStyleBackColor = false;
            this.asemployee.Click += new System.EventHandler(this.asemployee_Click);
            // 
            // asadmin
            // 
            this.asadmin.BackColor = System.Drawing.Color.Plum;
            this.asadmin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asadmin.Location = new System.Drawing.Point(571, 169);
            this.asadmin.Name = "asadmin";
            this.asadmin.Size = new System.Drawing.Size(114, 32);
            this.asadmin.TabIndex = 8;
            this.asadmin.Text = "As Admin";
            this.asadmin.UseVisualStyleBackColor = false;
            this.asadmin.Click += new System.EventHandler(this.asadmin_Click);
            // 
            // readytoLogin
            // 
            this.readytoLogin.AutoSize = true;
            this.readytoLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readytoLogin.Location = new System.Drawing.Point(614, 105);
            this.readytoLogin.Name = "readytoLogin";
            this.readytoLogin.Size = new System.Drawing.Size(156, 23);
            this.readytoLogin.TabIndex = 7;
            this.readytoLogin.Text = "Ready to Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Damak_Recreation_Centre;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 463);
            this.Controls.Add(this.loginexit);
            this.Controls.Add(this.asemployee);
            this.Controls.Add(this.asadmin);
            this.Controls.Add(this.readytoLogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLogin";
            this.Load += new System.EventHandler(this.MainLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginexit;
        private System.Windows.Forms.Button asemployee;
        private System.Windows.Forms.Button asadmin;
        private System.Windows.Forms.Label readytoLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}