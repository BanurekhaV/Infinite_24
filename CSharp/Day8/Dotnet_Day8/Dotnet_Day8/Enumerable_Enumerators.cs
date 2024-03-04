using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day8
{
    class Enumerable_Enumerators
    {
        public static void EnumeratingFunction()
        {
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Brown");
            colors.Add("White");
            Console.WriteLine("----List Output----");

            foreach (string s in colors)
            {
                Console.WriteLine(s);
            }

            //let us create an IEnumerable on the List colors
            IEnumerable<string> icolors = colors;

            Console.WriteLine("----IEnumerable Output----");
            foreach (var v in icolors)
            {
                Console.WriteLine(v);
            }

            //let us create an IEnumerator for colors
            IEnumerator<string> ecolors = colors.GetEnumerator(); //to convert list into IEnumerator,
                                                                  //we invoke GetEnumerator()
            Console.WriteLine("----IEnumerator Output----");
            while(ecolors.MoveNext())
            {
                Console.WriteLine(ecolors.Current);
            }
        }

        public static void Main()
        {
            EnumeratingFunction();
            Console.Read();
        }
    }
    
}
