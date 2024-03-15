using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System
{
    public class Entity
    {
        public Guid ID { get; set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }

        public virtual void DeserializeString(string line)
        {
            string[] strings = line.Split(',');
            ID = Guid.Parse(strings[0]);
        }

        public virtual void SerializeString(StreamWriter writer)
        {
            writer.Write($"{ID}");
        }
    }
}
