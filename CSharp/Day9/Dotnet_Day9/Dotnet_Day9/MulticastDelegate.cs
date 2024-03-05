using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    public delegate void MultiDelegate();

    public delegate int MultiDelegate2(int n);
    class MulticastDelegate
    {
        static int p;
        public static void Method1()
        {
            Console.WriteLine("Method 1 Invoked..");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 Invoked..");
        }

        public static void Method3()
        {
            Console.WriteLine("Method 3 Invoked..");
        }

        //methods to see multicasting of delegates with return type

        public int Square(int x)
        {
            p = x * x;
            return p;
        }

        public int Triple(int x)
        {
            p = x * x * x;
            return p;
        }
        static void Main()
        {
            //1. one way of multicasting
            MultiDelegate md1, md2, md3, md4;
            md1 = new MultiDelegate(Method1);
            md2 = new MultiDelegate(Method2);
            md3 = new MultiDelegate(Method3);
            md4 =  md2 + md3 + md1 ;
            md4();
            Console.WriteLine("-----------");
            md4 = md2 + md1 - md3;
            md4();
            Console.WriteLine("Option 2 of Multicasting");
            //2. 
            MultiDelegate mdel = new MultiDelegate(Method1);
            mdel += Method2;
            mdel += Method3;

            mdel();

            mdel -= Method1;
            mdel();

            Console.WriteLine("-----Multidelegates with Return Type");
            MulticastDelegate obj = new MulticastDelegate();
           
            MultiDelegate2 del_withret = new MultiDelegate2(obj.Square);
           del_withret += obj.Triple;

            int result = del_withret(5);
            
            Console.WriteLine("Result is : " + result);

            //without multicast


            //MultiDelegate2 del_withret2 = new MultiDelegate2(obj.Triple);
            //int result2 = del_withret2(5);
            //Console.WriteLine(result2);
            Console.Read();

        }
    }
}
