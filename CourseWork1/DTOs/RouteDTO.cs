using System.Collections.Generic;

namespace CourseWork1.DTOs
{
    public class RouteDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Duration { get; set; }
        public List<RoutePointDTO> Points { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {Duration} {Country}";
        }
    }
}
