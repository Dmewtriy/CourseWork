using CourseWork1.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Repositories
{
    public abstract class JsonRepository<T> where T : class , IRepository<T>
    {
        private readonly string _path;
        private List<T> items;

        public JsonRepository(string path)
        {
            _path = path;
            LoadData();
        }

        private void LoadData()
        {
            if (File.Exists(_path)) 
            {
                string json = File.ReadAllText(_path);
                items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            else
            {
                items = new List<T>();
            }
        }

        private void SaveData()
        {
            var options = new JsonSerializerSettings(){ Formatting = Formatting.Indented };
            string json = JsonConvert.SerializeObject(items, options);
            File.WriteAllText(_path, json);
        }

        public void Add(T entity)
        {
            if (entity != null && !items.Contains(entity))
            {
                items.Add(entity);
                SaveData();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return items;
        }

        public abstract T GetByKey(string key);

        public abstract void Remove(string key);

        public abstract void Update(T entity);
    }
}
