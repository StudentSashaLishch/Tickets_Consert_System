using System;
using System.Collections.Generic;
using Tickets_Consert_System.Interfaces;
using Tickets_Consert_System.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.IO;
using Tickets_Consert_System.MainClasses;

namespace Tickets_Consert_System.UtilityClasses
{
    public class Repository<T> : IRepository<T> where T : Entity, new()
    {
        private static string logFile = "logFile.txt";

        private DbSet<T> _dbSet;

        public static Repository<T> GetRepo()
        {
            return new Repository<T>(); 
        }

        public async Task<List<T>> GetAll(Func<T, bool> predicate = null)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    if (predicate == null)
                        return await AsyncEnumerable.ToListAsync(_dbSet);

                    return await AsyncEnumerable.ToListAsync(AsyncEnumerable.Where(_dbSet, item => predicate(item)));
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
                return null;
            }
        }

        public async void Create(T entity)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    await _dbSet.AddAsync(entity);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public async void Delete(Guid id)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    var entity = new T { ID = id };

                    _dbSet.Remove(entity);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public async void DeleteRange(List<Guid> values)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    List<T> list = new List<T>();
                    foreach (var id in values)
                    {
                        list.Add(new T { ID = id });
                    }
                    _dbSet.RemoveRange(list);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public async void DeleteRange(List<T> values)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    _dbSet.RemoveRange(values);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public async void Update(T updatedEntity)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    T entity = await AsyncEnumerable.FirstOrDefaultAsync(_dbSet, e => e.ID == updatedEntity.ID);
                    _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
                    _context.Entry(entity).State = EntityState.Modified;

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
            }
        }

        public async Task<T> GetFirst(Func<T, bool> predicate)
        {
            try
            {
                using (var _context = new TicketsConsertSystemContext())
                {
                    _dbSet = _context.Set<T>();
                    return await AsyncEnumerable.FirstOrDefaultAsync(_dbSet, item => predicate(item));
                }
            }
            catch (Exception ex)
            {
                WriteInLog(ex);
                return null;
            }
        }

        public Task<T> GetComponent(Guid EntityID)
        {
            using (var _context = new TicketsConsertSystemContext())
            {
                _dbSet = _context.Set<T>();
                return GetRepo().GetFirst(s => s.ID == EntityID);
            }
        }

        private void WriteInLog(Exception ex)
        {
            File.WriteAllText(logFile, $"{DateTime.Now} Error: {ex.Message}\n");
        }
    }
}
