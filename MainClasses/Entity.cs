using System;

namespace Tickets_Consert_System
{
    public class Entity
    {
        public Guid ID { get; set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }
    }
}
