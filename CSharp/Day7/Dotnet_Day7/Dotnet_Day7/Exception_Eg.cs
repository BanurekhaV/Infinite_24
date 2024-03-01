using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Exception_Eg
    {
        static void Main()
        {
            int a, b, c;
            //Console.WriteLine("\nChecked Output : {0}",OverFlowExample.CheckOverFlow());
            //Console.WriteLine("===========");
            //Console.WriteLine("\nUnChecked Output : {0}", OverFlowExample.UnCheckOverFlow());

            try
            {
                Console.WriteLine("Enter 2 nos :");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                int[] arr = { 1, 2, 3, 4 };
                Console.WriteLine(arr[6]);
                Console.WriteLine(c);
                Console.Read();
            }
            
            catch (FormatException fe)
            {
                Console.WriteLine("Please enter only numbers");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message + de.StackTrace + de.Source);
            }
            //when we are not particular to catch a specific exception
            //then we can catch the base class exception(Exception class)
            //this catch should be the last catch
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.. Please try after sometime");
            }

            //finnaly gets executed whether there is an exception or not
            finally
            {
                Console.WriteLine("Reached Finally");
               
                Console.Read();
            }
        }
    }

    class OverFlowExample
    {
        static int maxInt = 2147483647;

        //checked expression

        public static int CheckOverFlow()
        {       
            int x = 0;
            try
            {
                x = checked(maxInt + 10); // this line raises an exception
            }
            catch(OverflowException oe)
            {
                //information about the error
                Console.WriteLine("Checked : " + oe.ToString());
            }
            return x;
        }

        public static int UnCheckOverFlow()
        {
            int x = 0;
            try
            {
                x = maxInt + 10; // this line raises an exception
            }
            catch (OverflowException oe)
            {
                //information about the error
                Console.WriteLine("UnChecked : " + oe.ToString());
            }

            //overflow is suppressed
            return x;
        }
    }
}
