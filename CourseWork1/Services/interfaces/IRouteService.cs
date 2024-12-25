using System.Collections.Generic;

namespace CourseWork1.Services.interfaces
{
    public interface IRouteService
    {
        void RegisterRoute(IRoute route);
        bool DeleteRoute(IRoute route);
        void EditRoute(IRoute route);
        IRoute GetRouteById(long id);
        IEnumerable<IRoute> GetAllRoutes();
    }
}
