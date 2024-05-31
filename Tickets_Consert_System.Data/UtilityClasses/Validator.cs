using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.Data.UtilityClasses
{
    public static class Validator
    {
        public async static Task<bool> ValidateLogin(string login, User.Role role)
        {
            switch(role)
            {
                case User.Role.Client:
                    var client = await Repository<Client>
                        .GetRepo()
                        .GetFirst(c => c.Login == login);
                    if (client == null)
                        return true;
                    else
                        Debug.WriteLine(client.ID);
                    break;
                case User.Role.Singer:
                    var singer = await Repository<Singer>
                        .GetRepo()
                        .GetFirst(c => c.Login == login);
                    if (singer == null) 
                        return true;
                    else
                        Debug.WriteLine(singer.ID);
                    break;
                case User.Role.Manager:
                    var manager = await Repository<Client>
                        .GetRepo()
                        .GetFirst(c => c.Login == login);
                    if (manager == null)
                        return true;
                    else
                        Debug.WriteLine(manager.ID);
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
