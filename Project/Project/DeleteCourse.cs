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
    public partial class DeleteCourse : MetroFramework.Forms.MetroForm
    {
        public DeleteCourse()
        {
            InitializeComponent();
        }
        string tech;
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                tech = row.Cells["Tech"].Value.ToString();
                CourseID.Text = row.Cells["CourseID"].Value.ToString();
                CourseTitle.Text = row.Cells["CourseTitle"].Value.ToString();
                Semester.Text = row.Cells["Semester"].Value.ToString();
                Displine.Text = row.Cells["Technology"].Value.ToString();
            }
        }
        
        private void DeleteCourse_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CourseID,CourseTitle,Semester,Tech,Technology FROM Course c INNER JOIN Tech t ON c.Tech = t.TechID", con);
                DataTable dt = new DataTable();

                dt.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = dt;

            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Course WHERE Tech = @Tech", con);
                cmd.Parameters.AddWithValue("@Tech", tech);
                cmd.ExecuteNonQuery();

                this.Close();
                Admin a = new Admin();
                a.Show();
            }
            catch
            {
                MessageBox.Show("Invalid selection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
