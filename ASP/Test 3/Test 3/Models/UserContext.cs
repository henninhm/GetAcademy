using MySql.Data.MySqlClient;
using System.Net;

namespace Test_3.Models
{
    public class UserContext
    {
        public string ConnectionString { get; set; }

        public UserContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User(
                            reader.GetInt32("id"),
                            reader.GetString("username"),
                            reader.GetString("email"),
                            reader.GetString("password"),
                            reader.GetDateTime("created_at")
                        ));
                    }
                }
            }

            return list;
        }

        public async Task<int> AddUsers(User user)
        {
            using MySqlConnection conn = GetConnection();
            conn.Open();
            string query = @"Insert into users (username, email, password, " +
                "created_at) VALUES (@username, @email, @password, @created_at); " +
                "select LAST_INSERT_ID();";
            MySqlCommand command = new(query, conn);
            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@created_at", user.CreatedAt);

            var result = await command.ExecuteScalarAsync();
            return Convert.ToInt32(result);

            //conn.Open();
            //command.ExecuteNonQuery();
            
        }
    }
}
