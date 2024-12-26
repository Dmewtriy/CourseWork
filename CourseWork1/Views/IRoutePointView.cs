using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Views
{
    public interface IRoutePointView
    {
        event EventHandler<ExcursionDTO> LoadExcursionsForRoutePoint;
        event EventHandler<ExcursionDTO> AddExcursionToRoutePoint;
        event EventHandler<ExcursionDTO> RemoveExcursionFromRoutePoint;
        event EventHandler LoadAvailableExcursions;

        void DisplayExcursions(IEnumerable<ExcursionDTO> excursions);
        void DisplayAvailableExcursions(IEnumerable<ExcursionDTO> excursions);
        void ShowError(string message);
    }
}
