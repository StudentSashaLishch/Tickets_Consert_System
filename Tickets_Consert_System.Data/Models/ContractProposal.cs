using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Tickets_Consert_System.Data;

namespace Tickets_Consert_System.MainClasses
{
    public class ContractProposal : Entity
    {
        [ForeignKey("ManagerID")]
        public Guid ManagerID { get; set; }
        [ForeignKey("SingerID")]
        public Guid SingerID { get; set; }
        public double ManagersPrice {  get; set; }
        public bool IsForSinger { get; set; } // if true then proposal is sended from manager to singer, if false - from singer to manager

        public ContractProposal() : base()
        {

        }
    }
}
