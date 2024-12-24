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
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var routeFile in routeFiles)
            {
                json = File.ReadAllText(routeFile);
                routes.Add(JsonConvert.DeserializeObject<IRoute>(json, options));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var route in routes)
            {
                fileName = $"{route.Id}.json";
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
            var route = routes.FirstOrDefault(c => c.Id == id);
            if (route == null) throw new Exception($"Маршрут с id {id} не найден.");
            return new Route(id, route.Name, route.Country, route.Duration, route.Points.ToList());
        }

        public void Remove(IRoute route)
        {
            if(routes.Remove(route))
                SaveData();
        }

        public void Update(IRoute route)
        {
            IRoute existingRoute = GetById(route.Id);
            if (existingRoute != null)
            {
                routes[routes.IndexOf(existingRoute)] = route;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить маршрут, так как он не найден.");
            }
        }
    }
}
