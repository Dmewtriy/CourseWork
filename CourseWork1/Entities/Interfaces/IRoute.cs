using System.Collections.Generic;

namespace CourseWork1
{
    public interface IRoute
    {
        long Id { get; set; }
        string Name { get; set; }
        string Country { get; set; }
        int Duration { get; set; }
        List<IRoutePoint> Points { get; set; }
    }
}
