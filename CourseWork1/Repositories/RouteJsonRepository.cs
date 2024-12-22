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
    public class RouteJsonRepository : IRepository<IRoute>
    {
        private readonly string path;
        private List<IRoute> routes;

        public RouteJsonRepository(string path)
        {
            this.path = path;
            routes = new List<IRoute>();
            LoadData();
        }

        private void LoadData()
        {
            string[] routeFiles = Directory.GetFiles(path);
            string json;
            foreach (var routeFile in routeFiles)
            {
                json = File.ReadAllText(routeFile);
                routes.Add(JsonConvert.DeserializeObject<IRoute>(json));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var route in routes)
            {
                fileName = $"{route}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(route, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(IRoute route)
        {
            routes.Add(route);
            SaveData();
        }

        public IEnumerable<IRoute> GetAll()
        {
            return routes;
        }

        public IRoute GetById(int id)
        {
            return routes.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            IRoute route = GetById(id);
            if (route != null) routes.Remove(route);
            SaveData();
        }

        public void Update(IRoute route)
        {
            IRoute existingRoute = GetById(route.Id);
            if (existingRoute != null)
            {
                routes.Remove(existingRoute);
                routes.Add(route);
                SaveData();
            }
        }
    }
}
