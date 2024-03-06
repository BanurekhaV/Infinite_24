using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day10
{
    class PersonDetails
    {
        public string FirstName;
        public string LastName;

        public PersonDetails(string f, string l)
        {
            this.FirstName = f;
            this.LastName = l;
        }
    }
    class Persons
    {
        public int Age;
        public PersonDetails pd;  //composition/aggregation

        public Persons(int age,string fn, string ln)
        {
            Age = age;
            pd = new PersonDetails(fn, ln);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Persons DeepCopy()
        {
            Persons Dcopy = new Persons(this.Age, pd.FirstName, pd.LastName);
            return Dcopy;
        }
    }
    class Deep_ShallowCopy
    {
        public static void Main()
        {
            Persons p1 = new Persons(21, "Yashika", "Vasantha");
            Persons p2 = (Persons)p1.ShallowCopy();  
            Console.WriteLine($"The FirstName is {p1.pd.FirstName}, LastName is {p1.pd.LastName} and Age is {p1.Age}");
            Console.WriteLine("----------");
            Console.WriteLine($"The FirstName is {p2.pd.FirstName}, LastName is {p2.pd.LastName} and Age is {p2.Age}");

            p2.pd.FirstName = "Sathyam";  //changes the data in both the objects
            Console.WriteLine(p1.pd.FirstName);
            Console.WriteLine(p2.pd.FirstName);

            //deep copy does not 
            Console.WriteLine("---DeepCopy----");
            Persons p3 = p1.DeepCopy();

            Console.WriteLine($"The FirstName is {p1.pd.FirstName}, LastName is {p1.pd.LastName} and Age is {p1.Age}");
            Console.WriteLine($"The FirstName is {p3.pd.FirstName}, LastName is {p3.pd.LastName} and Age is {p3.Age}");

            Console.WriteLine("-----------");

            p3.pd.LastName = "Jaiswal";
            Console.WriteLine(p1.pd.LastName);
            Console.WriteLine(p3.pd.LastName);

            //if we equate both objects
            Console.WriteLine("----Equating both Objects----");
            p2 = p1;
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p1.GetHashCode());
            Console.Read();
        }
    }
}
