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
    public partial class UpdateCourse : MetroFramework.Forms.MetroForm
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }

        private void UpdateCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__ProjectDataSet6.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._C__ProjectDataSet6.Tech);
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT CourseID,CourseTitle,Semester,Tech,Technology FROM Course c INNER JOIN Tech t ON c.Tech = t.TechID", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            metroGrid1.DataSource = dt;
        }
        string TechID;
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                TechID = row.Cells["Tech"].Value.ToString();
                CourseIDtxt.Text = row.Cells["CourseID"].Value.ToString();
                CourseTitletxt.Text = row.Cells["CourseTitle"].Value.ToString();
                Semestercombo.Text = row.Cells["Semester"].Value.ToString();
                Techcombo.Text = row.Cells["Technology"].Value.ToString();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Course SET CourseID = @CourseID, CourseTitle = @CourseTitle, Semester = @Semester, Tech = @Tech WHERE Tech = @TechID", con);
                cmd.Parameters.AddWithValue("@TechID", TechID);
                cmd.Parameters.AddWithValue("@CourseID", CourseIDtxt.Text);
                cmd.Parameters.AddWithValue("@CourseTitle", CourseTitletxt.Text);
                cmd.Parameters.AddWithValue("@Semester", Semestercombo.GetItemText(Semestercombo.SelectedItem));
                cmd.Parameters.AddWithValue("@Tech", Techcombo.GetItemText(Techcombo.SelectedItem));
                cmd.ExecuteNonQuery();

                this.Close();
                Admin a = new Admin();
                a.Show();
            }
            catch
            {
                MessageBox.Show("Invalid Selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
