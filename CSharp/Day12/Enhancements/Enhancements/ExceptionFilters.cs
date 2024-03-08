using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class ExceptionFilters
    {
        static void Main()
        {
            try
            {
              //  int number = 0;
               // int x = 5 / number;
                int[] a = new int[5];
                a[10] = 15;
            }
            //catch(Exception e) when (DateTime.Now.DayOfWeek != DayOfWeek.Friday)
            //{
            //    DoSomeTask();
            //}
            catch (Exception e) when (e.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                //Executing some other task
                DoSomeTask();
            }

            Console.Read();
        }

        public static void DoSomeTask()
        {
            Console.WriteLine("A new Task on Hand..");
        }
    }
}
