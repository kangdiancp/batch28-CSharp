using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class CustomerRepository : RepositoryBase<Customer>,ICustomer
    {
        public CustomerRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        public double CalculateIncome(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> FindAll<T>()
        {
            return base.FindAll<T>();
        }
    }
}
