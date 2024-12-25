using CourseWork1.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
