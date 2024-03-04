using System;
using System.Collections.Generic;


namespace Dotnet_Day8
{
    class Generics
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            numlist.Add(45);
            numlist.Add(56);
            numlist.Add(10);
            numlist.Add(6);

            numlist.Sort();
            foreach(int x in numlist)
            {
                Console.WriteLine(x);
            }
            List<string> strlist = new List<string>();
            strlist.Add("red");
            strlist.Add("blue");
            strlist.Add("green");

            foreach(string s in strlist)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("List with Objects-----");
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee(101, "Lavanya", 34500f, Convert.ToDateTime("4/01/2024")));
            emplist.Add(new Employee(104, "Pragya", 34500f, Convert.ToDateTime("12/01/2024")));
            emplist.Add(new Employee(102, "Khushi", 34500f, Convert.ToDateTime("27/12/2023")));
            
            foreach(Employee e in emplist)
            {
                Console.WriteLine(e.ToString());                
            }
            Console.Read();
        }
    }

    //generics with user defined datatype

    class Employee
    {
        int EID;
        string EmpName;
        float Salary;
        DateTime DOJ;

        public Employee(int id, string name, float sal, DateTime doj)
        {
            EID = id;
            EmpName = name;
            Salary = sal;
            DOJ = doj;
        }

        //override tostring();
        public override string ToString()
        {
            return string.Format("Employee Id : " + EID + " Employee name : " + EmpName + " Salary : " + Salary + " Date of Join : " + DOJ);
        }
    }
}
