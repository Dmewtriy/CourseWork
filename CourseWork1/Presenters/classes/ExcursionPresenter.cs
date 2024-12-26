using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services.interfaces;
using CourseWork1.Views;
using System;
using System.Collections.Generic;

namespace CourseWork1.Presenters.classes
{
    public class ExcursionPresenter : IExcursionPresenter
    {
        private readonly IExcursionService service;
        private readonly IExcursionView view;

        public ExcursionPresenter(IExcursionService service, IExcursionView view)
        {
            this.service = service;
            this.view = view;
            view.ExcursionAdded += (sender, Excursion) => AddExcursion(Excursion);
            view.ExcursionUpdated += (sender, Excursion) => UpdateExcursion(Excursion);
            view.ExcursionDeleted += (sender, Excursion) => DeleteExcursion(Excursion);
            view.LoadExcursionsRequested += (sender, e) => LoadExcursions();
            view.ExcursionSearchRequested += (sender, id) => GetExcursionById(id);
            view.ExcursionSelected += (sender, Excursion) => GetDescription(Excursion);
        }

        public void AddExcursion(ExcursionDTO Excursion)
        {
            service.RegisterExcursion(ExcursionMapper.ToEntity(Excursion));
            view.UpdateExcursionsList(GetExcursions());
        }

        public void DeleteExcursion(ExcursionDTO Excursion)
        {
            bool result = service.DeleteExcursion(ExcursionMapper.ToEntity(Excursion));
            if (result)
            {
                view.UpdateExcursionsList(GetExcursions());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении экскурсии. Попробуйте еще раз");
            }
        }

        public void GetExcursionById(long id)
        {
            try
            {
                ExcursionDTO Excursion = ExcursionMapper.ToDTO(service.GetExcursionById(id));
                view.UpdateExcursionsList(GetExcursions());
                view.HighlightExcursion(Excursion);
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<ExcursionDTO> GetExcursions()
        {
            var Excursions = service.GetAllExcursions();
            var ExcursionsDTO = new List<ExcursionDTO>();
            foreach (var Excursion in Excursions)
            {
                ExcursionsDTO.Add(ExcursionMapper.ToDTO(Excursion));
            }
            return ExcursionsDTO;
        }

        private void LoadExcursions()
        {
            view.UpdateExcursionsList(GetExcursions());
        }

        public void UpdateExcursion(ExcursionDTO Excursion)
        {
            service.EditExcursion(ExcursionMapper.ToEntity(Excursion));
            view.UpdateExcursionsList(GetExcursions());
            view.HighlightExcursion(Excursion);
        }

        public void GetDescription(ExcursionDTO Excursion)
        {
            var description = service.GetExcursionById(Excursion.Id).Description;
            view.ShowExcursionDescription(description);
        }
    }
}
