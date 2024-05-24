using System;
using System.Collections.Generic;
using Tickets_Consert_System.Interfaces;
using Tickets_Consert_System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;

namespace Tickets_Consert_System.UtilityClasses
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private static string logFile = "logFile.txt";

        private static TicketsConsertSystemContext _context;
        private static Repository<T> _instanse;
        private static DbSet<T> _dbSet;
        private Repository(TicketsConsertSystemContext db)
        {
            _context = db;
            _dbSet = _context.Set<T>();
        }

        public static Repository<T> GetRepo(TicketsConsertSystemContext db)
        {
            if (_instanse == null)
                _instanse = new Repository<T>(db);

            return _instanse;
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            try
            {
                if (predicate == null)
                    return _dbSet.AsEnumerable();

                _context.SaveChanges();
                return _dbSet.AsEnumerable().Where(item => predicate(item));
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
                return null;
            }
        }

        public void Create(T entity)
        {
            try
            {
                _dbSet.AddAsync(entity);
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                var entity = new T { ID = id };
                
                _dbSet.Remove(entity);
                _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public void DeleteRange(List<Guid> values)
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var id in values)
                {
                    list.Add(new T { ID = id });
                }
                _dbSet.RemoveRange(list);
                _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public void DeleteRange(List<T> values)
        {
            try
            {
                _dbSet.RemoveRange(values);
                _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public void Update(T updatedEntity)
        {
            try
            {
                T entity = _dbSet.FirstOrDefault(e => e.ID == updatedEntity.ID);
                _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
                _context.Entry(entity).State = EntityState.Modified;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public T GetFirst(Func<T, bool> predicate)
        {
            try
            {
                //_context.Dispose();
                return _dbSet.AsEnumerable().FirstOrDefault(item => predicate(item));
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
                return null;
            }
        }

        private void WriteInLog(Exception ex)
        {
            File.WriteAllText(logFile, $"{DateTime.Now} Error: {ex.Message}\n");
        }
    }
}
