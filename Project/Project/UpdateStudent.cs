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

namespace Project
{
    public partial class UpdateStudent : MetroFramework.Forms.MetroForm
    {
        string UserID;
        public UpdateStudent()
        {
            InitializeComponent();
        }

        

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT UserID,FirstName,LastName,FatherName,City,MobileNo,Address,CGPA,Username,Email,Password FROM UserData WHERE User_Type = 'Student' ", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            metroGrid1.DataSource = dt;

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
                Citytext.Text = row.Cells["City"].Value.ToString();
                Mobtext.Text = row.Cells["MobileNo"].Value.ToString();
                Addresstext.Text = row.Cells["Address"].Value.ToString();
                Usernametext.Text = row.Cells["Username"].Value.ToString();
                Emailtext.Text = row.Cells["Email"].Value.ToString();
                Passwordtext.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserData SET FirstName = @FNamelb , LastName = @LNamelb,FatherName = @FatherNamelb , City = @Citylb , MobileNo = @Moblb , Address = @Addresslb ,CGPA = @CGPA , Username = @Usernamelb , Email = @Email , Password = @Passlb WHERE UserID = @UserID", con);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@FNamelb", FNametext.Text);
            cmd.Parameters.AddWithValue("@LNamelb", LNametext.Text);
            cmd.Parameters.AddWithValue("@FatherNamelb", FatherNametext.Text);
            cmd.Parameters.AddWithValue("@Citylb", Citytext.Text);
            cmd.Parameters.AddWithValue("@Moblb", Mobtext.Text);
            cmd.Parameters.AddWithValue("@Addresslb", Addresstext.Text);
            cmd.Parameters.AddWithValue("@CGPA", CPGAtext.Text);
            cmd.Parameters.AddWithValue("@Usernamelb", Usernametext.Text);
            cmd.Parameters.AddWithValue("@Email", Emailtext.Text);
            cmd.Parameters.AddWithValue("@Passwordlb", Passwordtext.Text);
            cmd.ExecuteNonQuery();

            this.Close();
            Admin a = new Admin();
            a.Show();
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
