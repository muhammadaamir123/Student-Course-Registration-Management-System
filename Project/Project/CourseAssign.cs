using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class CourseAssign : MetroFramework.Forms.MetroForm
    {
        public CourseAssign()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO FacultyCourse(CourseTitle,Tech,Semester,FacultyName) VALUES (@course,@tech,@semester,@Faculty)", con);
            cmd.Parameters.AddWithValue("@Faculty", facultytext.Text);
            cmd.Parameters.AddWithValue("@tech", techCombo.GetItemText(techCombo.SelectedItem));
            cmd.Parameters.AddWithValue("@semester", Semestercombo.GetItemText(Semestercombo.SelectedItem));
            cmd.Parameters.AddWithValue("@course", CourseCombo.GetItemText(CourseCombo.SelectedItem));
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                Admin a = new Admin();
                a.Show();
                this.Close();
            }

        }


        private void CourseAssign_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT UserID,FirstName,LastName FROM UserData WHERE User_Type = 'Faculty' ", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            metroGrid1.DataSource = dt;

            // TODO: This line of code loads data into the '_C__ProjectDataSet5.UserData' table. You can move, or remove it, as needed.
            this.userDataTableAdapter.Fill(this._C__ProjectDataSet5.UserData);
           
            // TODO: This line of code loads data into the '_C__ProjectDataSet4.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter1.Fill(this._C__ProjectDataSet4.Course);
            // TODO: This line of code loads data into the 'projectDataSet7.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.projectDataSet7.Course);
            // TODO: This line of code loads data into the '_C__ProjectDataSet3.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._C__ProjectDataSet3.Tech);

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string tech = techCombo.GetItemText(techCombo.SelectedItem);
            string semester = Semestercombo.GetItemText(Semestercombo.SelectedItem);
            metroPanel1.Visible = true;
            metroPanel1.Show();
            

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CourseTitle FROM Course WHERE Tech = '" + tech + "' AND Semester = '"+ semester +"'", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            CourseCombo.DisplayMember = "CourseTitle";
            CourseCombo.ValueMember = "CourseID";
            CourseCombo.DataSource = dt;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userDataTableAdapter.FillBy(this._C__ProjectDataSet5.UserData);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                facultytext.Text = row.Cells["UserID"].Value.ToString();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show(metroLink1, 0, metroLink1.Height);
        }

    }
}
