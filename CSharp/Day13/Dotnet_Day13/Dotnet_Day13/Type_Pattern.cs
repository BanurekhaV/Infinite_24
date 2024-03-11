using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    class Customer
    {
        public string Name { get; set; } 
    }
    class Type_Pattern
    {
        static void PrintType(object obj)
        {
            switch(obj)
            {
                case Customer c:
                    Console.WriteLine("Object is a Customer");
                    Console.WriteLine($"Name of the Customer : {c.Name}");
                    break;
                case int n:
                    Console.WriteLine("Object is an Integer");
                    Console.WriteLine($"Value of int : {n}");
                    break;
                case double d:
                    Console.WriteLine("Object is a Double");
                    Console.WriteLine($"Value of double :{d}");
                    break;
                default:
                    Console.WriteLine("Object is some other Type");
                    break;
            }
            Console.WriteLine();
        }
        static void PrintUpperCase_IfString(object obj)
        {
            //if obj is a string
            if(obj is string msg)
            {
                Console.WriteLine($"{msg.ToUpper()}");
            }
            else
            {
                Console.WriteLine($"{obj} is not a string");
            }
        }

        //concisely written switch case
        //public static string GetNumber(int n)
        //{
        //    return n switch
        //    {
        //        < 0 =>"Negative",
        //        0 => "Zero",
        //        >= 1 => "Positive"
        //    };
        //}

        //public static bool LogicalOr(BooleanInput bi)
        //{
        //    switch (bi)
        //    {
        //        case (false, false): return false;
        //        case (true, false): return true;
        //        case (false, true): return true;
        //        case (true, true): return true;
        //    }
        //}

        //    //concisely
        //    public static bool LogicalAnd(BooleanInput bi)
        //    {
        //        return bi switch
        //        {
        //            (false, false) => false,
        //            (true, false) => false,
        //            (false, true) => false,
        //            (true, true) => true,
        //        };
        //}
        static void Main()
        {
            string str = "Hello All";
            int n = 45;
            object o1 = str;
            object o2 = n;

            //PrintUpperCase_IfString(o1);
            //PrintUpperCase_IfString(o2);

            var cust = new Customer { Name = "Infinite Ltd.," };
            PrintType(10);
            PrintType(cust);
            PrintType(125.45);
            PrintType("Patterns");
            Console.Read();
        }
    }

    struct BooleanInput
    {
        public bool input1 { get; set; }
        public bool input2 { get; set; }

        public void Deconstruct(out bool d1, out bool d2)
        {
            d1 = input1;
            d2 = input2;
        }
    }
}
