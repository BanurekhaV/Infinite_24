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

            //Dictionary class 
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(4, "Bananas");
            dict.Add(1, "Oranges");
            dict.Add(5, "Apples");
            dict.Add(2, "Grapes");

            foreach(int v in dict.Keys)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

            foreach(string s in dict.Values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.Write(kvp.Key + " ");
                Console.Write(kvp.Value);
                Console.WriteLine(  );
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
