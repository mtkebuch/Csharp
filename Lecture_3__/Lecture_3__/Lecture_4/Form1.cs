using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace Lecture_4
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=LAB321PC09\\SQLEXPRESS01;Database=ClothingStoreDB; Trusted_Connection=True;";
        private SqlConnection _con;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            using (_con = new SqlConnection(_connectionString))
            {
                string query = "SELECT [CategoryID], [CategoryName] FROM [dbo].[Categories]";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    await _con.OpenAsync();
                    DataTable dt = new DataTable();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        dt.Load(reader);
                    }
                    dataGridView1.DataSource = dt;
                }
            }
        }

        public async void Create()
        {
            using (_con = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES (@CategoryName)";

                try
                {
                    
                    await _con.OpenAsync();
                    using (SqlTransaction transaction = _con.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(query, _con, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CategoryName", "Boots"); 
                            await cmd.ExecuteNonQueryAsync();

                            cmd.Parameters.Clear(); 
                            cmd.Parameters.AddWithValue("@CategoryName", "Cardigan"); 
                            await cmd.ExecuteNonQueryAsync();
                        }
                        transaction.Commit();
                    }

                    MessageBox.Show("Categories added successfully.");
                    await LoadCategories(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

      
        private void transactionButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Transaction button clicked.");
        }

        
        private void createButton_Click(object sender, EventArgs e)
        {
            Create(); 
        }
    }
}
