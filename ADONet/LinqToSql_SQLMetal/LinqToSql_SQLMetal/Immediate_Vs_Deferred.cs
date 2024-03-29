using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql_SQLMetal
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
    }
    class Immediate_Vs_Deferred
    {
        public static void Main()
        {
            var emp = new List<Employee>
            {
                new Employee{Id=1,Name="Rajesh",Salary=30000},
                 new Employee{Id=2,Name="Reema",Salary=42000},
                  new Employee{Id=3,Name="Seema",Salary=54000},
            };

            //Linq query is being constructed
           // var elist = emp.Where(x => x.Salary < 35000).Select(y => y.Name); //deferred

            var elist = emp.Where(x => x.Salary < 35000).Select(y => y.Name).ToList(); //immediate

            emp.Add(new Employee { Id = 4, Name = "Kumar", Salary = 18000 });

            foreach(var ename in elist)
            {
                Console.WriteLine(ename);
            }
            Console.Read();
        }

    }
}
