using CourseWork1.Interfaces;
using System;

namespace CourseWork1
{
    public interface IClient : IPerson
    {
        long Id { get; set; }
        DateTime DateOfBirth { get; set; }
        IPassport PassportData { get; set; }
        string PathToPhoto { get; set; }
    }
}
