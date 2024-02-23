using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day3
{
    class Arrays_Eg
    {
        public void SingleDimension()
        {
            int[] arr = new int[5] { 6, 23, 1, 45, 12 };
            Console.WriteLine("The Length of the Array is{0}",arr.Length);
            Console.WriteLine("Before Array Sort");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            System.Array.Sort(arr);

            Console.WriteLine("After Array Sort");
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr.Rank);
        }

        public void TwoDimension()
        {
            int[,] myarray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(myarray[1,1]);
            //1st loop to iterate rows
            for(int i=0;i<2;i++)
            {
                //loop 2 for column values within the above row
                for(int j=0; j<3;j++)
                {
                    Console.Write(myarray[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            //1. declare jagged array of 2 rows
            int[][] myjagg = new int[2][];

            //let us now set the size for each row
            myjagg[0] = new int[3];
            myjagg[1] = new int[2];

            //2. let us initialize the jagged array
            myjagg[0][0] = 2;
            myjagg[0][1] = 4;
            myjagg[0][2] = 6;

            myjagg[1][0] = 1;
            myjagg[1][1] = 3;

            //example to initialize the jagged array in a different way

            int[][] jagg2 =
            {
                new int[]{5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}
            };

            // to display the elements of the above jagged array
            //we need 2 loops
            for(int i=0; i < jagg2.Length;i++)
            {
                Console.WriteLine("Number of Elements at Row : " + i + " is" + " " + jagg2[i].Length);
                //inner loop
                for(int j=0; j < jagg2[i].Length;j++)
                {
                    Console.Write(jagg2[i][j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
    class Program_Arrays
    {
        static void Main(string[] args)
        {
            Arrays_Eg arreg = new Arrays_Eg();
            //  arreg.SingleDimension();
            //  Console.WriteLine("-------------------");
            //  arreg.TwoDimension();
            // Console.WriteLine("------Jagged Array ------");
            //  arreg.JaggedArray();
            // Strings_Eg.String_Ops();
            MethodsnParameters mp = new MethodsnParameters();
            //int number = 10;
            //mp.CallByValue(number); //caller function
            //Console.WriteLine($"The Value of number is {number}");
            //mp.CallByRef(ref number);
            //Console.WriteLine($"The Value of number is {number}");

            int total = 0, prod, difference, division;
           total= mp.Calculate_Function(15, 10, out difference, out prod, out division);
           Console.WriteLine($"Sum of 15 and 10 is {total}, Product is {prod}, Difference is {difference} and the Division is {division}");
            Console.WriteLine("******Params Example********");
            total= mp.AddElements(); //calling the function with zero arguments
            Console.WriteLine("The Total is {0}",total);
            Console.WriteLine("----------");
            total = mp.AddElements(5);  //calling the function with one argument
            Console.WriteLine("The Total is {0}", total);
            Console.WriteLine("----------");
            total = mp.AddElements(2, 3, 5, 8, 1, 3);
            Console.WriteLine("The Total is {0}", total);

            Console.WriteLine("--------Second Params Example Output------");
            mp.Params_method2();

            int[] testarray = new int[] { 10, 20, 30 };
            mp.Params_method2(testarray);
            mp.Params_method2(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);

            mp.Params_3(1, 2.5f);
            mp.Params_3(5, 5.5f, 12.25, 20.56, 34.8);
            Console.ReadKey();
        }
    }
}
