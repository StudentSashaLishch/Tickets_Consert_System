using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tickets_Consert_System.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<List<T>> GetAll(Func<T, bool> predicate = null);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(Guid id);
        Task<T> GetFirst(Func<T, bool> predicate);
    }
}