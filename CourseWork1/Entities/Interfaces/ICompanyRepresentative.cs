using CourseWork1.Interfaces;

namespace CourseWork1
{
    public interface ICompanyRepresentative : IPerson
    {
        long Id { get; set; }
        string Number { get; set; }
        string Email { get; set; }
    }
}
