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
using System.IO;

namespace Project
{
    public partial class 
        
        Student : MetroFramework.Forms.MetroForm
    {
        public static string UserID;
        public Student(string name)
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show(metroLink1, 0, metroLink1.Height);
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            CoursePanel.Visible = false;
            TeacherPanel.Visible = false;

        }
        private void Course_Click(object sender, EventArgs e)
        {
            TeacherPanel.Visible = false;
            CoursePanel.Visible = true;
            CoursePanel.Show();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CourseID,CourseTitle,Semester FROM Tech t INNER JOIN Course c ON t.TechID = c.Tech WHERE TechID = @Tech AND Semester = @semester ", con);
            cmd.Parameters.AddWithValue("@Tech", Tech.Text);
            cmd.Parameters.AddWithValue("@Semester", Semester.Text);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            metroGrid1.DataSource = dt;
        }
        private void Teacher_Click(object sender, EventArgs e)
        {

            CoursePanel.Visible = false;
            TeacherPanel.Visible = true;
            Teacher.Show();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT CourseTitle,Tech,f.Semester,u.FirstName,u.LastName FROM UserData u INNER JOIN FacultyCourse f ON u.UserID = f.FacultyName WHERE f.Tech = @Tech AND f.Semester = @Semester ", con);
            cmd.Parameters.AddWithValue("@Tech", Tech.Text);
            cmd.Parameters.AddWithValue("@Semester", Semester.Text);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            metroGrid2.DataSource = dt;
        }
        private void Student_Load(object sender, EventArgs e)
        {
            string uname = Form1.uname;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM UserData WHERE Username = @Username", con);
            
            cmd.Parameters.AddWithValue("@Username", uname);
           
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                UserID = dr["UserID"].ToString();
                FirstName.Text = dr["FirstName"].ToString();
                LastName.Text = dr["LastName"].ToString();
                FatherName.Text = dr["FatherName"].ToString();
                DOB.Text = dr["DOB"].ToString();
                Depart.Text = dr["Department"].ToString();
                Tech.Text = dr["Displine"].ToString();
                Byte[] b = new Byte[0];
                b = (Byte[])(Byte[])dr["Picture"];
                MemoryStream ms = new MemoryStream(b);
                pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                Regist.Text = dr["RegNo"].ToString();
                CGPA.Text = dr["CGPA"].ToString();
                Semester.Text = dr["Semester"].ToString();
            }
            con.Close();

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile u = new UpdateProfile();
            u.Show();
            this.Close();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StdPassReset p = new StdPassReset();
            p.Show();
            this.Close();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                CourseID.Text = row.Cells["CourseID"].Value.ToString();
                Coursetitle.Text = row.Cells["CourseTitle"].Value.ToString();
                Semester_ID.Text = row.Cells["Semester"].Value.ToString();
            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid2.Rows[e.RowIndex];
                Course_Title.Text = row.Cells["CourseTitle"].Value.ToString();
                Displine.Text = row.Cells["Tech"].Value.ToString();
                Semesterlb.Text = row.Cells["Semester"].Value.ToString();
                TFName.Text = row.Cells["FirstName"].Value.ToString();
                TLName.Text = row.Cells["LastName"].Value.ToString();
            }
        }
    }
}
