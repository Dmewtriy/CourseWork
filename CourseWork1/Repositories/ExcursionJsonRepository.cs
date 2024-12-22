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
    public class ExcursionJsonRepository : IRepository<IExcursion>
    {
        private readonly string path;
        private List<IExcursion> excursions;

        public ExcursionJsonRepository(string path)
        {
            this.path = path;
            excursions = new List<IExcursion>();
            LoadData();
        }

        private void LoadData()
        {
            string[] excursionFiles = Directory.GetFiles(path);
            string json;
            foreach (var excursionFile in excursionFiles)
            {
                json = File.ReadAllText(excursionFile);
                excursions.Add(JsonConvert.DeserializeObject<IExcursion>(json));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var excursion in excursions)
            {
                fileName = $"{excursion}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(excursion, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(IExcursion excursion)
        {
            excursions.Add(excursion);
            SaveData();
        }

        public IEnumerable<IExcursion> GetAll()
        {
            return excursions;
        }

        public IExcursion GetById(int id)
        {
            return excursions.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            IExcursion excursion = GetById(id);
            if (excursion != null) excursions.Remove(excursion);
            SaveData();
        }

        public void Update(IExcursion excursion)
        {
            IExcursion existingExcursion = GetById(excursion.Id);
            if (existingExcursion != null)
            {
                excursions.Remove(existingExcursion);
                excursions.Add(excursion);
                SaveData();
            }
        }
    }
}
