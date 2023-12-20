using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Employee : Person
    {
        //encapsulation instance attribute
        private int empId;

        private DateTime joinDate;
        private double basicSalary;
        private double totalSalary;

        //static attribute
        public static int totalEmployee = 0;

        public Employee(int empId,string fullName, string npwp) : base(fullName, npwp)
        {
            this.empId = empId; 
        }




        //constructor parameter


        /*        public override string? ToString()
                {
                    return $"EmpId : {EmpId}, FullName : {FullName}, JoiDate : {JoinDate}, Salary : {BasicSalary}, Total Salary : {TotalSalary}";
                }
        */





        // get set

    }
}
