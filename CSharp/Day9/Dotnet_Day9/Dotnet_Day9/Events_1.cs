using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    public delegate string EventDelegate(string str);
    class Events_1   //publisher class
    {
        //decl an event 

        event EventDelegate ourEvent; //decl. an event for a delegate type

        public Events_1()
        {
            this.ourEvent += new EventDelegate(this.WelcomeUser);
            this.ourEvent += new EventDelegate(this.SomeFunction);
        }

        public string WelcomeUser(string Uname)
        {
            return "Welcome User : " + " " + Uname;
        }

        public string SomeFunction(string msg)
        {
            return msg + " " + "Hope You are enjoying todays Session ..";
        }

        public static void Main()
        {
            Events_1 eventobj = new Events_1();
            string resultstr = eventobj.ourEvent("Infinite Associates"); //raising the event
            Console.WriteLine(resultstr);
            Console.Read();
        }
    }
}
