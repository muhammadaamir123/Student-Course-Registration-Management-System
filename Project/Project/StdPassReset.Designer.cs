namespace Project
{
    partial class StdPassReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StdPassReset));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Passtext = new MetroFramework.Controls.MetroTextBox();
            this.Checkbtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Error1 = new MetroFramework.Controls.MetroLabel();
            this.Password = new MetroFramework.Controls.MetroButton();
            this.RPasstext = new MetroFramework.Controls.MetroTextBox();
            this.rePass = new MetroFramework.Controls.MetroLabel();
            this.NPasstext = new MetroFramework.Controls.MetroTextBox();
            this.newPass = new MetroFramework.Controls.MetroLabel();
            this.Error = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Old Password";
            // 
            // Passtext
            // 
            // 
            // 
            // 
            this.Passtext.CustomButton.Image = null;
            this.Passtext.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.Passtext.CustomButton.Name = "";
            this.Passtext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Passtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passtext.CustomButton.TabIndex = 1;
            this.Passtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passtext.CustomButton.UseSelectable = true;
            this.Passtext.CustomButton.Visible = false;
            this.Passtext.Lines = new string[] {
        "Password"};
            this.Passtext.Location = new System.Drawing.Point(167, 122);
            this.Passtext.MaxLength = 32767;
            this.Passtext.Name = "Passtext";
            this.Passtext.PasswordChar = '\0';
            this.Passtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passtext.SelectedText = "";
            this.Passtext.SelectionLength = 0;
            this.Passtext.SelectionStart = 0;
            this.Passtext.ShortcutsEnabled = true;
            this.Passtext.Size = new System.Drawing.Size(112, 23);
            this.Passtext.TabIndex = 1;
            this.Passtext.Text = "Password";
            this.Passtext.UseSelectable = true;
            this.Passtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passtext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Checkbtn
            // 
            this.Checkbtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Checkbtn.Location = new System.Drawing.Point(342, 122);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(97, 23);
            this.Checkbtn.TabIndex = 2;
            this.Checkbtn.Text = "Check Password";
            this.Checkbtn.UseSelectable = true;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Error1);
            this.metroPanel1.Controls.Add(this.Password);
            this.metroPanel1.Controls.Add(this.RPasstext);
            this.metroPanel1.Controls.Add(this.rePass);
            this.metroPanel1.Controls.Add(this.NPasstext);
            this.metroPanel1.Controls.Add(this.newPass);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(44, 176);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(259, 134);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // Error1
            // 
            this.Error1.AutoSize = true;
            this.Error1.Location = new System.Drawing.Point(104, 75);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(0, 0);
            this.Error1.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Password.Location = new System.Drawing.Point(66, 108);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(97, 23);
            this.Password.TabIndex = 4;
            this.Password.Text = "Reset Password";
            this.Password.UseSelectable = true;
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // RPasstext
            // 
            // 
            // 
            // 
            this.RPasstext.CustomButton.Image = null;
            this.RPasstext.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.RPasstext.CustomButton.Name = "";
            this.RPasstext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RPasstext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RPasstext.CustomButton.TabIndex = 1;
            this.RPasstext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RPasstext.CustomButton.UseSelectable = true;
            this.RPasstext.CustomButton.Visible = false;
            this.RPasstext.Lines = new string[] {
        "Password"};
            this.RPasstext.Location = new System.Drawing.Point(126, 46);
            this.RPasstext.MaxLength = 32767;
            this.RPasstext.Name = "RPasstext";
            this.RPasstext.PasswordChar = '\0';
            this.RPasstext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RPasstext.SelectedText = "";
            this.RPasstext.SelectionLength = 0;
            this.RPasstext.SelectionStart = 0;
            this.RPasstext.ShortcutsEnabled = true;
            this.RPasstext.Size = new System.Drawing.Size(112, 23);
            this.RPasstext.TabIndex = 5;
            this.RPasstext.Text = "Password";
            this.RPasstext.UseSelectable = true;
            this.RPasstext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RPasstext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rePass
            // 
            this.rePass.AutoSize = true;
            this.rePass.Location = new System.Drawing.Point(3, 46);
            this.rePass.Name = "rePass";
            this.rePass.Size = new System.Drawing.Size(84, 19);
            this.rePass.TabIndex = 4;
            this.rePass.Text = "Re-Password";
            // 
            // NPasstext
            // 
            // 
            // 
            // 
            this.NPasstext.CustomButton.Image = null;
            this.NPasstext.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.NPasstext.CustomButton.Name = "";
            this.NPasstext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NPasstext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NPasstext.CustomButton.TabIndex = 1;
            this.NPasstext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NPasstext.CustomButton.UseSelectable = true;
            this.NPasstext.CustomButton.Visible = false;
            this.NPasstext.Lines = new string[] {
        "Password"};
            this.NPasstext.Location = new System.Drawing.Point(126, 13);
            this.NPasstext.MaxLength = 32767;
            this.NPasstext.Name = "NPasstext";
            this.NPasstext.PasswordChar = '\0';
            this.NPasstext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NPasstext.SelectedText = "";
            this.NPasstext.SelectionLength = 0;
            this.NPasstext.SelectionStart = 0;
            this.NPasstext.ShortcutsEnabled = true;
            this.NPasstext.Size = new System.Drawing.Size(112, 23);
            this.NPasstext.TabIndex = 3;
            this.NPasstext.Text = "Password";
            this.NPasstext.UseSelectable = true;
            this.NPasstext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NPasstext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // newPass
            // 
            this.newPass.AutoSize = true;
            this.newPass.Location = new System.Drawing.Point(3, 13);
            this.newPass.Name = "newPass";
            this.newPass.Size = new System.Drawing.Size(93, 19);
            this.newPass.TabIndex = 2;
            this.newPass.Text = "New Password";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(110, 148);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 0);
            this.Error.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.icons8_Restart_48px;
            this.pictureBox1.Location = new System.Drawing.Point(545, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StdPassReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "StdPassReset";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password Reset";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Passtext;
        private MetroFramework.Controls.MetroButton Checkbtn;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox RPasstext;
        private MetroFramework.Controls.MetroLabel rePass;
        private MetroFramework.Controls.MetroTextBox NPasstext;
        private MetroFramework.Controls.MetroLabel newPass;
        private MetroFramework.Controls.MetroButton Password;
        private MetroFramework.Controls.MetroLabel Error;
        private MetroFramework.Controls.MetroLabel Error1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}