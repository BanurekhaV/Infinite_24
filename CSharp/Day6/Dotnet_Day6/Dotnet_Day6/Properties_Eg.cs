using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day6
{
    class Employee
    {
        private string _code = "N.A.";
        private string _name = "Missing";
        private int _age = 0;

        
        //automatic property implementation
        public double Salary { get;} = 35000;

        //declare properties for all the private fields declared above
        public string Code
        {
            get { return _code; }  // reads the value of the field
            set { _code = value; } // writes/sets/manipulates the value of the field
        }

        public string Name
        {
            get { return _name; }
            set { if (value !=" ")
                    _name = value;
            else
                    Console.WriteLine("Invalid Data");
            }
        }
        //read only property (where there is only getter and no setter)
        public int Age
        {
            get { return _age; }
        }

        //we need to override the ToString() of the object class inorder to be able to
        //display all the property values of the employeee object

        public override string ToString()
        {
            return "Employee Code = " + Code + " Name = " + Name + " and Age = " + Age;
        }
    }
    class Properties_Eg
    {
        public static void Main()
        {
            Employee emp = new Employee();
            Console.WriteLine(emp.Code + " " + emp.Name + " " + emp.Age);
            emp.Code = "E001";  // it will call the setter
            //Console.WriteLine(emp.Code); // it will call the getter
           // Console.WriteLine(emp.Age);
            emp.Name = "Nithyanshu ";
            // Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Salary);
            Console.WriteLine("Employee Info {0}",emp.ToString());
            
            Console.Read();
        }
    }
}
