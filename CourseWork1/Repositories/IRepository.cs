using System.Collections.Generic;

namespace CourseWork1.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        void Update(T item);
        T GetById(long id);
        IEnumerable<T> GetAll();
    }
}
