using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
