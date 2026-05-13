using System.Text.Json.Serialization;

namespace Test_3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }

        public User() { }

        [JsonConstructor]
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;

            CreatedAt = DateTime.Now;
        }
        
        public User(string username, string email, string password, DateTime createdAt)
        {
            Username = username;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }
        public User(int id, string username, string email, string password, DateTime createdAt)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            CreatedAt = createdAt;
        }
    }
}
