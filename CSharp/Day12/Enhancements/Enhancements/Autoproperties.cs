using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class Autoproperties
    {
       // earlier way of declaration of auto properties
        public string Name { get; set; }
        public string Id { get; }

        public string Myname { get; set; } = "Banurekha";

        //or
        public string Myname1 { get; } = "Banurekha";

        public string accountno { get; private set; } = "ac1010";

        public string dept { get; protected set; } = "HR";
    }

    class derived : Autoproperties
    {
        public void checkproperties()
        {
            Autoproperties ap = new Autoproperties();
            derived d = new derived();

            //with parent object, we cannot set private and protected property
            //ap.accountno = "Acc100";
           // ap.dept = "IT";

            //with derived class object, we can set protected property
            d.dept = "Accounts";
        }
    }
}
