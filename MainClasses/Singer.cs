﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System.MainClasses
{
    public class Singer : User
    {
        public Singer() : base()
        {
            RoleUser = Role.Singer;
        }

        public Singer (string login, string password, string fullname, string email) : base(login, password, fullname, email)
        {
            RoleUser = Role.Singer;
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.WriteLine("");
        }
    }
}
