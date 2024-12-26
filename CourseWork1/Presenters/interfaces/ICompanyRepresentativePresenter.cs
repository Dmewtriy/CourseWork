using CourseWork1.DTOs;
using System.Collections.Generic;

namespace CourseWork1.Presenters.interfaces
{
    public interface ICompanyRepresentativePresenter
    {
        void AddCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative);
        void DeleteCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative);
        void UpdateCompanyRepresentative(CompanyRepresentativeDTO CompanyRepresentative);
        IEnumerable<CompanyRepresentativeDTO> GetCompanyRepresentatives();
        void GetCompanyRepresentativeById(long id);
    }
}
