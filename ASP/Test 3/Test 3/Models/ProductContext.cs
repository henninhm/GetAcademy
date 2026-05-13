using MySql.Data.MySqlClient;

namespace Test_3.Models
{
    public class ProductContext
    {
        public string ConnectionString { get; set; }

        public ProductContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM books", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product(
                            reader.GetInt32("id"),
                            reader.GetString("title"),
                            reader.GetInt32("author_id"),
                            reader.GetInt32("published_year"),
                            reader.GetDateTime("created_at")
                        ));
                    }
                }
            }

            return list;
        }
    }
}
