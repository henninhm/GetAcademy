using MySql.Data.MySqlClient;

namespace Test_2.Models
{
    public class UserContext
    {
        public string ConnectionString { get; set; }

        public UserContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
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
    }
}
