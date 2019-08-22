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
    public partial class ProgramForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-HK8RMOI\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";

        string connectionCommand = "Select Name, Price, Tag, Validation from tblProducts";

        string rowName;

        public ProgramForm()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProductForm newProduct = new AddProductForm();
            newProduct.ShowDialog();
            RefreshTable();
        }

        public void RefreshTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(connectionCommand, con);

                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dgvElements.DataSource = dataTable;
            }
        }

        private void dgvElements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                rowName = (string)dgvElements.Rows[e.RowIndex].Cells[0].Value;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {            
            using (SqlConnection con = new SqlConnection(connectionString))
            {                    
                SqlCommand cmd = new SqlCommand("DELETE from tblProducts WHERE Name= '" + rowName+"';", con);
                con.Open();
                cmd.ExecuteNonQuery();
                RefreshTable();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            if (tboxModifyPrice.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tblProducts SET Price = '" + tboxModifyPrice.Text + "' WHERE Name= '" + rowName + "';", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tboxModifyPrice.Text = "";
                }
            }
            if (tboxModifyTag.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tblProducts SET Tag = '" + tboxModifyTag.Text + "' WHERE Name= '" + rowName + "';", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tboxModifyTag.Text = "";
                }
            }
            if (tboxModifyName.Text != "")
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tblProducts SET Name = '" + tboxModifyName.Text + "' WHERE Name= '" + rowName + "';", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tboxModifyName.Text = "";
                }
            }
            RefreshTable();
        }
    }
}
