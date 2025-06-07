using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=DESKTOP-O4D8S12\\MSSQLSERVER06;Database=ClothingStoreDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) || string.IsNullOrWhiteSpace(txtSize.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; 
            }

            try
            {
                string query = "EXEC InsertProduct @ProductName, @Price, @Stock, @Size, @Color";

                SqlParameter[] parameters = {
            new SqlParameter("@ProductName", txtName.Text),
            new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text)),
            new SqlParameter("@Stock", Convert.ToInt32(txtStock.Text)),
            new SqlParameter("@Size", txtSize.Text),
            new SqlParameter("@Color", txtColor.Text)
        };

                await ExecuteNonQueryAsync(query, parameters);
                MessageBox.Show("Product inserted successfully.");
                btnLoad_Click(sender, e);  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) || string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; 
            }

            try
            {
                string query = "EXEC UpdateProduct @ProductID, @ProductName, @Price, @Stock, @Size, @Color";

                SqlParameter[] parameters = {
            new SqlParameter("@ProductID", Convert.ToInt32(txtID.Text)),
            new SqlParameter("@ProductName", txtName.Text),
            new SqlParameter("@Price", Convert.ToDecimal(txtPrice.Text)),
            new SqlParameter("@Stock", Convert.ToInt32(txtStock.Text)),
            new SqlParameter("@Size", txtSize.Text),
            new SqlParameter("@Color", txtColor.Text)
        };

                await ExecuteNonQueryAsync(query, parameters);
                MessageBox.Show("Product updated successfully.");
                btnLoad_Click(sender, e);  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter a Product ID to delete.");
                return; 
            }

            try
            {
                string query = "EXEC DeleteProduct @ProductID";

                SqlParameter[] parameters = {
            new SqlParameter("@ProductID", Convert.ToInt32(txtID.Text))
        };

                await ExecuteNonQueryAsync(query, parameters);
                MessageBox.Show("Product deleted successfully.");
                btnLoad_Click(sender, e);  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private async void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = await ExecuteQueryAsync("EXEC GetProducts");
            dgvProducts.DataSource = dt;
        }

        private async Task ExecuteNonQueryAsync(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    await conn.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        private async Task<DataTable> ExecuteQueryAsync(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
