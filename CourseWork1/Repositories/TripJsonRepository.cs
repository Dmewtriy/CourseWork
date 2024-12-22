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
    public class TripJsonRepository : IRepository<ITrip>
    {
        private readonly string path;
        private List<ITrip> trips;

        public TripJsonRepository(string path)
        {
            this.path = path;
            trips = new List<ITrip>();
            LoadData();
        }

        private void LoadData()
        {
            string[] tripFiles = Directory.GetFiles(path);
            string json;
            foreach (var tripFile in tripFiles)
            {
                json = File.ReadAllText(tripFile);
                trips.Add(JsonConvert.DeserializeObject<ITrip>(json));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            foreach (var trip in trips)
            {
                fileName = $"{trip}.json";
                filePath = path + "\\" + fileName;
                json = JsonConvert.SerializeObject(trip, options);
                File.WriteAllText(filePath, json);
            }
        }

        public void Add(ITrip trip)
        {
            trips.Add(trip);
            SaveData();
        }

        public IEnumerable<ITrip> GetAll()
        {
            return trips;
        }

        public ITrip GetById(int id)
        {
            return trips.FirstOrDefault(c => c.Id == id);
        }

        public void Remove(int id)
        {
            ITrip trip = GetById(id);
            if (trip != null) trips.Remove(trip);
            SaveData();
        }

        public void Update(ITrip trip)
        {
            ITrip existingTrip = GetById(trip.Id);
            if (existingTrip != null)
            {
                trips.Remove(existingTrip);
                trips.Add(trip);
                SaveData();
            }
        }
    }
}
