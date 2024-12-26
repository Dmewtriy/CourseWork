using CourseWork1.DTOs;
using System.Collections.Generic;

namespace CourseWork1.Presenters.interfaces
{
    public interface IRoutePointPresenter
    {
        void AddRoutePoint(RoutePointDTO RoutePoint);
        void DeleteRoutePoint(RoutePointDTO RoutePoint);
        void UpdateRoutePoint(RoutePointDTO RoutePoint);
        IEnumerable<RoutePointDTO> GetRoutePoints();
        void GetRoutePointById(long id);
        void GetExcursions(RoutePointDTO RoutePoint);
    }
}
