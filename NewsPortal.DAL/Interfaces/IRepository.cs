using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsPortal.DAL.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        IEnumerable<T> All();

        T Get(params object[] key);

        IEnumerable<T> Find(Func<T, bool> predicate);

        T SingleOrDefault(Func<T, bool> predicate);

        T Create(T item);

        T Update(T item);

        T Delete(params object[] key);
    }
}