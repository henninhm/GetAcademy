namespace Test_2.Models
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }

        public User(int id_, string username_, string email_, string password_, DateTime created_at_)
        {
            id = id_;
            username = username_;
            email = email_;
            password = password_;
            created_at = created_at_;
        }
    }
}
