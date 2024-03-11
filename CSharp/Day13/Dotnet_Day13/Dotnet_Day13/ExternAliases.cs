extern alias CL1;
extern alias CL2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    class ExternAliases
    {
        static void Main()
        {
            CL1.ClassLibrary1.Class1 cl1 = new CL1.ClassLibrary1.Class1();
            cl1.Message();
            CL2.ClassLibrary2.Class1 cl2 = new CL2.ClassLibrary2.Class1();
            cl2.Message();
            Console.Read();
        }
    }
}
