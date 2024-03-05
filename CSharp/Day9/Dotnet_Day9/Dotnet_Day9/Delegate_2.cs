using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    delegate int Calculator(int n);
    class Delegate_2
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int MulNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            Calculator calc1 = new Calculator(AddNum);
            Calculator calc2 = new Calculator(MulNum);

            calc1(25);
            Console.WriteLine("Value of the Num is :{0}", getNum());

            calc2(5);
            Console.WriteLine("Value of the Num is :{0}", getNum());
            Console.Read();
        }
    }
}
