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
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var routePointFile in routePointFiles)
            {
                json = File.ReadAllText(routePointFile);
                routePoints.Add(JsonConvert.DeserializeObject<IRoutePoint>(json, options));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var routePoint in routePoints)
            {
                fileName = $"{routePoint.Id}.json";
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

        public IRoutePoint GetById(long id)
        {
            var vp = routePoints.FirstOrDefault(c => c.Id == id);
            if (vp == null) throw new Exception($"Пункт маршрута с id {id} не найден.");
            return new RoutePoint(id, vp.Name, vp.StayDuration, vp.HotelName, vp.HotelClass, vp.Excursions.ToList());
        }

        public void Remove(IRoutePoint routePoint)
        {
            if(routePoints.Remove(routePoint))
                SaveData();
        }

        public void Update(IRoutePoint routePoint)
        {
            IRoutePoint existingRoutePoint = GetById(routePoint.Id);
            if (existingRoutePoint != null)
            {
                routePoints[routePoints.IndexOf(existingRoutePoint)] = routePoint;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить пункт маршрута, так как он не найден.");
            }
        }
    }
}
