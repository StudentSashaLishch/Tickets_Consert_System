using System;
using System.Collections.Generic;

namespace Tickets_Consert_System.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll(Func<T, bool> predicate = null);
        void Create(T Entity);
        void Update(T Entity);
        void Delete(Guid id);
        T GetFirst(Func<T, bool> predicate);
    }
}