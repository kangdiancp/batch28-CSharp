using Day06.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AdoDbContext _adoDbContext;

        // inject with adodbcontext
        public RepositoryBase(AdoDbContext adoDbContext)
        {
            _adoDbContext = adoDbContext;
        }

        public virtual IEnumerable<T> FindAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}
