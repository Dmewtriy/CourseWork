using CourseWork1.Interfaces;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class RouteService : IRouteService
    {
        private readonly IRepository<IRoute> repository;

        public RouteService(IRepository<IRoute> repository)
        {
            this.repository = repository;
        }

        public bool DeleteRoute(IRoute Route)
        {
            return repository.Remove(Route);
        }

        public void EditRoute(IRoute Route)
        {
            repository.Update(Route);
        }

        public IEnumerable<IRoute> GetAllRoutes()
        {
            return repository.GetAll();
        }

        public IRoute GetRouteById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterRoute(IRoute Route)
        {
            long id;
            IRoute existingRoute = Route;
            while (existingRoute != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingRoute = repository.GetById(id); // бросает исключение, когда маршрут не найден
                }
                catch
                {
                    Route.Id = id;
                    repository.Add(Route);
                    return;
                }

            }
        }
    }
}
