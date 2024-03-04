using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day8
{
    class Student : IComparable
    {
        public string Name { get; set; }
        public float Marks { get; set; }

        //object initializing

        public static void StudentInfo()
        {
            Student[] stdarray = new Student[]
            {
                new Student(){Name="Simran", Marks=80},
                new Student(){Name="Riya", Marks=86},
                new Student(){Name="Sharad",Marks=87},
                new Student(){Name="Shantanu",Marks=82},
                new Student(){Name="Diyasree",Marks=85}
            };
            Array.Sort(stdarray);
            foreach(var item in stdarray)
            {
                Console.WriteLine(item.Name);  // + " " + item.Marks);
            }
           
        }

        public int CompareTo(object obj)
        {
            Student sobj = obj as Student; //typecasting object type to student type using as operator
            if(sobj!=null)
            {
                return this.Name.CompareTo(sobj.Name);
            }
            return -1;
        }
    }
    class ComparableEg
    {
        static void Main()
        {
            string[] names = { "Avinash", "Suryansh", "Basavaraju", "Hemalatha",  "Nidhi", "Kavya" };
            Array.Sort(names);

            foreach(string nm in names)
            {
                Console.WriteLine(nm);
            }

            Console.WriteLine("------------");
            Student.StudentInfo();
            Console.Read();
        }
    }
}
