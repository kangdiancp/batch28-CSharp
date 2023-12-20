using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartThree
{
    internal class Employee
    {
        //encapsulation instance attribute
        private int empId;
        private string fullName;
        private DateTime joinDate;
        private double basicSalary;
        private double totalSalary;

        //static attribute
        public static int totalEmployee = 0;

        //default constructor
        public Employee()
        {
            totalEmployee++;
        }

        //constructor parameter
        public Employee(int empId, string fullName, DateTime joinDate, double basicSalary, double totalSalary)
        {
            this.empId = empId;
            this.fullName = fullName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.totalSalary = totalSalary;
            totalEmployee++;
        }

        public override string? ToString()
        {
            return $"EmpId : {EmpId}, FullName : {FullName}, JoiDate : {JoinDate}, Salary : {BasicSalary}, Total Salary : {TotalSalary}";
        }






        // get set
        public int EmpId { get => empId; set => empId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double TotalSalary { get => totalSalary; set => totalSalary = value; }
    }
}
