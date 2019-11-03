namespace Project
{
    partial class UpdateCourse
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCourse));
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Technology = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CourseTitle = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Techcombo = new MetroFramework.Controls.MetroComboBox();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__ProjectDataSet6 = new Project._C__ProjectDataSet6();
            this.Semestercombo = new MetroFramework.Controls.MetroComboBox();
            this.CourseTitletxt = new MetroFramework.Controls.MetroTextBox();
            this.CourseIDtxt = new MetroFramework.Controls.MetroTextBox();
            this.Updatebtn = new MetroFramework.Controls.MetroButton();
            this.techTableAdapter = new Project._C__ProjectDataSet6TableAdapters.TechTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 91);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(687, 187);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Technology
            // 
            this.Technology.AutoSize = true;
            this.Technology.Location = new System.Drawing.Point(55, 444);
            this.Technology.Name = "Technology";
            this.Technology.Size = new System.Drawing.Size(74, 19);
            this.Technology.TabIndex = 11;
            this.Technology.Text = "Technology";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 398);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Semester";
            // 
            // CourseTitle
            // 
            this.CourseTitle.AutoSize = true;
            this.CourseTitle.Location = new System.Drawing.Point(55, 355);
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.Size = new System.Drawing.Size(78, 19);
            this.CourseTitle.TabIndex = 9;
            this.CourseTitle.Text = "Course Title";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(55, 313);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "CourseID";
            // 
            // Techcombo
            // 
            this.Techcombo.DataSource = this.techBindingSource;
            this.Techcombo.DisplayMember = "TechID";
            this.Techcombo.FormattingEnabled = true;
            this.Techcombo.ItemHeight = 23;
            this.Techcombo.Location = new System.Drawing.Point(207, 439);
            this.Techcombo.Name = "Techcombo";
            this.Techcombo.Size = new System.Drawing.Size(184, 29);
            this.Techcombo.TabIndex = 15;
            this.Techcombo.UseSelectable = true;
            this.Techcombo.ValueMember = "Technology";
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this._C__ProjectDataSet6;
            // 
            // _C__ProjectDataSet6
            // 
            this._C__ProjectDataSet6.DataSetName = "_C__ProjectDataSet6";
            this._C__ProjectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Semestercombo
            // 
            this.Semestercombo.FormattingEnabled = true;
            this.Semestercombo.ItemHeight = 23;
            this.Semestercombo.Items.AddRange(new object[] {
            "Semester1",
            "Semester2",
            "Semester3",
            "Semester4",
            "Semester5",
            "Semester6",
            "Semester7",
            "Semester8"});
            this.Semestercombo.Location = new System.Drawing.Point(207, 393);
            this.Semestercombo.Name = "Semestercombo";
            this.Semestercombo.Size = new System.Drawing.Size(184, 29);
            this.Semestercombo.TabIndex = 14;
            this.Semestercombo.UseSelectable = true;
            // 
            // CourseTitletxt
            // 
            // 
            // 
            // 
            this.CourseTitletxt.CustomButton.Image = null;
            this.CourseTitletxt.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.CourseTitletxt.CustomButton.Name = "";
            this.CourseTitletxt.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CourseTitletxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseTitletxt.CustomButton.TabIndex = 1;
            this.CourseTitletxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseTitletxt.CustomButton.UseSelectable = true;
            this.CourseTitletxt.CustomButton.Visible = false;
            this.CourseTitletxt.Lines = new string[] {
        "Course TItle"};
            this.CourseTitletxt.Location = new System.Drawing.Point(207, 350);
            this.CourseTitletxt.MaxLength = 32767;
            this.CourseTitletxt.Name = "CourseTitletxt";
            this.CourseTitletxt.PasswordChar = '\0';
            this.CourseTitletxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CourseTitletxt.SelectedText = "";
            this.CourseTitletxt.SelectionLength = 0;
            this.CourseTitletxt.SelectionStart = 0;
            this.CourseTitletxt.ShortcutsEnabled = true;
            this.CourseTitletxt.Size = new System.Drawing.Size(184, 24);
            this.CourseTitletxt.TabIndex = 13;
            this.CourseTitletxt.Text = "Course TItle";
            this.CourseTitletxt.UseSelectable = true;
            this.CourseTitletxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseTitletxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CourseIDtxt
            // 
            // 
            // 
            // 
            this.CourseIDtxt.CustomButton.Image = null;
            this.CourseIDtxt.CustomButton.Location = new System.Drawing.Point(162, 2);
            this.CourseIDtxt.CustomButton.Name = "";
            this.CourseIDtxt.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CourseIDtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseIDtxt.CustomButton.TabIndex = 1;
            this.CourseIDtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseIDtxt.CustomButton.UseSelectable = true;
            this.CourseIDtxt.CustomButton.Visible = false;
            this.CourseIDtxt.Lines = new string[] {
        "CourseID"};
            this.CourseIDtxt.Location = new System.Drawing.Point(207, 308);
            this.CourseIDtxt.MaxLength = 32767;
            this.CourseIDtxt.Name = "CourseIDtxt";
            this.CourseIDtxt.PasswordChar = '\0';
            this.CourseIDtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CourseIDtxt.SelectedText = "";
            this.CourseIDtxt.SelectionLength = 0;
            this.CourseIDtxt.SelectionStart = 0;
            this.CourseIDtxt.ShortcutsEnabled = true;
            this.CourseIDtxt.Size = new System.Drawing.Size(184, 24);
            this.CourseIDtxt.TabIndex = 12;
            this.CourseIDtxt.Text = "CourseID";
            this.CourseIDtxt.UseSelectable = true;
            this.CourseIDtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseIDtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Updatebtn
            // 
            this.Updatebtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Updatebtn.Location = new System.Drawing.Point(280, 486);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(98, 23);
            this.Updatebtn.TabIndex = 16;
            this.Updatebtn.Text = "Update Course";
            this.Updatebtn.UseSelectable = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 521);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Techcombo);
            this.Controls.Add(this.Semestercombo);
            this.Controls.Add(this.CourseTitletxt);
            this.Controls.Add(this.CourseIDtxt);
            this.Controls.Add(this.Technology);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CourseTitle);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "UpdateCourse";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Update Course";
            this.Load += new System.EventHandler(this.UpdateCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroLabel Technology;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel CourseTitle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox Techcombo;
        private MetroFramework.Controls.MetroComboBox Semestercombo;
        private MetroFramework.Controls.MetroTextBox CourseTitletxt;
        private MetroFramework.Controls.MetroTextBox CourseIDtxt;
        private MetroFramework.Controls.MetroButton Updatebtn;
        private _C__ProjectDataSet6 _C__ProjectDataSet6;
        private System.Windows.Forms.BindingSource techBindingSource;
        private _C__ProjectDataSet6TableAdapters.TechTableAdapter techTableAdapter;
    }
}