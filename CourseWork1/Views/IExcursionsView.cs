using CourseWork1.DTOs;
using System;
using System.Collections.Generic;

namespace CourseWork1.Views
{
    public interface IExcursionsView
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
