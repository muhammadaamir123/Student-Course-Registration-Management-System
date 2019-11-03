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
    public partial class SignIn : MetroFramework.Forms.MetroForm
    {
        string imageLocation = "";
        SqlConnection con;
        SqlCommand cmd;
        
        public SignIn()
        {
            InitializeComponent();
        }

       

        
        
        private void UsertypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combo = UsertypeCombo.Text;

            if(combo == "Student")
            {
                //Facultypanel.Visible = false;
                Studentpanel.Show();
            }
            else if(combo == "Faculty")
            {
                Studentpanel.Visible = false;
                //Facultypanel.Visible = true;
                //Facultypanel.Show();
            }
        }
        

        private void SigninButton_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(Pic.Text, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            byte[] image = new byte[fs.Length];
            fs.Read(image, 0, Convert.ToInt32(fs.Length));
            fs.Close();

            con = new SqlConnection(@"Data Source=DESKTOP-P8L58JD;Initial Catalog='C# Project';Integrated Security=True");


            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO UserData (FirstName,LastName,FatherName,MobileNo,Address,DOB,Gender,City,Username,Email,Password,Picture,User_Type,RegNo,Department,Displine,Semester) VALUES (@FirstName,@LastName,@FatherName,@MobileNo,@Address,@DateOfBirth,@Gender,@City,@Username,@Email,@Pass,@Pic,@Usertype,@RegNo,@Department,@Tech,@Semester)", con);
                cmd.Parameters.AddWithValue("@FirstName", Firstnametext.Text);
                cmd.Parameters.AddWithValue("@LastName", Lastnametext.Text);
                cmd.Parameters.AddWithValue("@FatherName", Fathernametext.Text);
                cmd.Parameters.AddWithValue("@MobileNo", Mobiletext.Text);
                cmd.Parameters.AddWithValue("@Address", Addresstext.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", Date.Value.Date);
                cmd.Parameters.AddWithValue("@Gender", Gendercombo.GetItemText(Gendercombo.SelectedItem));
                cmd.Parameters.AddWithValue("@City", Citytext.Text);
                cmd.Parameters.AddWithValue("@Username", Usernametext.Text);
                cmd.Parameters.AddWithValue("@Email", Emailtext.Text);
                cmd.Parameters.AddWithValue("@Pass", Password.Text);
                SqlParameter prm = new SqlParameter("@Pic", SqlDbType.VarBinary, image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, image);
                cmd.Parameters.Add(prm);
                cmd.Parameters.AddWithValue("@Usertype", UsertypeCombo.GetItemText(UsertypeCombo.SelectedItem));
                cmd.Parameters.AddWithValue("@RegNo", RegNoText.Text);
                cmd.Parameters.AddWithValue("@Department", departCombo.GetItemText(departCombo.SelectedItem));
                cmd.Parameters.AddWithValue("@Tech", TechCombo.GetItemText(TechCombo.SelectedItem));
                cmd.Parameters.AddWithValue("@Semester", SemesterCombo.GetItemText(SemesterCombo.SelectedItem));

                SqlDataReader dr = cmd.ExecuteReader();

                if(dr.HasRows)
                {
                    Error.Text = "Username is not exist";
                }
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }

            catch
            {
                Error.Text = "Username is exist";
                pictureBox1.Visible = true;
            }


                //Form1 f = new Form1();
                //f.Show();
                //this.Close();
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Pic.Text = openFileDialog1.FileName;
                }
            }
            catch
            {
                MessageBox.Show("An Error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy(this.projectDataSet.Department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_C__ProjectDataSet7.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter3.Fill(this._C__ProjectDataSet7.Department);
            // TODO: This line of code loads data into the '_C__ProjectDataSet31.Tech' table. You can move, or remove it, as needed.
            this.techTableAdapter.Fill(this._C__ProjectDataSet31.Tech);
            // TODO: This line of code loads data into the '_C__ProjectDataSet21.Semester' table. You can move, or remove it, as needed.
            this.semesterTableAdapter.Fill(this._C__ProjectDataSet21.Semester);
            // TODO: This line of code loads data into the '_C__ProjectDataSet21.UserData' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet3.UserData' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet3.User_Type' table. You can move, or remove it, as needed.
            this.user_TypeTableAdapter.Fill(this._C__ProjectDataSet3.User_Type);
            // TODO: This line of code loads data into the '_C__ProjectDataSet3.UserType' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet.UType' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet2.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter2.Fill(this._C__ProjectDataSet2.Department);
            // TODO: This line of code loads data into the '_C__ProjectDataSet2.Displine' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet1.Displine' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the '_C__ProjectDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter2.Fill(this._C__ProjectDataSet.Department);
            // TODO: This line of code loads data into the '_C__ProjectDataSet.UserType' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet6.UTData' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet5.UType' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet4.UserType' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet3.DepartmentData' table. You can move, or remove it, as needed.
            this.departmentDataTableAdapter1.Fill(this.projectDataSet3.DepartmentData);
            // TODO: This line of code loads data into the 'projectDataSet21.UserData' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projectDataSet21.DepartmentData' table. You can move, or remove it, as needed.
            this.departmentDataTableAdapter.Fill(this.projectDataSet21.DepartmentData);

        }


        private void Password_Click(object sender, EventArgs e)
        {
            Password.MaxLength = 8;
            Password.PasswordChar = '*';
            Password.CharacterCasing = CharacterCasing.Lower;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn s = new SignIn();
            s.Show();
        }

        
    }
}

