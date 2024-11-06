using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.UtilityClasses
{
    public static class AdminActions
    {
        public static async void ChangeBanStatuc(Guid UserID, User.Role role, bool ban)
        {
            if (UserID == null)
                return;

            User user = null;

            if (role == User.Role.Client)
            {
                user = await Repository<Client>
                .GetRepo()
                .GetComponent(UserID);
            }
            else if (role == User.Role.Manager)
            {
                user = await Repository<Manager>
                .GetRepo()
                .GetComponent(UserID);
            }
            else if (role == User.Role.Singer)
            {
                user = await Repository<Singer>
                .GetRepo()
                .GetComponent(UserID);
            }

            if (user == null)
                return;

            user.IsBanned = ban;

            Repository<User>
                .GetRepo()
                .Update(user);
        }

        public static async void ChangeBanStatuc(Guid UserID, bool ban)
        {
            if (UserID == null)
                return;

            User user = null;

            user = await Repository<Client>
                .GetRepo()
                .GetComponent(UserID);
            if (user == null)
                user = await Repository<Singer>
                    .GetRepo()
                    .GetComponent(UserID);
            if (user == null)
                user = await Repository<Manager>
                    .GetRepo()
                    .GetComponent(UserID);

            if (user == null)
                return;

            user.IsBanned = ban;

            Repository<User>
                .GetRepo()
                .Update(user);
        }
    }


}
