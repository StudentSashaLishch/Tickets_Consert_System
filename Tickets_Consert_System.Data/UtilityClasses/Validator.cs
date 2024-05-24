using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Data.UtilityClasses
{
    public static class Validator
    {
        public static bool ValidateLogin(string login, User.Role role)
        {
            switch(role)
            {
                case User.Role.Client:
                    var client = Repository<Client>
                        .GetRepo(new TicketsConsertSystemContext())
                        .GetFirst(c => c.Login == login);
                    if (client == null)
                        return true;
                    break;
                case User.Role.Singer:
                    var singer = Repository<Singer>
                        .GetRepo(new TicketsConsertSystemContext())
                        .GetFirst(c => c.Login == login);
                    if (singer == null) 
                        return true;
                    break;
                case User.Role.Manager:
                    var manager = Repository<Client>
                        .GetRepo(new TicketsConsertSystemContext())
                        .GetFirst(c => c.Login == login);
                    if (manager == null) 
                        return true;
                    break;
            }

            return false;
        }

        public static bool ValidateEmail(string email)
        {
            string[] prohibitedСharacters = {"&", "=", "+", "(", ")", "<", ">", ",", "_", "'", "-", ".."};

            string[] parts = email.Split('@');
            if (parts.Length != 2)
                return false;
            string[] domenName = parts[1].Split('.');
            if (domenName.Length != 2)
                return false;

            string name = parts[0];
            if (name.Length < 6 || name.Length > 30)
                return false;

            foreach(var symb in prohibitedСharacters)
            {
                if (name.Contains(symb)) 
                    return false;
            }

            if (name[0] == '.' || name[name.Length - 1] == '.')
                return false;


            return true;
        }
    }
}
