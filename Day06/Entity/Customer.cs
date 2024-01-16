using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Entity
{
    internal class Customer
    {
        public string? CustomerID { get; set; }  
        public string? CompanyName { get; set; }

        public override string? ToString()
        {
            return $"[CustomerID :{CustomerID}, CustomerName : {CompanyName} ]";
        }
    }
}
