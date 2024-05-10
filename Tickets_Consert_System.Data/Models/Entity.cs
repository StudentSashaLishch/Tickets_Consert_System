using System;
using System.ComponentModel.DataAnnotations;

namespace Tickets_Consert_System
{
    public class Entity
    {
        [Key]
        public Guid ID { get; set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }
    }
}
