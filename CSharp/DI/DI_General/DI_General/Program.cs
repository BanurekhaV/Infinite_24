using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_General
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeBAL ebal = new EmployeeBAL(new EmployeeDAL());

            List<Employee> elist=ebal.GetAllEmployees();

            foreach(Employee e in elist)
            {
                Console.WriteLine($"ID = {e.ID}, Name = {e.Name} and Department = {e.Department}");
            }
            Console.Read();
        }
    }
}
