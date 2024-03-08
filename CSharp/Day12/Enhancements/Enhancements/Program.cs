using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class Person
    {
       public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //lambda expression
            List<int> numbers = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            Console.WriteLine("The Number List is :");
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }

            //1. find square of each value in the list collection
            var square = numbers.Select(xy => xy * xy);

            Console.WriteLine("Square of the numbers :");
            foreach(var s in square)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            //2. find all numbers in the list divisible by 3
            List<int> divby3 = numbers.FindAll(a => (a % 3) == 0);

            foreach(var v in divby3)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("-----------------");
            List<Person> personlist = new List<Person>()
            { 
                new Person{ID=101,Name="Ashok"},
                new Person{ID=102,Name="Rohit"},
                new Person{ID=103,Name="Ajay"},
            };

            //3. Print the name of the employee whose ID=102
            var p = personlist.Find(per => per.ID == 102);
            Console.WriteLine($"The ID of the person {p.ID}, and the Name is {p.Name}");

            //4. to sort the persons by name
            var sortperson = personlist.OrderBy(nm => nm.Name);

            foreach(var n in sortperson)
            {
                Console.WriteLine($"The Id {n.ID} and the sorted name is{n.Name}");
            }
            Console.Read();
        }

    }

}
