using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork1.Mappers
{
    public static class RoutePointMapper
    {
        public static RoutePointDTO ToDTO(IRoutePoint RoutePoint)
        {
            return new RoutePointDTO()
            {
                Id = RoutePoint.Id,
                Name = RoutePoint.Name,
                StayDuration = RoutePoint.StayDuration,
                HotelClass = RoutePoint.HotelClass,
                HotelName = RoutePoint.HotelName,
                Excursions = (List<ExcursionDTO>)RoutePoint.Excursions.Select(x => ExcursionMapper.ToDTO(x))
            };
        }
        public static IRoutePoint ToEntity(RoutePointDTO RoutePoint)
        {
            return new RoutePoint(RoutePoint.Id, RoutePoint.Name, RoutePoint.StayDuration, 
                RoutePoint.HotelName, RoutePoint.HotelClass,
                (List<IExcursion>)RoutePoint.Excursions.Select(x => ExcursionMapper.ToEntity(x)));
        }
    }
}
