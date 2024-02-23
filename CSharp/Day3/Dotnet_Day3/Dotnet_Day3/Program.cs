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
    class Program
    {
        static void Main(string[] args)
        {
            Arrays_Eg arreg = new Arrays_Eg();
          //  arreg.SingleDimension();
          //  Console.WriteLine("-------------------");
          //  arreg.TwoDimension();
            Console.WriteLine("------Jagged Array ------");
            arreg.JaggedArray();
            Console.ReadKey();
        }
    }
}
