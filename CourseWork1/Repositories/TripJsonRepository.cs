using CourseWork;
using CourseWork1.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var tripFile in tripFiles)
            {
                json = File.ReadAllText(tripFile);
                trips.Add(JsonConvert.DeserializeObject<ITrip>(json, options));
            }
        }

        private void SaveData()
        {
            string fileName, filePath, json;
            var options = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All, Formatting = Formatting.Indented };
            foreach (var trip in trips)
            {
                fileName = $"{trip.Id}.json";
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

        public ITrip GetById(long id)
        {
            var trip = trips.FirstOrDefault(c => c.Id == id);
            if (trip == null) throw new Exception($"Поездка с id {id} не найдена");
            var cr = trip.Representative;
            return new Trip(id, trip.RouteName,
                new CompanyRepresentative(cr.Id, cr.FirstName, cr.LastName, cr.Patronymic, cr.Number, cr.Email),
                trip.Price, trip.StartDate, trip.EndDate, trip.TouristNumber, trip.Tourists.ToList(), trip.Penalty);
        }

        public void Remove(ITrip trip)
        {
            if(trips.Remove(trip))
                SaveData();
        }

        public void Update(ITrip trip)
        {
            ITrip existingTrip = GetById(trip.Id);
            if (existingTrip != null)
            {
                trips[trips.IndexOf(existingTrip)] = trip;
                SaveData();
            }
            else
            {
                throw new Exception("Невозможно обновить поездку, так как она не найдена.");
            }
        }
    }
}
