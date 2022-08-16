using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SalesDB
{
    internal interface IData<T>
    {
        bool Add(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        IEnumerable<T> GetMaxID();

        IEnumerable<T> GetAllData();

        IEnumerable<T> GetDataBy(Expression<Func<T, bool>> p);
    }
}