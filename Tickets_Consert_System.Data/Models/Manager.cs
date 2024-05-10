using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System
{
    public sealed class Manager : User
    {
        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }

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
            TicketsConsertSystemContext db = new TicketsConsertSystemContext();
            Singer result = db.Singers.FirstOrDefault(s => s.ID == SingerID);

            return result;
        }
    }
}
