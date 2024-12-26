using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
