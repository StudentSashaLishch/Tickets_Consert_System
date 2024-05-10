

namespace Tickets_Consert_System
{
    public class User : Entity
    {
        public enum Role
        {
            Client,
            Singer,
            Manager
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public Role RoleUser { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public User() : base()
        {

        }

        public User(string login = "none", string password = "none", string fullName = "none", string email = "none") : this()
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Email = email;
        }
    }
}
