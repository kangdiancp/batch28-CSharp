using Day06.DbContext;
using Day06.Entity;
using Day06.Repository;
using Microsoft.Extensions.Configuration;

internal class Program
{

    private static IConfigurationRoot Configuration;
    static async Task Main(string[] args)
    {
        BuildConfiguration();
        var adoDbContext= new AdoDbContext(connectionString: Configuration.GetConnectionString("NorthWindDS"));

        
        //var adoDbMongodbContext = new AdoDbContext(Configuration.GetConnectionString("NorthWindDS"));
        //call interface, implement solid dependecny inversion
        IRepository repositoryDB = new RepositoryDB(adoDbContext);

        //1.call method di interface, FindAll return IEnumerator, tuk dapat value harus di loop dulu
        /*        var employees = repositoryDB.FindAll();
                while (employees.MoveNext())
                {
                    var employee = employees.Current;
                    Console.WriteLine(employee.ToString());
                }*/



        //2. FindAllEmployee() return IEnumerable langsung dapat di loop using foreach
        /*        var emps = repositoryDB.FindAllEmployee();
                foreach (var employee in emps)
                {
                    Console.WriteLine(employee.ToString());
                }*/

        //3. FindEmployeeById
        /*        var foundEmployee = repositoryDB.FindEmployeeById(2);
                Console.WriteLine($"Found Empployee : {foundEmployee}");*/

        //4. FindEmployeeByFirstName
        /*        var filterEmployeeByName = repositoryDB.FindEmployeeByFirstName("A%");
                foreach (var employee in filterEmployeeByName)
                {
                    Console.WriteLine(employee.ToString());
                }*/

        //5. createEmployee, EmployeeId ga diisi, otomatis dari sequence database
        /*var newEmps = new Employee { 
            FirstName="Yuli",
            LastName="Ayu",
            BirthDate = DateTime.Now };

        newEmps = repositoryDB.CreateEmployee(ref newEmps);
        Console.WriteLine(newEmps.ToString());*/

        //6. Update Employee
        /*var findUpdateEmps = new Employee
        {
            EmployeeId = 11,
            FirstName = "Widi",
            LastName = "Wini", 
            BirthDate = DateTime.Now
        };

        var updateEmp = repositoryDB.UpdateEmployee(findUpdateEmps);
        Console.WriteLine(updateEmp.ToString());*/


        //7. delete employee by id 10
        //repositoryDB.DeleteEmployee(10);

        //8. call method async
        /*        var employeeAsync = repositoryDB.FindAllEmployeeAsync();
                foreach (var item in await employeeAsync)
                {
                    Console.WriteLine($"{item.ToString()}");
                }*/

        //9. call generic method
        /*        IRepositoryBase<Employee> repositoryEmps = new EmployeeRepository(adoDbContext);
                var employeeGeneric = repositoryEmps.FindAll<Employee>();
                foreach (var employee in employeeGeneric)
                {
                    Console.WriteLine($"{employee.ToString()}");
                }*/

        IRepositoryBase<Customer> iRepo = new CustomerRepository(adoDbContext);
        var customers = iRepo.FindAll();
        foreach (var item in customers)
        {
            Console.WriteLine($"{item.ToString()}");
        }

    }

    private static void BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        Configuration = builder.Build();

        Console.WriteLine(Configuration.GetConnectionString("NorthWindDS"));

    }
}