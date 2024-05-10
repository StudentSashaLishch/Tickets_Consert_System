using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tickets_Consert_System.Interfaces;
using Tickets_Consert_System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Tickets_Consert_System.UtilityClasses
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
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
                    return _dbSet;

                return _dbSet.AsEnumerable().Where(item => predicate(item));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading: {0}", ex.Message);
                return null;
            }
        }

        public void Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating: {0}", ex.Message);
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                T entity = _dbSet.FirstOrDefault(item => item.ID == id);

                
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: {0}", ex.Message);
            }
        }

        public void Update(T updatedEntity)
        {
            try
            {
                T entity = _dbSet.FirstOrDefault(item => updatedEntity.ID == item.ID);
                _context.Entry(entity).CurrentValues.SetValues(updatedEntity);
                _context.Entry(entity).State = EntityState.Modified;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: {0}", ex.Message);
            }
        }

        public T GetFirst(Func<T, bool> predicate)
        {
            try
            {
                return _dbSet.AsEnumerable().FirstOrDefault(item => predicate(item));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error looking: {0}", ex.Message);
                return null;
            }
        }
    }
}
