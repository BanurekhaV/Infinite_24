using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day10
{
    public delegate Small CovarianceEg(Big bobj);
    public class Small
    {

    }

    public class Big : Small
    {

    }
    public class Bigger : Big {
    }
    class Co_ContraVariance
    {
        public static Big Function1(Big obj)
        {
            Console.WriteLine("This is Function 1");
            return obj;
        }

        public static Small Function2(Big obj)
        {
            Console.WriteLine("Function 2");
            return new Small();
        }

        public static Small Function3(Small small)
        {
            Console.WriteLine("Function 3");
            return new Small();
        }

        static void PersonInfo(Person p)
        {
            //code...
        }
        static void Main()
        {
            CovarianceEg ceg = Function1;
            Small s = ceg(new Big());

            ceg = Function2;
            Small s1 = ceg(new Big());

            ceg += Function3;

            Small s2 = ceg(new Big());
            Console.WriteLine("-----Example 2 Co-Contra------");

            var personobject = new Person();
            var employeeobject = new Employee();
            var managerobject = new Manager();

            personobject = employeeobject; //1. assigning a more derived type object to a less derived type
            personobject = managerobject; //2.

            employeeobject = managerobject; //3.

            employeeobject =(Employee) personobject; //contravariance of object (not possible without typecast)
            persondelegate del = PersonInfo;
            Console.Read();
        }
    }

    delegate void persondelegate(Employee emp);
    public class Person { }
    public class Employee : Person { }
    public class Manager : Employee { }
}
