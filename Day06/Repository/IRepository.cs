using Day06.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Repository
{
    internal interface IRepository
    {
        IEnumerator<Employee>  FindAll();
        IEnumerable<Employee> FindAllEmployee();

        Employee FindEmployeeById(long id);

        IEnumerable<Employee> FindEmployeeByFirstName(string firstName);

        Employee CreateEmployee(ref Employee employee);

        Employee UpdateEmployee(Employee employee);

        void DeleteEmployee(long id);
    }
}
