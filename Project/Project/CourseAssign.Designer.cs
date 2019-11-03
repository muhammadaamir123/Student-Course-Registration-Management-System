namespace Project
{
    partial class CourseAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAssign));
            this.Course = new MetroFramework.Controls.MetroLabel();
            this.CourseCombo = new MetroFramework.Controls.MetroComboBox();
            this.techCombo = new MetroFramework.Controls.MetroComboBox();
            this.techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__ProjectDataSet3 = new Project._C__ProjectDataSet3();
            this.tech = new MetroFramework.Controls.MetroLabel();
            this.Insert = new MetroFramework.Controls.MetroButton();
            this.techTableAdapter = new Project._C__ProjectDataSet3TableAdapters.TechTableAdapter();
            this.projectDataSet7 = new Project.ProjectDataSet7();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Project.ProjectDataSet7TableAdapters.CourseTableAdapter();
            this._C__ProjectDataSet4 = new Project._C__ProjectDataSet4();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter1 = new Project._C__ProjectDataSet4TableAdapters.CourseTableAdapter();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Semestercombo = new MetroFramework.Controls.MetroComboBox();
            this.semester = new MetroFramework.Controls.MetroLabel();
            this.userDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C__ProjectDataSet5 = new Project._C__ProjectDataSet5();
            this.Faculty = new MetroFramework.Controls.MetroLabel();
            this.userDataTableAdapter = new Project._C__ProjectDataSet5TableAdapters.UserDataTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.facultytext = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(15, 27);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(50, 19);
            this.Course.TabIndex = 0;
            this.Course.Text = "Course";
            // 
            // CourseCombo
            // 
            this.CourseCombo.FormattingEnabled = true;
            this.CourseCombo.ItemHeight = 23;
            this.CourseCombo.Location = new System.Drawing.Point(153, 17);
            this.CourseCombo.Name = "CourseCombo";
            this.CourseCombo.Size = new System.Drawing.Size(213, 29);
            this.CourseCombo.TabIndex = 1;
            this.CourseCombo.UseSelectable = true;
            // 
            // techCombo
            // 
            this.techCombo.DataSource = this.techBindingSource;
            this.techCombo.DisplayMember = "TechID";
            this.techCombo.FormattingEnabled = true;
            this.techCombo.ItemHeight = 23;
            this.techCombo.Location = new System.Drawing.Point(194, 277);
            this.techCombo.Name = "techCombo";
            this.techCombo.Size = new System.Drawing.Size(121, 29);
            this.techCombo.TabIndex = 3;
            this.techCombo.UseSelectable = true;
            this.techCombo.ValueMember = "Technology";
            // 
            // techBindingSource
            // 
            this.techBindingSource.DataMember = "Tech";
            this.techBindingSource.DataSource = this._C__ProjectDataSet3;
            // 
            // _C__ProjectDataSet3
            // 
            this._C__ProjectDataSet3.DataSetName = "_C__ProjectDataSet3";
            this._C__ProjectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tech
            // 
            this.tech.AutoSize = true;
            this.tech.Location = new System.Drawing.Point(56, 287);
            this.tech.Name = "tech";
            this.tech.Size = new System.Drawing.Size(74, 19);
            this.tech.TabIndex = 2;
            this.tech.Text = "Technology";
            // 
            // Insert
            // 
            this.Insert.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.Insert.Location = new System.Drawing.Point(56, 469);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(85, 33);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Assign Course";
            this.Insert.UseSelectable = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // techTableAdapter
            // 
            this.techTableAdapter.ClearBeforeFill = true;
            // 
            // projectDataSet7
            // 
            this.projectDataSet7.DataSetName = "ProjectDataSet7";
            this.projectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.projectDataSet7;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // _C__ProjectDataSet4
            // 
            this._C__ProjectDataSet4.DataSetName = "_C__ProjectDataSet4";
            this._C__ProjectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this._C__ProjectDataSet4;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Course);
            this.metroPanel1.Controls.Add(this.CourseCombo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(43, 357);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(389, 75);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(372, 320);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Next";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            this.Semestercombo.Location = new System.Drawing.Point(194, 314);
            this.Semestercombo.Name = "Semestercombo";
            this.Semestercombo.Size = new System.Drawing.Size(121, 29);
            this.Semestercombo.TabIndex = 8;
            this.Semestercombo.UseSelectable = true;
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(56, 324);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(63, 19);
            this.semester.TabIndex = 7;
            this.semester.Text = "Semester";
            // 
            // userDataBindingSource
            // 
            this.userDataBindingSource.DataMember = "UserData";
            this.userDataBindingSource.DataSource = this._C__ProjectDataSet5;
            // 
            // _C__ProjectDataSet5
            // 
            this._C__ProjectDataSet5.DataSetName = "_C__ProjectDataSet5";
            this._C__ProjectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(56, 252);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(48, 19);
            this.Faculty.TabIndex = 9;
            this.Faculty.Text = "Faculty";
            // 
            // userDataTableAdapter
            // 
            this.userDataTableAdapter.ClearBeforeFill = true;
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
            this.metroGrid1.Location = new System.Drawing.Point(23, 72);
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
            this.metroGrid1.Size = new System.Drawing.Size(852, 150);
            this.metroGrid1.TabIndex = 11;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // facultytext
            // 
            // 
            // 
            // 
            this.facultytext.CustomButton.Image = null;
            this.facultytext.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.facultytext.CustomButton.Name = "";
            this.facultytext.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.facultytext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.facultytext.CustomButton.TabIndex = 1;
            this.facultytext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.facultytext.CustomButton.UseSelectable = true;
            this.facultytext.CustomButton.Visible = false;
            this.facultytext.Lines = new string[] {
        "Faculty ID"};
            this.facultytext.Location = new System.Drawing.Point(196, 248);
            this.facultytext.MaxLength = 32767;
            this.facultytext.Name = "facultytext";
            this.facultytext.PasswordChar = '\0';
            this.facultytext.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.facultytext.SelectedText = "";
            this.facultytext.SelectionLength = 0;
            this.facultytext.SelectionStart = 0;
            this.facultytext.ShortcutsEnabled = true;
            this.facultytext.Size = new System.Drawing.Size(119, 23);
            this.facultytext.TabIndex = 12;
            this.facultytext.Text = "Faculty ID";
            this.facultytext.UseSelectable = true;
            this.facultytext.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.facultytext.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = global::Project.Properties.Resources.icons8_Pull_Down_36px;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroLink1.Location = new System.Drawing.Point(835, 37);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(40, 39);
            this.metroLink1.TabIndex = 78;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(118, 26);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::Project.Properties.Resources.icons8_Exit_48px;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // CourseAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 516);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.facultytext);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.Faculty);
            this.Controls.Add(this.Semestercombo);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.techCombo);
            this.Controls.Add(this.tech);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "CourseAssign";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Course Assign";
            this.Load += new System.EventHandler(this.CourseAssign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__ProjectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Course;
        private MetroFramework.Controls.MetroComboBox CourseCombo;
        private MetroFramework.Controls.MetroComboBox techCombo;
        private MetroFramework.Controls.MetroLabel tech;
        private MetroFramework.Controls.MetroButton Insert;
        private _C__ProjectDataSet3 _C__ProjectDataSet3;
        private System.Windows.Forms.BindingSource techBindingSource;
        private _C__ProjectDataSet3TableAdapters.TechTableAdapter techTableAdapter;
        private ProjectDataSet7 projectDataSet7;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private ProjectDataSet7TableAdapters.CourseTableAdapter courseTableAdapter;
        private _C__ProjectDataSet4 _C__ProjectDataSet4;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private _C__ProjectDataSet4TableAdapters.CourseTableAdapter courseTableAdapter1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox Semestercombo;
        private MetroFramework.Controls.MetroLabel semester;
        private MetroFramework.Controls.MetroLabel Faculty;
        private _C__ProjectDataSet5 _C__ProjectDataSet5;
        private System.Windows.Forms.BindingSource userDataBindingSource;
        private _C__ProjectDataSet5TableAdapters.UserDataTableAdapter userDataTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox facultytext;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroContextMenu menu;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}