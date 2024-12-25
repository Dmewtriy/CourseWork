using System.Collections.Generic;

namespace CourseWork1.Services
{
    public interface ICompanyRepresentativeService
    {
        void RegisterCompanyRepresentative(ICompanyRepresentative CompanyRepresentative);
        bool DeleteCompanyRepresentative(ICompanyRepresentative CompanyRepresentative);
        void EditCompanyRepresentative(ICompanyRepresentative CompanyRepresentative);
        ICompanyRepresentative GetCompanyRepresentativeById(long id);
        IEnumerable<ICompanyRepresentative> GetAllCompanyRepresentatives();
    }
}
