using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class Student
    {
        private string RollNo;
        string Name;
        string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No :");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class :");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student : " + Name);
            Console.WriteLine("Roll No : "  + RollNo);
            Console.WriteLine("Class is  : " + Class);
        }
    }

    class Marks : Student
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for(int i =0; i<marks.Length;i++)
            {
                Console.Write("Enter Marks for Subject : {0} :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Marks in Subject : {0} = {1}",i+1,marks[i] );
            }
        }
    }

    class Results : Marks
    {
        int TotalMarks = 0;

        public void GetResults()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                TotalMarks = TotalMarks + marks[i];
            }
        }

        public void ShowResults()
        {
            Console.WriteLine("=======Results=======");
            PutData();
            PutMarks();            
            Console.WriteLine("Total Marks = " + TotalMarks);
        }
    }
    class MultiLevel_Inheritance
    {
        static void Main()
        {
            Results res = new Results();
            res.GetData();
            res.GetMarks();
            res.GetResults();
            res.ShowResults();

            Console.Read();
        }
    }
}
