namespace web_api.Models 
{
    public class User 
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User () {}
        public User (int userId, string name, string password, string email) {
            UserId = userId;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}