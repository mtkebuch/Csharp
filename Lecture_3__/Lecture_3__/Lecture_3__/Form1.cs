using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Lecture_3__
{
    public partial class Form1 : Form
    {
        private string _connectionString = "Server=LAB321PC09\\SQLEXPRESS01;Database=ClothingStoreDB; Trusted_Connection=True;";
        private SqlConnection _con;

        public Form1()
        {
            InitializeComponent();
            _con = new SqlConnection(_connectionString);
            this.UserIDLoad();
        }

        private void UserIDLoad()
        {
            string query = "SELECT UserID, Username FROM [dbo].[Users]";
            _con.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _con);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Users");
            _con.Close();
            UserIDBox.DataSource = dataSet.Tables["Users"];
            UserIDBox.DisplayMember = "Username";
            UserIDBox.ValueMember = "UserID";
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
               int userID = Convert.ToInt32(UserIDBox.SelectedValue);
               string orderDate = OrderdateText.Text;
               decimal totalAmount = Convert.ToDecimal(TotalamountText.Text);
               string status = StatusText.Text;
               string query = "INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status) VALUES (@UserID, @OrderDate, @TotalAmount, @Status)";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.Add("@UserID", SqlDbType.Int);
            cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal);
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50);

            cmd.Parameters["@UserID"].Value = userID;
            cmd.Parameters["@OrderDate"].Value = orderDate;
            cmd.Parameters["@TotalAmount"].Value = totalAmount;
            cmd.Parameters["@Status"].Value = status;

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();


        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(UserIDBox.SelectedValue);
            string orderDate = OrderdateText.Text;
            decimal totalAmount = Convert.ToDecimal(TotalamountText.Text);
            string status = StatusText.Text;
            string query = "INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status) VALUES (@UserID, @OrderDate, @TotalAmount, @Status)";

            SqlCommand cmd = new SqlCommand("CreateOrder", _con);
            cmd.CommandType=CommandType.StoredProcedure;


            cmd.Parameters.Add("@UserID", SqlDbType.Int);
            cmd.Parameters.Add("@OrderDate", SqlDbType.DateTime);
            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal);
            cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 50);

            cmd.Parameters["@UserID"].Value = userID;
            cmd.Parameters["@OrderDate"].Value = orderDate;
            cmd.Parameters["@TotalAmount"].Value = totalAmount;
            cmd.Parameters["@Status"].Value = status;

            _con.Open();
            cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}