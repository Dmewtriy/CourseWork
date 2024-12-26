using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork1.Mappers
{
    public static class RouteMapper
    {
        public static RouteDTO ToDTO(IRoute Route)
        {
            return new RouteDTO()
            {
                Id = Route.Id,
                Name = Route.Name,
                Country = Route.Country,
                Duration = Route.Duration,
                Points = (List<RoutePointDTO>)Route.Points.Select(x => RoutePointMapper.ToDTO(x)),
            };
        }
        public static IRoute ToEntity(RouteDTO Route)
        {
            return new Route(Route.Id, Route.Name, Route.Country, Route.Duration,
                (List<IRoutePoint>)Route.Points.Select(x => RoutePointMapper.ToEntity(x)));
        }
    }
}
