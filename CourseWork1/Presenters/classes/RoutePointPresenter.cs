using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services.interfaces;
using CourseWork1.Views;
using System;
using System.Collections.Generic;

namespace CourseWork1.Presenters.classes
{
    public class RoutePointPresenter : IRoutePointPresenter
    {
        private readonly IRoutePointService service;
        private readonly IRoutePointView view;

        public RoutePointPresenter(IRoutePointService service, IRoutePointView view)
        {
            this.service = service;
            this.view = view;
            view.RoutePointAdded += (sender, RoutePoint) => AddRoutePoint(RoutePoint);
            view.RoutePointUpdated += (sender, RoutePoint) => UpdateRoutePoint(RoutePoint);
            view.RoutePointDeleted += (sender, RoutePoint) => DeleteRoutePoint(RoutePoint);
            view.LoadRoutePointsRequested += (sender, e) => LoadRoutePoints();
            view.RoutePointSearchRequested += (sender, id) => GetRoutePointById(id);
            view.RoutePointSelected += (sender, RoutePoint) => GetExcursions(RoutePoint);
        }

        public void AddRoutePoint(RoutePointDTO RoutePoint)
        {
            service.RegisterRoutePoint(RoutePointMapper.ToEntity(RoutePoint));
            view.UpdateRoutePointsList(GetRoutePoints());
        }

        public void DeleteRoutePoint(RoutePointDTO RoutePoint)
        {
            bool result = service.DeleteRoutePoint(RoutePointMapper.ToEntity(RoutePoint));
            if (result)
            {
                view.UpdateRoutePointsList(GetRoutePoints());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении пункта. Попробуйте еще раз");
            }
        }

        public void GetRoutePointById(long id)
        {
            try
            {
                RoutePointDTO RoutePoint = RoutePointMapper.ToDTO(service.GetRoutePointById(id));
                view.UpdateRoutePointsList(GetRoutePoints());
                view.HighlightRoutePoint(RoutePoint);
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<RoutePointDTO> GetRoutePoints()
        {
            var RoutePoints = service.GetAllRoutePoints();
            var RoutePointsDTO = new List<RoutePointDTO>();
            foreach (var RoutePoint in RoutePoints)
            {
                RoutePointsDTO.Add(RoutePointMapper.ToDTO(RoutePoint));
            }
            return RoutePointsDTO;
        }

        private void LoadRoutePoints()
        {
            view.UpdateRoutePointsList(GetRoutePoints());
        }

        public void UpdateRoutePoint(RoutePointDTO RoutePoint)
        {
            service.EditRoutePoint(RoutePointMapper.ToEntity(RoutePoint));
            view.UpdateRoutePointsList(GetRoutePoints());
            view.HighlightRoutePoint(RoutePoint);
        }

        public void GetExcursions(RoutePointDTO RoutePoint)
        {
            var excursions = RoutePointMapper.ToDTO(service.GetRoutePointById(RoutePoint.Id)).Excursions;
            view.ShowExcursions(excursions);
        }
    }
}
