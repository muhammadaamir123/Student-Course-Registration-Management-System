namespace Project
{
    partial class AddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.CourseIDtxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CourseTitle = new MetroFramework.Controls.MetroLabel();
            this.CourseTitletxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Technology = new MetroFramework.Controls.MetroLabel();
            this.Semestercombo = new MetroFramework.Controls.MetroComboBox();
            this.Techcombo = new MetroFramework.Controls.MetroComboBox();
            this._C__ProjectDataSet6 = new Project._C__ProjectDataSet6();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techTableAdapter = new Project._C__ProjectDataSet6TableAdapters.TechTableAdapter();
            this.techBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Addbtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseIDtxt
            // 
            // 
            // 
            // 
            this.CourseIDtxt.CustomButton.Image = null;
            this.CourseIDtxt.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.CourseIDtxt.CustomButton.Name = "";
            this.CourseIDtxt.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CourseIDtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseIDtxt.CustomButton.TabIndex = 1;
            this.CourseIDtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseIDtxt.CustomButton.UseSelectable = true;
            this.CourseIDtxt.CustomButton.Visible = false;
            this.CourseIDtxt.Lines = new string[] {
        "CourseID"};
            this.CourseIDtxt.Location = new System.Drawing.Point(185, 125);
            this.CourseIDtxt.MaxLength = 32767;
            this.CourseIDtxt.Name = "CourseIDtxt";
            this.CourseIDtxt.PasswordChar = '\0';
            this.CourseIDtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CourseIDtxt.SelectedText = "";
            this.CourseIDtxt.SelectionLength = 0;
            this.CourseIDtxt.SelectionStart = 0;
            this.CourseIDtxt.ShortcutsEnabled = true;
            this.CourseIDtxt.Size = new System.Drawing.Size(125, 24);
            this.CourseIDtxt.TabIndex = 0;
            this.CourseIDtxt.Text = "CourseID";
            this.CourseIDtxt.UseSelectable = true;
            this.CourseIDtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseIDtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 125);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CourseID";
            // 
            // CourseTitle
            // 
            this.CourseTitle.AutoSize = true;
            this.CourseTitle.Location = new System.Drawing.Point(40, 167);
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.Size = new System.Drawing.Size(78, 19);
            this.CourseTitle.TabIndex = 3;
            this.CourseTitle.Text = "Course Title";
            // 
            // CourseTitletxt
            // 
            // 
            // 
            // 
            this.CourseTitletxt.CustomButton.Image = null;
            this.CourseTitletxt.CustomButton.Location = new System.Drawing.Point(103, 2);
            this.CourseTitletxt.CustomButton.Name = "";
            this.CourseTitletxt.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.CourseTitletxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CourseTitletxt.CustomButton.TabIndex = 1;
            this.CourseTitletxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CourseTitletxt.CustomButton.UseSelectable = true;
            this.CourseTitletxt.CustomButton.Visible = false;
            this.CourseTitletxt.Lines = new string[] {
        "Course TItle"};
            this.CourseTitletxt.Location = new System.Drawing.Point(185, 167);
            this.CourseTitletxt.MaxLength = 32767;
            this.CourseTitletxt.Name = "CourseTitletxt";
            this.CourseTitletxt.PasswordChar = '\0';
            this.CourseTitletxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CourseTitletxt.SelectedText = "";
            this.CourseTitletxt.SelectionLength = 0;
            this.CourseTitletxt.SelectionStart = 0;
            this.CourseTitletxt.ShortcutsEnabled = true;
            this.CourseTitletxt.Size = new System.Drawing.Size(125, 24);
            this.CourseTitletxt.TabIndex = 2;
            this.CourseTitletxt.Text = "Course TItle";
            this.CourseTitletxt.UseSelectable = true;
            this.CourseTitletxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CourseTitletxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Semester";
            // 
            // Technology
            // 
            this.Technology.AutoSize = true;
            this.Technology.Location = new System.Drawing.Point(40, 256);
            this.Technology.Name = "Technology";
            this.Technology.Size = new System.Drawing.Size(74, 19);
            this.Technology.TabIndex = 7;
            this.Technology.Text = "Technology";
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
            this.Semestercombo.Location = new System.Drawing.Point(185, 210);
            this.Semestercombo.Name = "Semestercombo";
            this.Semestercombo.Size = new System.Drawing.Size(121, 29);
            this.Semestercombo.TabIndex = 8;
            this.Semestercombo.UseSelectable = true;
            // 
            // Techcombo
            // 
            this.Techcombo.DataSource = this.techBindingSource1;
            this.Techcombo.DisplayMember = "TechID";
            this.Techcombo.FormattingEnabled = true;
            this.Techcombo.ItemHeight = 23;
            this.Techcombo.Location = new System.Drawing.Point(185, 256);
            this.Techcombo.Name = "Techcombo";
            this.Techcombo.Size = new System.Drawing.Size(121, 29);
            this.Techcombo.TabIndex = 9;
            this.Techcombo.UseSelectable = true;
            this.Techcombo.ValueMember = "Technology";
            // 
            // _C__ProjectDataSet6
            // 
            this._C__ProjectDataSet6.DataSetName = "_C__ProjectDataSet6";
            this._C__ProjectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this._C__ProjectDataSet6;
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // techBindingSource1
            // 
            this.techBindingSource1.DataMember = "Tech";
            this.techBindingSource1.DataSource = this._C__ProjectDataSet6;
            // 
            // Addbtn
            // 
            this.Addbtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Addbtn.Location = new System.Drawing.Point(40, 359);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 10;
            this.Addbtn.Text = "Add Course";
            this.Addbtn.UseSelectable = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 428);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Techcombo);
            this.Controls.Add(this.Semestercombo);
            this.Controls.Add(this.Technology);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CourseTitle);
            this.Controls.Add(this.CourseTitletxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CourseIDtxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "AddCourse";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox CourseIDtxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel CourseTitle;
        private MetroFramework.Controls.MetroTextBox CourseTitletxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Technology;
        private MetroFramework.Controls.MetroComboBox Semestercombo;
        private MetroFramework.Controls.MetroComboBox Techcombo;
        private _C__ProjectDataSet6 _C__ProjectDataSet6;
        private System.Windows.Forms.BindingSource techBindingSource;
        private _C__ProjectDataSet6TableAdapters.TechTableAdapter techTableAdapter;
        private System.Windows.Forms.BindingSource techBindingSource1;
        private MetroFramework.Controls.MetroButton Addbtn;

    }
}