using CourseWork1.Interfaces;
using System;

namespace CourseWork1
{
    public interface IClient : IPerson
    {
        DateTime DateOfBirth { get; set; }
        IPassport PassportData { get; set; }
        string PathToPhoto { get; set; }
    }
}
