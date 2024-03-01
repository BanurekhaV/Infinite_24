using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Travel
    {
        public int Dist { get; set; }
        public DateTime Traveldate { get; set; }

        //overload a '+' operator in order to be able to add 2 distances
        //some rules to be followed
        public static Travel operator +(Travel tr1, Travel tr2)
        {
            Travel temp=new Travel();
            temp.Dist = tr1.Dist + tr2.Dist;
            return temp;
        }

    }
    class Operator_Overload
    {
        public static void Main()
        {
            Travel t1 = new Travel();
            Travel t2 = new Travel();
            t1.Dist = 45;
            t2.Dist = 20;
            Travel t3 = t1 + t2;
            Console.WriteLine("The total Distance To Travel is : " + t3.Dist);
            Console.Read();            
        }
    }
}
