using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern_Unity.DataLayer
{
    class DataLogic : IProducts
    {
        public string InsertProducts()
        {
            string str = "DI Injected Successfully";
            Console.WriteLine(str);
            return str;
        }
    }
}
