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
    public partial class UpdateTeacher : MetroFramework.Forms.MetroForm
    {
        string UserID;
        public UpdateTeacher()
        {
            InitializeComponent();
        }
        private void UpdateTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT UserID,FirstName,LastName,FatherName,MobileNo,Address,City,Username,Email,Password FROM UserData WHERE User_Type = 'Faculty'", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                metroGrid1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Database not connected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Insertbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog='C# Project';Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("UPDATE UserData SET FirstName = @FNamelb, LastName = @LNamelb, FatherName = @FatherNamelb, MobileNo = @Moblb, Address = @Addresslb , City = @Citylb, UserName = @Usernamelb, Email = @Email_lb, Password = @Passlb WHERE UserID = @UserID", con);
                cmd1.Parameters.AddWithValue("@UserID", UserID);
                cmd1.Parameters.AddWithValue("@FNamelb", FNametext.Text);
                cmd1.Parameters.AddWithValue("@LNamelb", LNametext.Text);
                cmd1.Parameters.AddWithValue("@FatherNamelb", FatherNametext.Text);
                cmd1.Parameters.AddWithValue("@Moblb", Mobtext.Text);
                cmd1.Parameters.AddWithValue("@Addresslb", Addresstext.Text);
                cmd1.Parameters.AddWithValue("@Citylb", Citytext.Text);
                cmd1.Parameters.AddWithValue("@Usernamelb", Usernametext.Text);
                cmd1.Parameters.AddWithValue("@Email_lb", Emailtext.Text);
                cmd1.Parameters.AddWithValue("@Passlb", Passwordtext.Text);
                SqlDataReader dr = cmd1.ExecuteReader();

                Admin a = new Admin();
                a.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Data is not Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Citytext.Text = row.Cells["City"].Value.ToString();
                Usernametext.Text = row.Cells["UserName"].Value.ToString();
                Emailtext.Text = row.Cells["Email"].Value.ToString();
                Passwordtext.Text = row.Cells["Password"].Value.ToString();
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
