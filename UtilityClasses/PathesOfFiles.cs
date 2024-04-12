using System.IO;

namespace Tickets_Consert_System.UtilityClasses
{
    public class PathesOfFiles
    {
        public static readonly string _OffersContractsNameFile = "OffersContracts.json";
        public static readonly string _ConsertsInfoNameFile = "ConsertsInfo.json";
        public static readonly string _SealedTicketsNameFile = "SealedTickets.json";
        public static readonly string _ClientsFileName = "Clients.json";
        public static readonly string _ManagersFileName = "Managers.json";
        public static readonly string _SingersFileName = "Singers.json";
        static PathesOfFiles()
        {
            if (!File.Exists(_OffersContractsNameFile))
                File.Create(_OffersContractsNameFile).Close();

            if (!File.Exists(_ConsertsInfoNameFile))
                File.Create(_ConsertsInfoNameFile).Close();

            if (!File.Exists(_SealedTicketsNameFile))
                File.Create(_SealedTicketsNameFile).Close();

            if(!File.Exists(_ClientsFileName))
                File.Create(_ClientsFileName).Close();

            if(!File.Exists(_ManagersFileName))
                File.Create(_ManagersFileName).Close();

            if (!File.Exists(_SingersFileName))
                File.Create(_SingersFileName).Close();
        }
    }
}
