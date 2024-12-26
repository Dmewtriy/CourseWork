using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Views
{
    public interface IRoutePointView
    {
        event EventHandler<RoutePointDTO> RoutePointAdded;
        event EventHandler<RoutePointDTO> RoutePointUpdated;
        event EventHandler<RoutePointDTO> RoutePointDeleted;
        event EventHandler LoadRoutePointsRequested;
        event EventHandler<long> RoutePointSearchRequested;
        event EventHandler<RoutePointDTO> RoutePointSelected;

        void ShowErrorMessage(string message);
        void UpdateRoutePointsList(IEnumerable<RoutePointDTO> RoutePoints);
        void HighlightRoutePoint(RoutePointDTO RoutePoint);
        void ShowExcursions(IEnumerable<ExcursionDTO> excursions);
    }
}
