using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    public class SingleTonPattern
    {
        //private field to increment counter every time object is created
        private static int counter = 0;

        //instance object to store the singleton instance
        private static SingleTonPattern spobj = null;

        //public method that returns a singleton object
        public static SingleTonPattern GetInstance()
        {
            if(spobj==null)
            {
                spobj = new SingleTonPattern();
            }
            return spobj;
        }

        //private constructor so that no instantiation is possible outside the class
        private SingleTonPattern()
        {
            counter++;
            Console.WriteLine("Counter Value : " +  " " + counter.ToString());
        }

        //normal instance methods
        public void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }

   
}
