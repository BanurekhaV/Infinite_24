using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    class Events_2
    {
        int data = 5;
        public delegate void NumberManipulator(int x);
        public event NumberManipulator ChangeNumberEvent;

        public Events_2(int n)
        {
            this.ChangeNumberEvent += new NumberManipulator(this.onChangeNum); //registering an event with the delegate and hence a function
            setValue(n);
        }

        public void onChangeNum(int x)  // event handler
        {
            Console.WriteLine($"Event Raised and the value from {data} is being changed to {x}");
        }

        public void setValue(int n)   //responsible for raising an event
        {
            if(data !=n)   //when data's value and the input value are different
            {
                ChangeNumberEvent(n);
            }
            else
            {
                Console.WriteLine("No Changes in the Value .. hence no Event");
            }
        }
    }

    class TestEvent
    {
        static void Main()
        {
            Events_2 eObj = new Events_2(5);
            eObj.setValue(15); // Event will be raised
            eObj.setValue(20); //""""
            eObj.setValue(5); // no event

            Console.Read();
        }
    }
}
