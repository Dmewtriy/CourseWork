using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services;
using CourseWork1.Services.interfaces;
using CourseWork1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Presenters.classes
{
    public class RoutePresenter : IRoutePresenter
    {
        private readonly IRouteService service;
        private readonly IRouteView view;

        public RoutePresenter(IRouteService service, IRouteView view)
        {
            this.service = service;
            this.view = view;
            view.RouteAdded += (sender, Route) => AddRoute(Route);
            view.RouteUpdated += (sender, Route) => UpdateRoute(Route);
            view.RouteDeleted += (sender, Route) => DeleteRoute(Route);
            view.LoadRoutesRequested += (sender, e) => LoadRoutes();
            view.RouteSearchRequested += (sender, id) => GetRouteById(id);
            view.RouteSelected += (sender, Route) => GetPoints(Route);
        }

        public void AddRoute(RouteDTO Route)
        {
            service.RegisterRoute(RouteMapper.ToEntity(Route));
            view.UpdateRoutesList(GetRoutes());
        }

        public void DeleteRoute(RouteDTO Route)
        {
            bool result = service.DeleteRoute(RouteMapper.ToEntity(Route));
            if (result)
            {
                view.UpdateRoutesList(GetRoutes());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении маршрута. Попробуйте еще раз");
            }
        }

        public void GetRouteById(long id)
        {
            try
            {
                RouteDTO Route = RouteMapper.ToDTO(service.GetRouteById(id));
                view.UpdateRoutesList(GetRoutes());
                view.HighlightRoute(Route);
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<RouteDTO> GetRoutes()
        {
            var Routes = service.GetAllRoutes();
            var RoutesDTO = new List<RouteDTO>();
            foreach (var Route in Routes)
            {
                RoutesDTO.Add(RouteMapper.ToDTO(Route));
            }
            return RoutesDTO;
        }

        private void LoadRoutes()
        {
            view.UpdateRoutesList(GetRoutes());
        }

        public void UpdateRoute(RouteDTO Route)
        {
            service.EditRoute(RouteMapper.ToEntity(Route));
            view.UpdateRoutesList(GetRoutes());
            view.HighlightRoute(Route);
        }

        public void GetPoints(RouteDTO Route)
        {
            var points = RouteMapper.ToDTO(service.GetRouteById(Route.Id)).Points;
            view.ShowRoutePoints(points);
        }
    }
}
