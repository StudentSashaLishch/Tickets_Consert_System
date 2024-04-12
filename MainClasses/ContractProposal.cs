using System;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class ContractProposal : Entity
    {
        public Guid OfferManagerID { get; set; }
        public Guid SingerID { get; set; }

        public ContractProposal() : base()
        {

        }

        public Singer GetSinger()
        {
            return Repository<Singer>
                .GetRepo(PathesOfFiles._SingersFileName)
                .GetFirst(singer => singer.ID == SingerID);
        }

        public Manager GetManager()
        {
            return Repository<Manager>
                .GetRepo(PathesOfFiles._ManagersFileName)
                .GetFirst(manager => manager.ID == OfferManagerID);
        }
    }
}
