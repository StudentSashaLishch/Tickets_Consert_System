
namespace Tickets_Consert_System.MainClasses
{
    public class Singer : User
    {
        public Singer() : base()
        {
            RoleUser = Role.Singer;
        }

        public Singer (string login = "none", string password = "none", string fullname = "none", string email = "none") : base(login, password, fullname, email)
        {
            RoleUser = Role.Singer;
        }
    }
}
