using System;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System
{
    public sealed class Manager : User
    {
        public Guid RepresentativeSingerID { get; set; }

        public Manager() : base()
        {
            RoleUser = Role.Manager;
        }

        public Manager(string login = "none", string password = "none", string fullname = "none", string email = "none") : base(login, password, fullname, email)
        {
            RoleUser = Role.Manager;
        }

        public Singer GetSinger()
        {
            return Repository<Singer>
                .GetRepo(PathesOfFiles._SingersFileName)
                .GetFirst(singer => singer.ID == RepresentativeSingerID);
        }
    }
}
