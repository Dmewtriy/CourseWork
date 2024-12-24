using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.DTOs
{
    public class ClientDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public long Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IPassport PassportData { get; set; }
        public string PathToPhoto { get; set; }
    }
}
