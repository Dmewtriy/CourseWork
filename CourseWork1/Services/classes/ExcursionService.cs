using CourseWork1.Interfaces;
using CourseWork1.Services.interfaces;
using System;
using System.Collections.Generic;

namespace CourseWork1.Services.classes
{
    public class ExcursionService : IExcursionService
    {
        private readonly IRepository<IExcursion> repository;

        public ExcursionService(IRepository<IExcursion> repository)
        {
            this.repository = repository;
        }

        public bool DeleteExcursion(IExcursion Excursion)
        {
            return repository.Remove(Excursion);
        }

        public void EditExcursion(IExcursion Excursion)
        {
            repository.Update(Excursion);
        }

        public IEnumerable<IExcursion> GetAllExcursions()
        {
            return repository.GetAll();
        }

        public IExcursion GetExcursionById(long id)
        {
            return repository.GetById(id);
        }

        public void RegisterExcursion(IExcursion Excursion)
        {
            long id;
            IExcursion existingExcursion = Excursion;
            while (existingExcursion != null)
            {
                id = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                try
                {
                    existingExcursion = repository.GetById(id); // бросает исключение, когда экскурсия не найдена
                }
                catch
                {
                    Excursion.Id = id;
                    repository.Add(Excursion);
                    return;
                }

            }
        }
    }
}
