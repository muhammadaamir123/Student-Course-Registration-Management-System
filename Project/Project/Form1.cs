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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string uname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Passwordtext.MaxLength = 8;
            Passwordtext.PasswordChar = '*';
            Passwordtext.CharacterCasing = CharacterCasing.Lower;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            SignIn s = new SignIn();
            s.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            uname = Usernametext.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserData WHERE Username = @Username collate Latin1_General_CS_AS AND Password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS", con);
            cmd.Parameters.AddWithValue("@Username", Usernametext.Text);
            cmd.Parameters.AddWithValue("@Password", Passwordtext.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            //uname = dr["UserID"].ToString();

            string name = Usernametext.Text;
            string admin;
            
            if(dr.Read())
            {
                name = dr["User_Type"].ToString();
                admin = dr["Username"].ToString();
                if (name == "Student")
                {
                    Student s = new Student(Name);
                    s.Show();
                    this.Hide();
                }
                else if (name == "Faculty")
                {
                    FacultyD f = new FacultyD();
                    f.Show();
                    this.Hide();
                }
                else if(name == "Admin" || admin == "Admin")
                {
                    Admin a = new Admin();
                    a.Show();
                    this.Hide();
                }

            }
            else
            {
                Error.Text = "Username or Password is not match";
            }

        }

        public string get_form1text()
        {
            return Usernametext.Text;
        }        
    }
}
