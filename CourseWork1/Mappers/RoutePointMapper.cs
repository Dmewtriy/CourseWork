using CourseWork1.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace CourseWork1.Mappers
{
    public static class RoutePointMapper
    {
        public static RoutePointDTO ToDTO(IRoutePoint RoutePoint)
        {
            List<ExcursionDTO> excursionDTOs = new List<ExcursionDTO>();
            foreach(IExcursion ex in RoutePoint.Excursions)
            {
                excursionDTOs.Add(ExcursionMapper.ToDTO(ex));
            }
            return new RoutePointDTO()
            {
                Id = RoutePoint.Id,
                Name = RoutePoint.Name,
                StayDuration = RoutePoint.StayDuration,
                HotelClass = RoutePoint.HotelClass,
                HotelName = RoutePoint.HotelName,
                Excursions = excursionDTOs
            };
        }
        public static IRoutePoint ToEntity(RoutePointDTO RoutePoint)
        {
            List<IExcursion> excursions = new List<IExcursion>();
            foreach(ExcursionDTO ex in RoutePoint.Excursions)
            {
                excursions.Add(ExcursionMapper.ToEntity(ex));
            }
            return new RoutePoint(RoutePoint.Id, RoutePoint.Name, RoutePoint.StayDuration, 
                RoutePoint.HotelName, RoutePoint.HotelClass, excursions);
        }
    }
}
