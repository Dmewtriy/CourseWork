using CourseWork1.DTOs;
using System.Collections.Generic;

namespace CourseWork1.Presenters.interfaces
{
    public interface IRoutePresenter
    {
        void AddRoute(RouteDTO Route);
        void DeleteRoute(RouteDTO Route);
        void UpdateRoute(RouteDTO Route);
        IEnumerable<RouteDTO> GetRoutes();
        void GetRouteById(long id);
        void GetPoints(RouteDTO Route);
    }
}
