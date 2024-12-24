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
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var excursionFile in excursionFiles)
            {
                json = File.ReadAllText(excursionFile);
                excursions.Add(JsonConvert.DeserializeObject<IExcursion>(json, options));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var excursion in excursions)
            {
                fileName = $"{excursion.Id}.json";
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
            var exc = excursions.FirstOrDefault(c => c.Id == id);
            if (exc == null) throw new Exception($"Экскурсия с id {id} не найдена");
            return new Excursion(id, exc.Name, exc.Description, exc.StartDate, exc.EndDate);
        }

        public void Remove(IExcursion excurison)
        { 
            if (excursions.Remove(excurison))
                SaveData();
        }

        public void Update(IExcursion excursion)
        {
            IExcursion existingExcursion = GetById(excursion.Id);
            if (existingExcursion != null)
            {
                excursions[excursions.IndexOf(existingExcursion)] = excursion;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить экскурсию, так как она не найдена.");
            }
        }
    }
}
