using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class QueryExpressions
    {
        public static int year = 2016;
        static void Main()
        {
            int[] intVal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query Expression to find all odd numbers from the array
            IEnumerable<int> OddVal = from ov in intVal
                                      where (ov % 2) != 0
                                      select ov;

            foreach (int val in OddVal)
            {
                Console.WriteLine(val);
            }

            // LiteralImprovements();
            // DictionaryInitializers();
            Console.WriteLine(LeapYr_with_NoExp());
            Console.WriteLine();

            Console.WriteLine(LeapYr_With_Exp());
            Console.WriteLine();
            Console.WriteLine(LeapYr_with_Exp());
            Console.Read();
        }
        public static void LiteralImprovements()
        {
            //Literal Improvements
            var lit1 = 47843_56789_0123_456;
            var lit2 = 0xa3_7e;
            var lit3 = 1100_0110_0010;

            Console.WriteLine(lit1 + " " + lit2 + " " + lit3);
        }

        public static void DictionaryInitializers()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Anne","Prj1" },
                {"Bunty","Prj1" },
                {"Sweety","Prj2" },
                {"Charlie","Prj3" },
            };

            Dictionary<string, string> dict1 = new Dictionary<string, string>()
            {
                ["Anne"] = "Prj1",
                ["Bunty"] = "Prj1",
                ["Sweety"] = "Prj2",
            };

            Console.WriteLine(@"Dictionary Initializers\n
                 List of Employees\n");
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine($"Name  : {kvp.Key} and Project {kvp.Value}");
            }
        }

        //without expression bodied members
        public static string LeapYr_with_NoExp()
        {
            return "\n Is " + year + " a Leap Year ? :" + DateTime.IsLeapYear(year);
        }

        //with expression bodied members //eg 1.
        public static string LeapYr_With_Exp()=> "\n Is " + year + " a Leap Year ? :" + DateTime.IsLeapYear(year);
        // 2
        public static string LeapYr_with_Exp()=>$"\n Is " + year + " a Leap Year? :" + DateTime.IsLeapYear(year);
    }
}
    

