using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day10
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected int data;

        internal Dog(string s) { data = 100; }

        protected Dog()
        {
            Console.WriteLine("Dog getting constructed..");
        }
    }

    public class Labrador : Dog
    {
        public double FiestyFactor { get; set; }

        //the below constructor implicitly invokes the empty constructor in the base class
        public Labrador(string name, int age, double ff)
        {
            Name = name;
            Age = age;
            FiestyFactor = ff;
            Console.WriteLine($"{Name}, {Age}, {FiestyFactor}");
        }

        public void TestFunction()
        {
            Labrador lab = new Labrador("fghj",6,76);
            lab.data = 7;
            Dog d = new Dog("k");
        }
    }

    class Accounts
    {
        public int Acno;
        public string Name;
        public static float Amt;
        public static string typeofaccount = "savings";

        public Accounts(int acno,string name)
        {
            Acno = acno;
            Name = name;
            Console.WriteLine(Amt+ " "+ typeofaccount);
            Amt = 5000;
            Console.WriteLine(Amt + " "+ typeofaccount);
        }

        static Accounts()
        {
            Console.WriteLine(typeofaccount);
           
            
        }

        public void ShowAccounts()
        {
            Console.WriteLine(Acno +  " "+ Name + " " +Amt + " "+ typeofaccount);
        }
    }
    class ConstructorTypes
    {
        public ConstructorTypes()
        {
            Console.WriteLine("Constructor 1");
        }

        public ConstructorTypes(int a) :this()
        {
            Console.WriteLine("Constructor 2");
        }

        public ConstructorTypes(int a, int b): this(a)
        {
            Console.WriteLine("Constructor 3");
        }
        static void Main()
        {
            // ConstructorTypes ct = new ConstructorTypes(2,3);

            // Labrador lb = new Labrador("Olive", 3, 34.5);
            Accounts a1 = new Accounts(211, "Ramya");
            a1.ShowAccounts();
           
            Console.Read();
        }
    }
}
