using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModelPrj.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int ? AddressID { get; set; }
    }
}