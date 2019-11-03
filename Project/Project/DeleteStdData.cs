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
    public partial class DeleteStdData : MetroFramework.Forms.MetroForm
    {
        string UserID;
        public DeleteStdData()
        {
            InitializeComponent();
        }

        private void DeleteStdData_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserData WHERE User_Type = 'Student'", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Database not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UserData WHERE UserID = @UserID AND User_Type = 'Student'", con);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.ExecuteNonQuery();
                DialogResult dr = MessageBox.Show("Are You Sure???", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    Admin a = new Admin();
                    a.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Operation Cancelled!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Data is not delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                UserID = row.Cells["UserID"].Value.ToString();
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
                Deptext.Text = row.Cells["Department"].Value.ToString();
                Techtext.Text = row.Cells["Displine"].Value.ToString();
                UserTypetext.Text = row.Cells["User_Type"].Value.ToString();
                Byte[] b = new Byte[0];
                b = (Byte[])(Byte[])row.Cells["Picture"].Value;
                MemoryStream ms = new MemoryStream(b);
                pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                String image = row.Cells["Picture"].Value.ToString();
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
    }
}
