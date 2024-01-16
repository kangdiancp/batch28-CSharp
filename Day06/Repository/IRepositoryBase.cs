using Day06.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal interface IRepositoryBase <T>
    {
        IEnumerable<T> FindAll<T>();

        IEnumerable<T> FindById<T>();

        T Save(T entity);

        T Update (T entity);

        void Delete(T entity);  

    }
}
