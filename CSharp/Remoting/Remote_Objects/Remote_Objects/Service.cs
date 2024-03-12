using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Objects
{
    public class Service : MarshalByRefObject
    {
        public string SayHello(string s)
        {
            return "Hello :" + s;
        }

        public int HighestNumber(int n1, int n2)
        {
            int maxnum = (Math.Max(n1, n2));
            Console.WriteLine("Remote Call Executed...");
            return maxnum;
        }
    }
}
