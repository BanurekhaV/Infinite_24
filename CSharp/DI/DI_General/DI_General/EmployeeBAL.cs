using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_General
{
    public class EmployeeBAL
    {
        readonly IEmployeeDAL iedal;

        //inject the dependency
        public EmployeeBAL(IEmployeeDAL ied)
        {
            iedal = ied;
        }

        public List<Employee>GetAllEmployees()
        {
           return iedal.SelectAllEmployees();
        }
    }
}
