using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    public delegate void EmpDel(string s); //declaring a delegate

    class Employee
    {
        public void acceptEmployeeName(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void displayEmployeeName(string msg)
        {
            Console.WriteLine("Welcome :" + msg);
        }

        public void Greetings()
        {
            Console.WriteLine("Hi All");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //create delegate object 
            //and pass the method name(reference)
            
            EmpDel edel1 = new EmpDel(emp.acceptEmployeeName); // instance function
            EmpDel edel2 = new EmpDel(Employee.displayEmployeeName); //static function
           
            //invoke / call the delegate
          
            edel1.Invoke("Infinite");
            edel2("Sankalp");
            Console.Read();
        }
    }
}
