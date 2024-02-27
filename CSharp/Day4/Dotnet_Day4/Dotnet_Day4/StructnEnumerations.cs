using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day4
{
    enum cities {Agra,Bangalore,Chennai,Delhi,Hyderabad,Kolkatta,Mumbai,Vizag}
    struct Customer
    {
        public int custrating;
    }
    class StructnEnumerations
    {
        enum colors {Red,Blue,Green,Yellow,Orange,White};
        public static void TestStructnClass()
        {
            //objects of structures
            //Customer cust1;  //or
            Customer cust1 = new Customer();
            cust1.custrating = 10;
           // Console.WriteLine(cust1.custrating);

            Customer cust2 = new Customer();
            cust2 = cust1;  //cust1 data gets copied onto cust2
            Console.WriteLine("Customer 1 rating :" + cust1.custrating + " "+ "Customer 2 rating :" +cust2.custrating);
            cust2.custrating = 2;
            Console.WriteLine("After Changes");
            Console.WriteLine("Customer 1 rating :" + cust1.custrating + " " + "Customer 2 rating :" + cust2.custrating);
        }

        public static void Enum_Operations()
        {
            foreach(int x in Enum.GetValues(typeof(cities)))
            {
                // Console.WriteLine(x);
                if(x==1)
                Console.WriteLine(Enum.GetName(typeof(cities),x) + " Is a Garden City");
                else if(x==2)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " Is a Temple City");
                else if(x==6)
                    Console.WriteLine(Enum.GetName(typeof(cities), x) + " Is a Financial City");
                else
                    Console.WriteLine(Enum.GetName(typeof(cities), x));
            }
            Console.WriteLine("--------------");
            foreach(string s in Enum.GetNames(typeof(cities)))
            {
                Console.WriteLine(s);
            }
        }
        public static void Main()
        {
            // StructnEnumerations.TestStructnClass();
           // StructnEnumerations.Enum_Operations();

            var myvar=56;
            myvar = 'G';
            Console.WriteLine(myvar);

            dynamic d;
            d = 8;
            d = 'u';
            Console.WriteLine(d);
            d = "hhhhh";
            Console.WriteLine(d);
            d = 66.7f;
            d = 4567.87;
            d = true;
            Console.WriteLine(d);
            Console.Read();
        }
    }
}
