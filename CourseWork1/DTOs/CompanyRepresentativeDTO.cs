﻿namespace CourseWork1.DTOs
{
    public class CompanyRepresentativeDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public long Id { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Id} {LastName} {FirstName} {Patronymic} {Number} {Email}";
        }
        public string GetName()
        {
            return $"{LastName} {FirstName} {Patronymic}";
        }
    }
}
