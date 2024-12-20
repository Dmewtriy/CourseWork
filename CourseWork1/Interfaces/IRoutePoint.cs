using System;
using System.Collections.Generic;

namespace CourseWork1
{
    public interface IRoutePoint
    {
        string Name { get; set; }
        int StayDuration { get; set; }
        string HotelName { get; set; }
        int HotelClass { get; set; }
        List<IExcursion> Excursions { get; set; }
    }
}
