using CourseWork1.Interfaces;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class RoutePointService : IRoutePointService
    {
        private readonly IRepository<IRoutePoint> repository;

        public RoutePointService(IRepository<IRoutePoint> repository)
        {
            this.repository = repository;
        }

        public bool DeleteRoutePoint(IRoutePoint RoutePoint)
        {
            return repository.Remove(RoutePoint);
        }

        public void EditRoutePoint(IRoutePoint RoutePoint)
        {
            repository.Update(RoutePoint);
        }

        public IEnumerable<IRoutePoint> GetAllRoutePoints()
        {
            return repository.GetAll();
        }

        public IRoutePoint GetRoutePointById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterRoutePoint(IRoutePoint RoutePoint)
        {
            long id;
            IRoutePoint existingRoutePoint = RoutePoint;
            while (existingRoutePoint != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingRoutePoint = repository.GetById(id); // бросает исключение, когда пункт не найден
                }
                catch
                {
                    RoutePoint.Id = id;
                    repository.Add(RoutePoint);
                    return;
                }

            }
        }
    }
}
