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
    public partial class FacultyPassReset : MetroFramework.Forms.MetroForm
    {
        string Pass;
        public FacultyPassReset()
        {
            InitializeComponent();
        }

        private void Checkbtn_Click(object sender, EventArgs e)
        {
            Pass = Passtext.Text;
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            string UserID = FacultyD.UserID;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserData WHERE UserID = @userID", con);
                cmd.Parameters.AddWithValue("@userID", UserID);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Error.Text = "Password Correct!";
                    metroPanel1.Visible = true;
                    metroPanel1.Show();
                }
            }
            catch
            {
                Error.Text = "Password is not Found!";
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            string npass;
            string cpass;

            npass = NPasstext.Text;
            cpass = RPasstext.Text;

            if (npass == cpass)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
                string UserID = FacultyD.UserID;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE UserData SET Password = @RePassword WHERE UserID = @UserID", con);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@RePassword", NPasstext.Text);
                    cmd.ExecuteNonQuery();

                    this.Close();
                    Form1 f = new Form1();
                    f.Show();
                }
                catch
                {
                    MessageBox.Show("Data is not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Visible = true;
                    pictureBox1.Show();
                }
            }
            else
            {
                Error1.Text = "Password is not same";
                pictureBox1.Visible = true;
                pictureBox1.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            StdPassReset p = new StdPassReset();
            p.Show();
        }
    }
}
