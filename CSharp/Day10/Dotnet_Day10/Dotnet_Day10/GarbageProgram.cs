using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day10
{
    class GarbageProgram
    {
        static void Main()
        {
            Console.WriteLine("the Number of generations are : " + GC.MaxGeneration);
            GarbageProgram gp = new GarbageProgram();
            Console.WriteLine("The Generation number of the object is :" + GC.GetGeneration(gp));
            Console.WriteLine("The Total Memory :" + GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
