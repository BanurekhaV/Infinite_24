using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{

    class Student
    {
        static int RollNo;
        string Name;
        string Dept;
        float Totmarks;

        static string wish;

        public void AcceptStudent()
        {
            Console.WriteLine("Enter Student RollNo,Name,Dept and Marks :");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
            Dept = Console.ReadLine();
            Totmarks = Convert.ToSingle(Console.ReadLine());
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Roll No :{RollNo}, Name : {Name}, Dept : {Dept} and Marks :{Totmarks}");
        }

        public static string Wishes(string s)
        {
            wish = s;
            return wish;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student stud1 = new Student();  //calling the default constructor
            //stud1.AcceptStudent();
            //stud1.DisplayStudent();

            //Console.WriteLine(Student.Wishes("Hello"));

            //Console.WriteLine("-------------");
            //Student stud2 = new Student();
            //stud2.AcceptStudent();
            //stud2.DisplayStudent();
            //Console.WriteLine(Student.Wishes("Hai")); 
            Employee e = new Employee();
            e.DisplayEmp();
            Employee emp = new Employee(1001,"Sanjana");
            emp.DisplayEmp();
            Employee emp1 = new Employee(1110, "Yuvraj", 37500);
            emp1.DisplayEmp();
            e = null;  //setting an object reference to null from a valid reference
            GC.Collect(); // forceful collection of garbage the moment the object looses reference
            Console.Read();
        }
    }
}
