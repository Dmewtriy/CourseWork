using System;

namespace CourseWork1
{
    public interface IExcursion
    {
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
