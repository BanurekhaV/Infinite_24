using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class QueryExpressions
    {
        static void Main()
        {
            int[] intVal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Query Expression to find all odd numbers from the array
            IEnumerable<int> OddVal = from ov in intVal
                                      where (ov % 2) != 0
                                      select ov;

            foreach(int val in OddVal)
            {
                Console.WriteLine(val);
            }
            Console.Read();
        }
    }
}
