using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tickets_Consert_System.MainClasses;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System
{
    public sealed class Manager : User
    {
        public Singer RepresentativeSinger { get; set; }

        public Manager() : base()
        {
            RoleUser = Role.Manager;
        }

        public Manager(string login, string password, string fullname, string email) : base(login, password, fullname, email)
        {
            RoleUser = Role.Manager;
        }

        public override void DeserializeString(string line)
        {
            base.DeserializeString(line);
            string[] strings = line.Split(',');
            RepresentativeSinger = HandleUsersInfo.singers.FirstOrDefault(singer => singer.ID == Guid.Parse(strings[6]));
        }

        public override void SerializeString(StreamWriter writer)
        {
            base.SerializeString(writer);
            if(RepresentativeSinger != null)
            {
                writer.WriteLine($",{RepresentativeSinger.ID}");
            }
            else
            {
                writer.WriteLine(",00000000-0000-0000-0000-000000000000");
            }
        }
    }
}
