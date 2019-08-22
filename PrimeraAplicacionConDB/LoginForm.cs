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

namespace PrimeraAplicacionConDB
{
    public partial class LoginForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-HK8RMOI\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Gray;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.Black;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            string query = "Select * from tblUser Where Username = '" + tboxUsername.Text.Trim() + "' and Password = '" + tboxPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                ProgramForm objLoginForm = new ProgramForm();
                this.Hide();
                objLoginForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Check username and password");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(tboxNewUsername.Text == ""|| tboxNewPassword.Text == "")
            {
                MessageBox.Show("Please fill blanks");
            }
            else if(tboxNewPassword.Text != tboxConfirmPassword.Text)
            {
                MessageBox.Show("Password do not match");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", tboxNewUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", tboxNewPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful");
                    Clear();
                }
            }            
        }

        void Clear()
        {
            tboxNewUsername.Text = "";
            tboxNewPassword.Text = "";
            tboxConfirmPassword.Text = "";
        }
    }
}
