using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Project
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        string select;
        public Admin()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TeachPanel.Visible = false;
            CoursePanel.Visible = false;
            StudentPanel.Visible = true;
            StudentPanel.Show();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,FatherName,MobileNo,Address,DOB,Gender,City,UserName,Email,Password,Department,Displine,User_Type,RegNo,Picture,CGPA FROM UserData WHERE User_Type = 'Student'", con);
                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Not connected to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__ProjectDataSet4.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this._C__ProjectDataSet4.Course);
            bool check = true;
            

            if(check == true)
            {
                pictureBox1.Visible = true;
            }
        }
        
                
        private void datagridview(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                    FNametext.Text = row.Cells["FirstName"].Value.ToString();
                    LNametext.Text = row.Cells["LastName"].Value.ToString();
                    FatherNametext.Text = row.Cells["FatherName"].Value.ToString();
                    Mobtext.Text = row.Cells["MobileNo"].Value.ToString();
                    Addresstext.Text = row.Cells["Address"].Value.ToString();
                    DOBtext.Text = row.Cells["DOB"].Value.ToString();
                    Gendertext.Text = row.Cells["Gender"].Value.ToString();
                    Citytext.Text = row.Cells["City"].Value.ToString();
                    Usernametext.Text = row.Cells["UserName"].Value.ToString();
                    Emailtext.Text = row.Cells["Email"].Value.ToString();
                    Passwordtext.Text = row.Cells["Password"].Value.ToString();
                    Regtext.Text = row.Cells["RegNo"].Value.ToString();
                    Deptext.Text = row.Cells["Department"].Value.ToString();
                    Techtext.Text = row.Cells["Displine"].Value.ToString();
                    UserTypetext.Text = row.Cells["User_Type"].Value.ToString();
                    Byte[] b = new Byte[0];
                    b = (Byte[])(Byte[])row.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(b);
                    pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                    String image = row.Cells["Picture"].Value.ToString();
                    CPGAtext.Text = row.Cells["CGPA"].Value.ToString();
                    select = row.Cells["RegNo"].ToString();
                }
            }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateStudent s = new UpdateStudent();
            s.Show();
            this.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteStdData d = new DeleteStdData();
            d.Show();
            this.Close();
        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            CoursePanel.Visible = false;
            TeachPanel.Visible = true;
            TeachPanel.Show();
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName,LastName,FatherName,MobileNo,Address,DOB,Gender,City,UserName,Email,Password,Department,Displine,User_Type,Picture FROM UserData WHERE User_Type = 'Faculty'", con);
                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());
                metroGrid2.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Not connected to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void datagridview1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid2.Rows[e.RowIndex];

                FNametext1.Text = row.Cells["FirstName"].Value.ToString();
                LNametext1.Text = row.Cells["LastName"].Value.ToString();
                FatherNametext1.Text = row.Cells["FatherName"].Value.ToString();
                Mobtext1.Text = row.Cells["MobileNo"].Value.ToString();
                Addresstext1.Text = row.Cells["Address"].Value.ToString();
                DOBtext1.Text = row.Cells["DOB"].Value.ToString();
                Gendertext1.Text = row.Cells["Gender"].Value.ToString();
                Citytext1.Text = row.Cells["City"].Value.ToString();
                Usernametext1.Text = row.Cells["UserName"].Value.ToString();
                Emailtext1.Text = row.Cells["Email"].Value.ToString();
                Passtext1.Text = row.Cells["Password"].Value.ToString();
                Departtext1.Text = row.Cells["Department"].Value.ToString();
                Techtext1.Text = row.Cells["Displine"].Value.ToString();
                Usertypetext1.Text = row.Cells["User_Type"].Value.ToString();
                Byte[] b = new Byte[0];
                b = (Byte[])(Byte[])row.Cells["Picture"].Value;
                MemoryStream ms = new MemoryStream(b);
                Picturetext1.Image = System.Drawing.Image.FromStream(ms);
                String image = row.Cells["Picture"].Value.ToString();
            }
        }

        private void UpdateTeacher_Click(object sender, EventArgs e)
        {
            UpdateTeacher t = new UpdateTeacher();
            t.Show();
            this.Close();
        }

        private void DeleteTeacher_Click(object sender, EventArgs e)
        {
            DeleteTeacher t = new DeleteTeacher();
            t.Show();
            this.Close();
        }

        private void CourseAsign_Click(object sender, EventArgs e)
        {
            CourseAssign c = new CourseAssign();
            c.Show();
            this.Close();
        }

        private void Coursebtn_Click(object sender, EventArgs e)
        {
            StudentPanel.Visible = false;
            TeachPanel.Visible = false;
            CoursePanel.Visible = true;
            CoursePanel.Show();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Course c INNER JOIN Tech t ON c.Tech = t.TechID", con);
                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());
                metroGrid3.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Not connected to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            menu.Show(metroLink1, 0, metroLink1.Height);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void metroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid3.Rows[e.RowIndex];
                CourseID.Text = row.Cells["CourseID"].Value.ToString();
                CourseTitle.Text = row.Cells["CourseTitle"].Value.ToString();
                Semester.Text = row.Cells["Semester"].Value.ToString();
                Displine.Text = row.Cells["Technology"].Value.ToString();
            }
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AddCourse a = new AddCourse();
            a.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
            UpdateCourse u = new UpdateCourse();
            u.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteCourse d = new DeleteCourse();
            d.Show();
        }

        

        }
    }


