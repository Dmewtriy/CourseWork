using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Views
{
    public interface IExcursionView
    {
        event EventHandler<ExcursionDTO> ExcursionAdded;
        event EventHandler<ExcursionDTO> ExcursionUpdated;
        event EventHandler<ExcursionDTO> ExcursionDeleted;
        event EventHandler LoadExcursionsRequested;
        event EventHandler<long> ExcursionSearchRequested;
        event EventHandler<ExcursionDTO> ExcursionSelected;

        void ShowErrorMessage(string message);
        void UpdateExcursionsList(IEnumerable<ExcursionDTO> Excursions);
        void HighlightExcursion(ExcursionDTO Excursion);
        void ShowExcursionDescription(string description);
    }
}
