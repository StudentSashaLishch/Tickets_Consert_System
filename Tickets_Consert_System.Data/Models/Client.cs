﻿using System.Collections.Generic;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System
{
    public sealed class Client : User
    {
        public decimal Ballanse { get; set; }

        public Client() : base()
        {
            RoleUser = Role.Client;
        }

        public Client(string login = "none", string password = "none", string fullname = "none", string email = "none") : this()
        {
            Login = login;
            Password = password;
            FullName = fullname;
            Email = email;
            Ballanse = 1000;
        }
    }
}
