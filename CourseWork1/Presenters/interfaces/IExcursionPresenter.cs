using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
