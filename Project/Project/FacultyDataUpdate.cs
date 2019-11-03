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
    public partial class FacultyDataUpdate : MetroFramework.Forms.MetroForm
    {
        public FacultyDataUpdate()
        {
            InitializeComponent();
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
        private void FacultyDataUpdate_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            string name = FacultyD.UserID;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserData WHERE UserID = @UserID", con);
                cmd.Parameters.AddWithValue("@UserID", name);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Firstnametext.Text = dr["FirstName"].ToString();
                    Lastnametext.Text = dr["LastName"].ToString();
                    Fathernametext.Text = dr["FatherName"].ToString();
                    Mobiletext.Text = dr["MobileNo"].ToString();
                    Addresstext.Text = dr["Address"].ToString();
                    Citytext.Text = dr["City"].ToString();
                    Usernametext.Text = dr["UserName"].ToString();
                    Emailtext.Text = dr["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("Data is not load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Database is not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            string userID = FacultyD.UserID;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserData SET FirstName = @FirstName , LastName = @LastName , FatherName = @FatherName , MobileNo = @Mobile , Address = @Address , City = @City , Username = @Username , Email = @Email WHERE UserID = @UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userID);
            cmd.Parameters.AddWithValue("@FirstName", Firstnametext.Text);
            cmd.Parameters.AddWithValue("@LastName", Lastnametext.Text);
            cmd.Parameters.AddWithValue("@FatherName", Fathernametext.Text);
            cmd.Parameters.AddWithValue("@Mobile", Mobiletext.Text);
            cmd.Parameters.AddWithValue("@Address", Addresstext.Text);
            cmd.Parameters.AddWithValue("@City", Citytext.Text);
            cmd.Parameters.AddWithValue("@Username", Usernametext.Text);
            cmd.Parameters.AddWithValue("@Email", Emailtext.Text);
            cmd.ExecuteNonQuery();

            this.Close();
            Student s = new Student(Name);
            s.Show();
        }
        }
    }

