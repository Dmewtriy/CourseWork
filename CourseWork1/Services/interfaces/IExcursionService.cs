using System.Collections.Generic;

namespace CourseWork1.Services.interfaces
{
    public interface IExcursionService
    {
        void RegisterExcursion(IExcursion Excursion);
        bool DeleteExcursion(IExcursion Excursion);
        void EditExcursion(IExcursion Excursion);
        IExcursion GetExcursionById(long id);
        IEnumerable<IExcursion> GetAllExcursions();
    }
}
