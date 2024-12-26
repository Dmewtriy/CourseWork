using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Views
{
    public interface IRouteView
    {
        event EventHandler<RouteDTO> RouteAdded;
        event EventHandler<RouteDTO> RouteUpdated;
        event EventHandler<RouteDTO> RouteDeleted;
        event EventHandler LoadRoutesRequested;
        event EventHandler<long> RouteSearchRequested;
        event EventHandler<RouteDTO> RouteSelected;

        void ShowErrorMessage(string message);
        void UpdateRoutesList(IEnumerable<RouteDTO> Routes);
        void HighlightRoute(RouteDTO Route);
        void ShowRoutePoints(IEnumerable<RoutePointDTO> points);
    }
}
