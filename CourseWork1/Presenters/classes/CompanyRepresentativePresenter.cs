using CourseWork1.DTOs;
using CourseWork1.Mappers;
using CourseWork1.Presenters.interfaces;
using CourseWork1.Services;
using CourseWork1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork1.Presenters.classes
{
    public class CompanyRepresentativePresenter : ICompanyRepresentativePresenter
    {
        private readonly ICompanyRepresentativeService service;
        private readonly ICompanyRepresentativeView view;

        public CompanyRepresentativePresenter(ICompanyRepresentativeService service, ICompanyRepresentativeView view)
        {
            this.service = service;
            this.view = view;
            view.CompanyRepresentativeAdded += (sender, CompanyRepresentative) => AddCompanyRepresentative(CompanyRepresentative);
            view.CompanyRepresentativeUpdated += (sender, CompanyRepresentative) => UpdateCompanyRepresentative(CompanyRepresentative);
            view.CompanyRepresentativeDeleted += (sender, CompanyRepresentative) => DeleteCompanyRepresentative(CompanyRepresentative);
            view.LoadCompanyRepresentativesRequested += (sender, e) => LoadCompanyRepresentatives();
            view.CompanyRepresentativeSearchRequested += (sender, id) => GetCompanyRepresentativeById(id);
        }

        public void AddCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative)
        {
            service.RegisterCompanyRepresentative(CompanyRepresentativeMapper.ToEntity(CompanyRepresentative));
            view.UpdateCompanyRepresentativesList(GetCompanyRepresentatives());
        }

        public void DeleteCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative)
        {
            bool result = service.DeleteCompanyRepresentative(CompanyRepresentativeMapper.ToEntity(CompanyRepresentative));
            if (result)
            {
                view.UpdateCompanyRepresentativesList(GetCompanyRepresentatives());
            }
            else
            {
                view.ShowErrorMessage("Что-то пошло не так при удалении представителя компании. Попробуйте еще раз");
            }
        }

        public void GetCompanyRepresentativeById(long id)
        {
            try
            {
                CompanyRepresentativeDTO CompanyRepresentative = CompanyRepresentativeMapper.ToDTO(service.GetCompanyRepresentativeById(id));
                view.UpdateCompanyRepresentativesList(GetCompanyRepresentatives());
                view.HighlightCompanyRepresentative(CompanyRepresentative);
            }
            catch (Exception ex)
            {
                view.ShowErrorMessage(ex.Message);
            }
        }

        public IEnumerable<CompanyRepresentativeDTO> GetCompanyRepresentatives()
        {
            var CompanyRepresentatives = service.GetAllCompanyRepresentatives();
            var CompanyRepresentativesDTO = new List<CompanyRepresentativeDTO>();
            foreach (var CompanyRepresentative in CompanyRepresentatives)
            {
                CompanyRepresentativesDTO.Add(CompanyRepresentativeMapper.ToDTO(CompanyRepresentative));
            }
            return CompanyRepresentativesDTO;
        }

        private void LoadCompanyRepresentatives()
        {
            view.UpdateCompanyRepresentativesList(GetCompanyRepresentatives());
        }

        public void UpdateCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative)
        {
            service.EditCompanyRepresentative(CompanyRepresentativeMapper.ToEntity(CompanyRepresentative));
            view.UpdateCompanyRepresentativesList(GetCompanyRepresentatives());
            view.HighlightCompanyRepresentative(CompanyRepresentative);
        }
    }
}
