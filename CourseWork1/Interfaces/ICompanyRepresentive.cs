using CourseWork1.Interfaces;

namespace CourseWork1
{
    public interface ICompanyRepresentative : IPerson
    {
        int Id { get; set; }
        string Number { get; set; }
        string Email { get; set; }
        string GetName();
    }
}
