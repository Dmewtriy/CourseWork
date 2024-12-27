using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork1.Mappers
{
    public static class RouteMapper
    {
        public static RouteDTO ToDTO(IRoute Route)
        {
            List<RoutePointDTO> pointsDtos = new List<RoutePointDTO>();
            foreach (IRoutePoint point in Route.Points)
            {
                pointsDtos.Add(RoutePointMapper.ToDTO(point));
            }
            return new RouteDTO()
            {
                Id = Route.Id,
                Name = Route.Name,
                Country = Route.Country,
                Duration = Route.Duration,
                Points = pointsDtos,
            };
        }
        public static IRoute ToEntity(RouteDTO Route)
        {
            List<IRoutePoint> points = new List<IRoutePoint>();
            foreach (RoutePointDTO point in Route.Points)
            {
                points.Add(RoutePointMapper.ToEntity(point));
            }
            return new Route(Route.Id, Route.Name, Route.Country, Route.Duration, points);
        }
    }
}
