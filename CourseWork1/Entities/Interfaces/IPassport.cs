using System;

namespace CourseWork1
{
    public interface IPassport
    {
        string Series { get; set; }
        string Number { get; set; }
        DateTime IssuedDate { get; set; }
        string IssuedBy { get; set; }
    }
}
