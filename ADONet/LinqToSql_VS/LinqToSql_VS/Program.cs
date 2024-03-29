using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql_VS
{
    class Program
    {
        static HoliDataContext hdc = new HoliDataContext();
        static void Main(string[] args)
        {
            var emp = hdc.tblEmployees.ToList();

            foreach(var item in emp)
            {
                Console.WriteLine($"Employee Name :{item.EmpName}, Salary :{item.Salary},Department : {item.DeptId}");
            }
            Console.WriteLine("Enter Department No :");
            int did = Convert.ToInt32(Console.ReadLine());
            int ans = hdc.EmpCount(did);

            Console.WriteLine($"Total Employees in the Given Department:{did} is {ans}");
            Console.Read();
        }
    }
}
