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
    public partial class FacultyD : MetroFramework.Forms.MetroForm
    {
        public static string UserID;
        string name;
        
        public FacultyD()
        {
            InitializeComponent();
        }
        private void Faculty_Load(object sender, EventArgs e)
        {
            #region
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            name = Form1.uname;
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserData u INNER JOIN Tech t ON u.Displine = t.TechID WHERE Username = @Username ", con);
                
                cmd.Parameters.AddWithValue("@Username", name);

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    FirstName.Text = dr["FirstName"].ToString();
                    LastName.Text = dr["LastName"].ToString();
                    FatherName.Text = dr["FatherName"].ToString();
                    DOB.Text = dr["DOB"].ToString();
                    Depart.Text = dr["Department"].ToString();
                    Tech.Text = dr["Technology"].ToString();
                    Byte[] b = new Byte[0];
                    b = (Byte[])(Byte[])dr["Picture"];
                    MemoryStream ms = new MemoryStream(b);
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Data is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Data is not load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT UserID FROM UserData WHERE Username = @Username", conn);
            cmd1.Parameters.AddWithValue("@Username", name);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                UserID = dr1["UserID"].ToString();
            }
            conn.Close();
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            Coursepanel.Visible = false;
        }

        private void Course_Click(object sender, EventArgs e)
        {
            Coursepanel.Visible = true;
            Coursepanel.Show();

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM FacultyCourse", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            metroGrid1.DataSource = dt;
        }
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];

                CourseTitle.Text = row.Cells["CourseTitle"].Value.ToString();
                Technology.Text = row.Cells["Tech"].Value.ToString();
                Semester.Text = row.Cells["Semester"].Value.ToString();
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

        private void updateDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyDataUpdate f = new FacultyDataUpdate();
            f.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyPassReset p = new FacultyPassReset();
            p.Show();
            this.Close();
        }
    }
}
