using Day06.DbContext;
using Day06.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal class EmployeeRepository : RepositoryBase<Employee>, IRepositoryBase<Employee>
    {
        public EmployeeRepository(AdoDbContext adoDbContext) : base(adoDbContext)
        {
        }

        /* private readonly AdoDbContext _adoDbContext;

public EmployeeRepository(AdoDbContext adoDbContext)
{
    _adoDbContext = adoDbContext;
}*/



        public IEnumerable<T> FindAll<T>()
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = "select EmployeeId,LastName, FirstName,BirthDate from Employees",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[] {}
            };

            var dataSet = _adoDbContext.ExecuteReader<T>(model);


            //selalu gunakan iterator tuk dapatkan value dari IEnumerator
            while (dataSet.MoveNext())
            {
                var employee = dataSet.Current;
                yield return employee;
            }


            _adoDbContext.Dispose();
        }


    }
}
