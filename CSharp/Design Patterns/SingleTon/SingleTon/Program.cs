using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTonPattern trainer = SingleTonPattern.GetInstance();
            trainer.Show("This message is from the Trainer..");

            //let us create another singleton object
            SingleTonPattern trainee = SingleTonPattern.GetInstance();
            trainee.Show("This message is from the Trainee..");

            SingleTonPattern manager = SingleTonPattern.GetInstance();
            manager.Show("This is the manager invoking the object for the 3rd time..");
            Console.Read();
        }
    }
}
