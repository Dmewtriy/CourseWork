using System;

namespace CourseWork1.DTOs
{
    public class ClientDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public long Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PassportDTO PassportData { get; set; }
        public string PathToPhoto { get; set; }
        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} {Patronymic} {DateOfBirth.ToShortDateString()} {PassportData.Series}{PassportData.Number}";
        }
    }
}
