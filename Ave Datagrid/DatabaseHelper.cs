using Microsoft.Data.SqlClient;
using System.Data;

namespace ProductManager
{
    public class DatabaseHelper
    {
        private readonly string _connectionString = "Server=.\\SQLEXPRESS;Database=ProductManagerDB;Trusted_Connection=True;Encrypt=False;";

       
        public bool RegisterUser(string username, string password)
        {
            string hashedPassword = password; 
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Логин пользователя
        public bool LoginUser(string username, string password)
        {
            string query = "SELECT Password FROM Users WHERE Username = @Username";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string storedPassword = result.ToString();
                    return storedPassword == password;
                }
            }
            return false;
        }

        // Загрузка продуктов в DataTable
        public DataTable LoadProducts()
        {
            string query = "SELECT * FROM Products";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Добавление продукта
        public bool AddProduct(string name, decimal price, int quantity)
        {
            string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Обновление продукта
        public bool UpdateProduct(int id, string name, decimal price, int quantity)
        {
            string query = "UPDATE Products SET Name = @Name, Price = @Price, Quantity = @Quantity WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Удаление продукта
        public bool DeleteProduct(int id)
        {
            string query = "DELETE FROM Products WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
