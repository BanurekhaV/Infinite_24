using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_General
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }

    //Implentor of the above interface
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee{ID=1,Name="Khushi",Department="IT"},
                new Employee{ID=2,Name="Shanthanu",Department="Finance"},
                new Employee{ID=3,Name="Pragya",Department="HR"}
            };
            return emplist;
        }
    }
}
