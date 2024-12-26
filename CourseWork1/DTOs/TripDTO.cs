using System;
using System.Collections.Generic;

namespace CourseWork1.DTOs
{
    public class TripDTO
    {
        public long Id { get; set; }
        public string RouteName { get; set; }
        public CompanyRepresentativeDTO Representative { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TouristNumber { get; set; }
        public List<ClientDTO> Tourists { get; set; }
        public int Penalty { get; set; }
    }
}
