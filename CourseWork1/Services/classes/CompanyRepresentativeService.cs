using CourseWork1.Interfaces;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class CompanyRepresentativeService : ICompanyRepresentativeService
    {
        private readonly IRepository<ICompanyRepresentative> repository;

        public CompanyRepresentativeService(IRepository<ICompanyRepresentative> repository)
        {
            this.repository = repository;
        }

        public bool DeleteCompanyRepresentative(ICompanyRepresentative CompanyRepresentative)
        {
            return repository.Remove(CompanyRepresentative);
        }

        public void EditCompanyRepresentative(ICompanyRepresentative CompanyRepresentative)
        {
            repository.Update(CompanyRepresentative);
        }

        public IEnumerable<ICompanyRepresentative> GetAllCompanyRepresentatives()
        {
            return repository.GetAll();
        }

        public ICompanyRepresentative GetCompanyRepresentativeById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterCompanyRepresentative(ICompanyRepresentative CompanyRepresentative)
        {
            long id;
            ICompanyRepresentative existingCompanyRepresentative = CompanyRepresentative;
            while (existingCompanyRepresentative != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingCompanyRepresentative = repository.GetById(id); // бросает исключение, когда предстваитель не найден
                }
                catch
                {
                    CompanyRepresentative.Id = id;
                    repository.Add(CompanyRepresentative);
                    return;
                }

            }
        }
    }
}
