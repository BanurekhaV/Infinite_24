using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPattern_Unity.BusinessLayer
{
    class BusinessLogic
    {
        IProducts products;
        IOrders orders;

        //Injecting the base types(dependencies) in the constructor of the class(Dependent)

        public BusinessLogic(IProducts ip,IOrders io)
        {
            products = ip;
            orders = io;
        }

        public string Insert() // this call is going to inoke the class that implements the Iproducts
        {
            string s=products.InsertProducts();
            return s;
        }

        public void Display()
        {
            orders.DisplayOrders();
        }
    }
}
