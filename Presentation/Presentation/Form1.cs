using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private string _connectionString = "Server=DESKTOP-O4D8S12\\MSSQLSERVER06;Database=ClothingStoreDB;Trusted_Connection=True;";

        public MainForm()
        {
            InitializeComponent();
        }

        // 1. DbConnection - კავშირის დამყარება
        private DbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString); 
        }

        // 2. DbCommand - SQL ბრძანებების შესრულება
        private DbCommand CreateCommand(string query, DbConnection connection)
        {
            return new SqlCommand(query, (SqlConnection)connection); 
        }

        private void LoadData()
        {
            try
            {
                using (DbConnection connection = CreateConnection()) 
                {
                    connection.Open();
                    DbCommand command = CreateCommand("SELECT * FROM Products", connection); 

                    DbDataReader reader = command.ExecuteReader(); // 3. DbDataReader
                    DataTable dt = new DataTable();
                    dt.Load(reader); 
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void InsertProduct(string productName, decimal price, int stock, string size, string color)
        {
            try
            {
                using (DbConnection connection = CreateConnection()) 
                {
                    connection.Open();
                    
                    DbCommand command = CreateCommand("INSERT INTO Products (ProductName, Price, Stock, Size, Color) VALUES (@ProductName, @Price, @Stock, @Size, @Color)", connection);

                    // 4. DbParameter - პარამეტრების დამატება SQL ბრძანებაში
                    command.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar) { Value = productName });
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal) { Value = price });
                    command.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = stock });
                    command.Parameters.Add(new SqlParameter("@Size", SqlDbType.NVarChar) { Value = size });
                    command.Parameters.Add(new SqlParameter("@Color", SqlDbType.NVarChar) { Value = color });

                    command.ExecuteNonQuery(); 
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting product: {ex.Message}");
            }
        }

        private void UpdateProduct(int productId, string productName, decimal price, int stock, string size, string color)
        {
            try
            {
                using (DbConnection connection = CreateConnection()) 
                {
                    connection.Open();
                    
                    DbCommand command = CreateCommand("UPDATE Products SET ProductName = @ProductName, Price = @Price, Stock = @Stock, Size = @Size, Color = @Color WHERE ProductID = @ProductID", connection);

                    
                    command.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int) { Value = productId });
                    command.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar) { Value = productName });
                    command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Decimal) { Value = price });
                    command.Parameters.Add(new SqlParameter("@Stock", SqlDbType.Int) { Value = stock });
                    command.Parameters.Add(new SqlParameter("@Size", SqlDbType.NVarChar) { Value = size });
                    command.Parameters.Add(new SqlParameter("@Color", SqlDbType.NVarChar) { Value = color });

                    command.ExecuteNonQuery(); 
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (DbConnection connection = CreateConnection()) 
                {
                    connection.Open();
                    
                    DbCommand command = CreateCommand("DELETE FROM Products WHERE ProductID = @ProductID", connection);

                    
                    command.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int) { Value = productId });
                    command.ExecuteNonQuery(); 
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            textBoxStock.Clear();
            textBoxSize.Clear();
            textBoxColor.Clear();
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxPrice.Text, out decimal price) && int.TryParse(textBoxStock.Text, out int stock))
            {
                InsertProduct(textBoxProductName.Text, price, stock, textBoxSize.Text, textBoxColor.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("Invalid price or stock input.");
            }
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxProductID.Text, out int productId) && decimal.TryParse(textBoxPrice.Text, out decimal price) && int.TryParse(textBoxStock.Text, out int stock))
            {
                UpdateProduct(productId, textBoxProductName.Text, price, stock, textBoxSize.Text, textBoxColor.Text);
                LoadData();
            }
            else
            {
                MessageBox.Show("Invalid input data.");
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxProductID.Text, out int productId))
            {
                DeleteProduct(productId);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.");
            }
        }
    }
}
