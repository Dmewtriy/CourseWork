using System;

namespace CourseWork1.DTOs
{
    public class ExcursionDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override string ToString()
        {
            return $"{Id} {Name} {StartDate.ToShortDateString()} {EndDate.ToShortDateString()}";
        }
    }
}
