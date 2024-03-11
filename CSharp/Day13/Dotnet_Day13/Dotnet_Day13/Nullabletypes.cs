using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    class Nullabletypes
    {
        static void Main()
        {
            Nullable<int> x = null;

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("It is null");
            Program p = new Program();
            p = null;
           // string pnm = (p != null) ? p.PName : null;

           string pnm = p?.PName;  //null conditional
            
            // p.TestFunc(pnm);
            Console.WriteLine("Value is " + " " + pnm);

            nameofExample ne = new nameofExample();
            try
            {
                ne.ShowOperator(ne.arr);
            }
            catch(Exception e)
            {
                // Console.WriteLine("Exception occured in the method  : " + nameof(ne.ShowOperator));
                Console.WriteLine(e.Message + "in the method " + nameof(ne.ShowOperator));
            }

            //name of
            //object initialization
            Employee emp = new Employee()
            {
                ID="1001",
                name="Praveen",
                Dept="Testing"
            };

            bool isinserted = Employee.Add(emp);
            Console.WriteLine($"{nameof(emp.Add)}");
            Console.Read();
        }
    }

    class nameofExample
    {
        //nameof 
        public int[] arr = new int[5];

        public int ShowOperator(int[] x)
        {
            x[5] = 10;
            return x[5];
        }
    }

    class Employee
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string Dept { get; set; }

        public static bool Add(Employee e)
        {
            return true;
        }
    }
}
