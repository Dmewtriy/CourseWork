using System.Collections.Generic;

namespace CourseWork1.Services.interfaces
{
    public interface IRoutePointService
    {
        void RegisterRoutePoint(IRoutePoint RoutePoint);
        bool DeleteRoutePoint(IRoutePoint RoutePoint);
        void EditRoutePoint(IRoutePoint RoutePoint);
        IRoutePoint GetRoutePointById(long id);
        IEnumerable<IRoutePoint> GetAllRoutePoints();
    }
}
