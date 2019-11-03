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
    public partial class AddCourse : MetroFramework.Forms.MetroForm
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__ProjectDataSet6.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._C__ProjectDataSet6.Tech);

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Course VALUES (@CourseID,@CourseTitle,@Semester,@Tech)", con);
                cmd.Parameters.AddWithValue("@CourseID", CourseIDtxt.Text);
                cmd.Parameters.AddWithValue("@CourseTitle", CourseTitletxt.Text);
                cmd.Parameters.AddWithValue("@Semester", Semestercombo.GetItemText(Semestercombo.SelectedItem));
                cmd.Parameters.AddWithValue("@Tech", Techcombo.GetItemText(Techcombo.SelectedItem));
                SqlDataReader dr = cmd.ExecuteReader();
                
                    this.Close();
                    Admin a = new Admin();
                    a.Show();
                
            }
            catch
            {
                MessageBox.Show("Data is not insert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
