using System;
using Dotnet_Day4;

namespace Project2
{
    class Prj_2 : Access_Specifier_Eg
    {
        static void Main(string[] args)
        {
            Access_Specifier_Eg access2 = new Access_Specifier_Eg();
            access2.publicdata = 67;

            Prj_2 p2 = new Prj_2();
            p2.publicdata = 9;
            p2.protecteddata = 0;
            p2.intprocdata = 15;           
        }
    }
}
