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
    public class RoutePointJsonRepository : IRepository<IRoutePoint>
    {
        private readonly string path;
        private List<IRoutePoint> routePoints;

        public RoutePointJsonRepository(string path)
        {
            this.path = path;
            routePoints = new List<IRoutePoint>();
            LoadData();
        }

        private void LoadData()
        {
            string[] routePointFiles = Directory.GetFiles(path);
            string json;
            foreach (var routePointFile in routePointFiles)
            {
                json = File.ReadAllText(routePointFile);
                routePoints.Add(JsonConvert.DeserializeObject<IRoutePoint>(json));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var routePoint in routePoints)
            {
                fileName = $"{routePoint}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(routePoint, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(IRoutePoint routePoint)
        {
            routePoints.Add(routePoint);
            SaveData();
        }

        public IEnumerable<IRoutePoint> GetAll()
        {
            return routePoints;
        }

        public IRoutePoint GetById(int id)
        {
            return routePoints.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            IRoutePoint routePoint = GetById(id);
            if (routePoint != null) routePoints.Remove(routePoint);
            SaveData();
        }

        public void Update(IRoutePoint routePoint)
        {
            IRoutePoint existingRoutePoint = GetById(routePoint.Id);
            if (existingRoutePoint != null)
            {
                routePoints.Remove(existingRoutePoint);
                routePoints.Add(routePoint);
                SaveData();
            }
        }
    }
}
