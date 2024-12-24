﻿using System.Collections.Generic;

namespace CourseWork1.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item);
        T GetById(long id);
        IEnumerable<T> GetAll();
    }
}