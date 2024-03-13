using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DIPattern_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. create an ioc object
            UnityContainer uc = new UnityContainer();

            //2. register all services
            uc.RegisterType<IProducts, DataLayer.DataLogic>(); 
            uc.RegisterType<IOrders, OrderClass>();

            //3.
            BusinessLayer.BusinessLogic bl = uc.Resolve<BusinessLayer.BusinessLogic>();

            ////4. Invoking the DI enabled members
            string finalresult=bl.Insert();
            Console.WriteLine("This was the message from the Implementing class" + " "+ finalresult);
            bl.Display();
            Console.Read();
        }
    }


   
}
