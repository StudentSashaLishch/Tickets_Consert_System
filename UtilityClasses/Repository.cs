using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Tickets_Consert_System.Interfaces;

namespace Tickets_Consert_System.UtilityClasses
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private static string _filePath;
        private static Repository<T> _instanse;
        private Repository(string path)
        {
            _filePath = path;
        }

        public static Repository<T> GetRepo(string path)
        {
            if (_instanse == null)
                _instanse = new Repository<T>(path);

            return _instanse;
        }

        public List<T> GetAll(Func<T, bool> predicate = null)
        {
            try
            {
                List<T> list = new List<T>();
                string[] lines = File.ReadAllLines(_filePath);
                foreach (string line in lines)
                {
                    T entity = JsonSerializer.Deserialize<T>(line);
                    if (predicate == null || predicate(entity))
                        list.Add(entity);
                }

                return list;
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
                List<T> entities = GetAll();
                entities.Add(entity);
                WriteInfo(entities);
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
                List<T> entities = GetAll();
                int index = entities.FindIndex(item => item.ID == id);

                entities.RemoveAt(index);
                WriteInfo(entities);
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
                var list = GetAll();
                int index = list.FindIndex(e => e.ID == updatedEntity.ID);
                if (index >= 0)
                    list[index] = updatedEntity;

                WriteInfo(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: {0}", ex.Message);
            }
        }

        public void WriteInfo(List<T> list)
        {
            try
            {
                File.WriteAllText(_filePath, "");
                foreach (T entity in list)
                {
                    string line = JsonSerializer.Serialize(entity);
                    File.AppendAllText(_filePath, line + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror writing: {0}", ex.Message);
            }
        }

        public T GetFirst(Func<T, bool> predicate)
        {
            try
            {
                List<T> list = GetAll(predicate);
                if (list.Count > 0)
                    return list[0];
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error looking: {0}", ex.Message);
                return null;
            }
        }
    }
}
