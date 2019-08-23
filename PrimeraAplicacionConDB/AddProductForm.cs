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
    public partial class AddProductForm : Form
    {
        string connectionString = @"Data Source=DESKTOP-HK8RMOI\SQLEXPRESS;Initial Catalog=UserRegistrationDB;Integrated Security=True";

        DateTime date;

        public AddProductForm()
        {
            InitializeComponent();
            date = dtpNewValidation.Value;
            dtpNewValidation.MinDate = date;
        }

        private void btnConfirmSave_Click(object sender, EventArgs e)
        {
            if(tboxNewProdName.Text == "" || tboxNewProdPrice.Text == ""|| tboxNewProdTag.Text == "" || dtpNewValidation.Value >= date)
            {
                MessageBox.Show("Formatting error.");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT into tblProducts(Name, Price, Tag, Validation) values('" + tboxNewProdName.Text+ "', '"+tboxNewProdPrice.Text+"' , '"+tboxNewProdTag.Text+"' , '"+ dtpNewValidation.Value.ToString("dd-MM-yyyy") + "')", con);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tboxNewProdName.Text = "";
            tboxNewProdPrice.Text = "";
            tboxNewProdTag.Text = "";
        }

        private void dtpNewValidation_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
