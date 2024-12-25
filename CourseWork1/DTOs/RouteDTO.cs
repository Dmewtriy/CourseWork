using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.DTOs
{
    public class RouteDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Duration { get; set; }
        public List<RoutePointDTO> Points { get; set; }
    }
}
