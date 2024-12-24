using System;

namespace CourseWork1
{
    public interface IExcursion
    {
        long Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
    }
}
