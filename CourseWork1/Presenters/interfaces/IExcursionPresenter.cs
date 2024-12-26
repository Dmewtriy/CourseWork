using CourseWork1.DTOs;
using System.Collections.Generic;

namespace CourseWork1.Presenters.interfaces
{
    public interface IExcursionPresenter
    {
        void AddExcursion(ExcursionDTO Excursion);
        void DeleteExcursion(ExcursionDTO Excursion);
        void UpdateExcursion(ExcursionDTO Excursion);
        IEnumerable<ExcursionDTO> GetExcursions();
        void GetExcursionById(long id);
        void GetDescription(ExcursionDTO Excursion);
    }
}
