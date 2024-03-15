using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.UtilityClasses
{
    public static class HandleUsersInfo
    {
        public static List<Client> clients {  get; set; }
        public static List<Manager> managers { get; set; }
        public static List<Singer> singers { get; set; }
        public static readonly string _ClientsFileName = "Clients.txt";
        public static readonly string _ManagersFileName = "Managers.txt";
        public static readonly string _SingersFileName = "Singers.txt";

        static HandleUsersInfo()
        {
            if (!File.Exists(_ClientsFileName))
            {
                File.Create(_ClientsFileName).Close();
            }

            if (!File.Exists(_ManagersFileName)) 
            { 
                File.Create (_ManagersFileName).Close();
            }

            if (!File.Exists(_SingersFileName))
            {
                File.Create(_SingersFileName).Close();
            }

            ReadInfoFromFiles();
        }

        public static void ReadInfoFromFiles()
        {
            clients = new List<Client>();
            string[] lines = File.ReadAllLines(_ClientsFileName);
            foreach (string line in lines)
            {
                var client = new Client();
                client.DeserializeString(line);
                clients.Add(client);
            }

            singers = new List<Singer>();
            lines = File.ReadAllLines(_SingersFileName);
            foreach(string line in lines)
            {
                var singer = new Singer();
                singer.DeserializeString(line);
                singers.Add(singer);
            }

            managers = new List<Manager>();
            lines = File.ReadAllLines(_ManagersFileName);
            foreach (string line in lines)
            {
                var manager = new Manager();
                manager.DeserializeString(line);
                managers.Add(manager);
            }
        }

        public static void NewClient(string login, string password, string email, string fullname)
        {
            var client = new Client
            {
                Ballanse = 1000,
                Login = login,
                Password = password,
                Email = email,
                FullName = fullname
            };
            clients.Add(client);
            WriteClientsInfoIntoFiles();
        }

        public static void NewManager(string login, string password, string email, string fullName)
        {
            var manager = new Manager()
            {
                Login = login,
                Password = password,
                Email = email,
                FullName = fullName
            };
            managers.Add(manager);
            WriteManagersInfoIntoFile();
        }

        public static void NewSinger(string login, string password, string email, string fullName)
        {
            var singer = new Singer()
            {
                Login = login,
                Password = password,
                Email = email,
                FullName = fullName
            };
            singers.Add(singer);
            WriteSingersInfoIntoFiles();
        }

        public static void WriteSingersInfoIntoFiles()
        {
            using (var writer = new StreamWriter(_SingersFileName, false))
            {
                foreach (var singer in singers)
                {
                    singer.SerializeString(writer);
                }
            }
        }
        public static void WriteClientsInfoIntoFiles()
        {
            using (var writer = new  StreamWriter(_ClientsFileName, false))
            {
                foreach(var client in clients)
                {
                    client.SerializeString(writer);
                }
            }
        }
        public static void WriteManagersInfoIntoFile()
        {
            using (var writer = new StreamWriter(_ManagersFileName, false))
            {
                foreach( var manager in managers)
                {
                    manager.SerializeString(writer);
                }
            }
        }
    }
}
