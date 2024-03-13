using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern_Unity
{
    class OrderClass : IOrders
    {
        public void DisplayOrders()
        {
            Console.WriteLine("This is the List of Orders Placed..");
        }
    }
}
