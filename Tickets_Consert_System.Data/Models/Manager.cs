using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System
{
    public class Manager : User
    {
        [ForeignKey("ContractID")]
        public Guid ContractID { get; set; }

        public Manager() : base()
        {
            RoleUser = Role.Manager;
        }

        public Manager(string login = "none", string password = "none", string fullname = "none", string email = "none") : base(login, password, fullname, email)
        {
            RoleUser = Role.Manager;
        }
    }
}
