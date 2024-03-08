using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Example2
{
    class Program
    {
        public void M1()
        {
            Console.WriteLine("Method 1");
        }

        public void M2()
        {
            Console.WriteLine("Method 2");
        }
        public void M3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.M1();
            program.M3();
            program.M4();
            program.M5("This is extension method");
            Console.Read();
        }
    }
}
