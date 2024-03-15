using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System
{
    public sealed class Client : User
    {
        public float Ballanse { get; set; }

        public Client() : base()
        {
            RoleUser = Role.Client;
        }

        public Client(string login, string password, string fullname, string email) : this()
        {
            Login = login;
            Password = password;
            FullName = fullname;
            Email = email;
            Ballanse = 1000;
        }

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            Ballanse = float.Parse(strings[6]);
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.WriteLine($",{Ballanse}");
        }
    }
}
