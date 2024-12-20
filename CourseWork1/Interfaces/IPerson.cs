
namespace CourseWork1.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Patronymic { get; set; }
        string ToString();
    }
}
