using CourseWork1.Interfaces;

namespace CourseWork1
{
    public interface ICompanyRepresentative : IPerson
    {
        string Number { get; set; }
        string Email { get; set; }
        string GetName();
    }
}
