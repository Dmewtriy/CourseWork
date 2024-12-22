using System.Collections.Generic;

namespace CourseWork1.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T client);
        void Remove(int id);
        void Update(T client);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
