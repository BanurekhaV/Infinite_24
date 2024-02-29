using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day6
{
    public interface ICustomer
    {
       void PrintCustRating();  // only declaration, and no implementation
    }

    //one interface can implement other interfaces
    interface ICustomer1 : ICustomer
    {
        int getRating();
    }
    class Customer : ICustomer
    {
        public void PrintCustRating()
        {
            Console.WriteLine("This is the ICustomer Rating");
        }
    }

    class InterfaceTester : ICustomer1
    {
        public static void Main()
        {
            //  ICustomer ic; //creating an interface object
            // ic = new ICustomer(); //cannot instantiate an interface

            Customer cust = new Customer();
            cust.PrintCustRating();

            InterfaceTester itester = new InterfaceTester();
            itester.getRating();
            itester.PrintCustRating();
            Console.Read();
        }

        public int getRating()
        {
            return 1;
        }

        public void PrintCustRating()
        {
            Console.WriteLine("Rating");
        }
    }
}
