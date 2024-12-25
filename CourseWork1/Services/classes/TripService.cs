using CourseWork1.Interfaces;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class TripService : ITripService
    {
        private readonly IRepository<ITrip> repository;

        public TripService(IRepository<ITrip> repository)
        {
            this.repository = repository;
        }

        public bool DeleteTrip(ITrip Trip)
        {
            return repository.Remove(Trip);
        }

        public void EditTrip(ITrip Trip)
        {
            repository.Update(Trip);
        }

        public IEnumerable<ITrip> GetAllTrips()
        {
            return repository.GetAll();
        }

        public ITrip GetTripById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterTrip(ITrip Trip)
        {
            long id;
            ITrip existingTrip = Trip;
            while (existingTrip != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingTrip = repository.GetById(id); // бросает исключение, когда маршрут не найден
                }
                catch
                {
                    Trip.Id = id;
                    repository.Add(Trip);
                    return;
                }

            }
        }
    }
}
