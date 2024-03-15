using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System
{
    public class User : Entity
    {
        public enum Role
        {
            Client,
            Singer,
            Manager
        }

        public string Login { get; set; }
        public string Password { get; set; }
        public Role RoleUser { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public User() : base()
        {

        }

        public User(string login, string password, string fullName, string email) : this()
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Email = email;
        }

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            Login = strings[1];
            Password = strings[2];
            RoleUser = (Role)Enum.Parse(typeof(Role), strings[3]);
            FullName = strings[4];
            Email = strings[5];
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            writer.Write($",{Login},{Password},{RoleUser},{FullName},{Email}");
        }
    }
}
