using System;
using Tickets_Consert_System.UtilityClasses;

namespace Tickets_Consert_System.MainClasses
{
    public sealed class Consert : Entity
    {
        public DateTime DateOfConsert { get; set; }
        public Guid SingerID { get; set; }
        public int NumberRows { get; set; }
        public int NumberPlacesInRow { get; set; }
        public float TicketPrice { get; set; }

        public Consert() : base()
        {

        }

        public Singer GetSinger()
        {
            return Repository<Singer>
                .GetRepo(PathesOfFiles._SingersFileName)
                .GetFirst(singer => singer.ID == SingerID);
        }
    }
}
