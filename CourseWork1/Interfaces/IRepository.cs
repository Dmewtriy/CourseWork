using System.Collections.Generic;

namespace CourseWork1.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(string key);
        void Update(T entity);
        T GetByKey(string key);
        IEnumerable<T> GetAll();
    }
}
