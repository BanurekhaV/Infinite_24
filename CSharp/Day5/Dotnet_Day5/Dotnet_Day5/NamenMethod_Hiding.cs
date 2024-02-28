using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class Parent
    {
        public float data;

        public void Methodhide(string s)
        {
            Console.WriteLine("This is a message from Parent Class {0} ",s);
        }
    }

    class Child:Parent
    {
        //name hiding
        new float data;  // member float data here hides the parent float data

        public Child(float f1, float f2)
        {
            Console.WriteLine(base.data);
            base.data = f1;  //data in Parent class
            data = f2;   //data in Child class
            Console.WriteLine(base.data + " " +data);
        }

        //method hiding
        public new void Methodhide(string s)
        {
            Console.WriteLine("This is a message from Child Class {0} ", s);
        }

        //public void Showdata()
        //{
        //    Console.WriteLine("Data in Base class : {0}", base.data);
        //    Console.WriteLine("Data in Child Class :{0}", data);
        //}
    }
    class NamenMethod_Hiding
    {
        static void Main()
        {
            Child child = new Child(2.2f, 3.3f);
            child.Methodhide("Hello");
            Console.Read();
        }
    }
}
