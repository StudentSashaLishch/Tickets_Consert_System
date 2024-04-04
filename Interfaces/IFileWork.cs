using System.IO;

namespace Tickets_Consert_System.Interfaces
{
    public interface IFileWork
    {
        void DeserializeString(string line);
        void SerializeString(StreamWriter writer);
    }
}
