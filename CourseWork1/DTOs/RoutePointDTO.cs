using System.Collections.Generic;

namespace CourseWork1.DTOs
{
    public class RoutePointDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int StayDuration { get; set; }
        public string HotelName { get; set; }
        public int HotelClass { get; set; }
        public List<ExcursionDTO> Excursions { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {StayDuration} {HotelName} {HotelClass}";
        }
    }
}
