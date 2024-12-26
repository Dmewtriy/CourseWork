using System;

namespace CourseWork1.DTOs
{
    public class PassportDTO
    {
        public string Series { get; set; }
        public string Number { get; set; }
        public DateTime IssuedDate{ get; set; }
        public string IssuedBy{ get; set; }
    }
}
