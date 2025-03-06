using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lecture_1
{
    internal class Program
    {
        static string connectionString = "Server = LAB321PC08\\SQLEXPRESS02; Database=ClothingStoreDB;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbo].[Categories]([CategoryName]) VALUES(<CategoryName, varchar(100),>)";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();




            }
            Console.ReadKey();


        }
    }
}