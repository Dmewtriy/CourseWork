using System;
using System.Collections.Generic;

namespace CourseWork1
{
    public interface ITrip
    {
        int Id { get; set; }
        string RouteName { get; set; }
        ICompanyRepresentative Representative { get; set; }
        int Price { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int TouristNumber { get; set; }
        List<IClient> Tourists { get; set; }
        int Penalty { get; set; }
    }
}
