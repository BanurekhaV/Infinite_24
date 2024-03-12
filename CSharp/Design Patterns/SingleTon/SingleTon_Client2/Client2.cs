using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleTon;

namespace SingleTon_Client2
{
    class Client2
    {
        static void Main(string[] args)
        {
            SingleTonPattern training = SingleTonPattern.GetInstance();
            training.Show("This is a dotnet training..");
            Console.Read();
        }
    }
}
