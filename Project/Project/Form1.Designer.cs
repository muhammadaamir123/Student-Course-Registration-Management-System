namespace Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Passwordtext = new MetroFramework.Controls.MetroTextBox();
            this.Usernametext = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.Username = new MetroFramework.Controls.MetroLabel();
            this.Error = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(110, 446);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(78, 19);
            this.metroLink1.TabIndex = 40;
            this.metroLink1.Text = "Add New";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(90, 377);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(128, 39);
            this.metroButton1.TabIndex = 39;
            this.metroButton1.Text = "Log In";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Passwordtext
            // 
            // 
            // 
            // 
            this.Passwordtext.CustomButton.Image = null;
            this.Passwordtext.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.Passwordtext.CustomButton.Name = "";
            this.Passwordtext.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Passwordtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Passwordtext.CustomButton.TabIndex = 1;
            this.Passwordtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Passwordtext.CustomButton.UseSelectable = true;
            this.Passwordtext.CustomButton.Visible = false;
            this.Passwordtext.Lines = new string[0];
            this.Passwordtext.Location = new System.Drawing.Point(71, 322);
            this.Passwordtext.MaxLength = 32767;
            this.Passwordtext.Name = "Passwordtext";
            this.Passwordtext.PasswordChar = '\0';
            this.Passwordtext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Passwordtext.SelectedText = "";
            this.Passwordtext.SelectionLength = 0;
            this.Passwordtext.SelectionStart = 0;
            this.Passwordtext.ShortcutsEnabled = true;
            this.Passwordtext.Size = new System.Drawing.Size(166, 25);
            this.Passwordtext.TabIndex = 38;
            this.Passwordtext.UseSelectable = true;
            this.Passwordtext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Passwordtext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Usernametext
            // 
            this.Usernametext.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            // 
            // 
            // 
            this.Usernametext.CustomButton.Image = null;
            this.Usernametext.CustomButton.Location = new System.Drawing.Point(142, 1);
            this.Usernametext.CustomButton.Name = "";
            this.Usernametext.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Usernametext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Usernametext.CustomButton.TabIndex = 1;
            this.Usernametext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Usernametext.CustomButton.UseSelectable = true;
            this.Usernametext.CustomButton.Visible = false;
            this.Usernametext.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.Usernametext.Lines = new string[0];
            this.Usernametext.Location = new System.Drawing.Point(71, 212);
            this.Usernametext.MaxLength = 32767;
            this.Usernametext.Name = "Usernametext";
            this.Usernametext.PasswordChar = '\0';
            this.Usernametext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Usernametext.SelectedText = "";
            this.Usernametext.SelectionLength = 0;
            this.Usernametext.SelectionStart = 0;
            this.Usernametext.ShortcutsEnabled = true;
            this.Usernametext.Size = new System.Drawing.Size(166, 25);
            this.Usernametext.TabIndex = 37;
            this.Usernametext.UseSelectable = true;
            this.Usernametext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Usernametext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Password.Location = new System.Drawing.Point(113, 267);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 25);
            this.Password.TabIndex = 36;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Username.Location = new System.Drawing.Point(106, 157);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 25);
            this.Username.TabIndex = 35;
            this.Username.Text = "User Name";
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(48, 354);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 0);
            this.Error.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 515);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Passwordtext);
            this.Controls.Add(this.Usernametext);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox Passwordtext;
        private MetroFramework.Controls.MetroTextBox Usernametext;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroLabel Username;
        private MetroFramework.Controls.MetroLabel Error;
    }
}

