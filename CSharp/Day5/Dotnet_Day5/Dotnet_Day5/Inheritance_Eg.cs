using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class x
    {
        float secret;
        public int ID;
        protected string XName;
        internal DateTime DOJ;

        public x(int id, string name, DateTime doj)
        {
            ID = id;
            XName = name;
            DOJ = doj;
        }

        public x()
        {
            Console.WriteLine("Hi From X");
        }

    }

    class y : x
    {
        public y()
        {
            Console.WriteLine("Hi from Y");
        }


        public static void Main()
        {
            //y y1 = new y(); //child class/derived class object
            //y1.ID = 1;
            //y1.XName = "Infinite";
            //y1.DOJ = Convert.ToDateTime("13/03/1980");
            //Console.WriteLine(y1.ID + " " + y1.XName + " " + y1.DOJ);

            Inheritance_Eg ihe = new Inheritance_Eg(6);
          //  Derived derived = new Derived(5);
            Derived derived1 = new Derived(5,15);
            Console.Read();
        }
    }
    class Inheritance_Eg
    {
        public int data1;

        public Inheritance_Eg(int n)
        {
            data1 = n;
            Console.WriteLine(data1);
        }

        public Inheritance_Eg() { }
    }

    class Derived : Inheritance_Eg
    {
        new int data1;  //hiding
        public Derived(int var) : base(var)
        {
            Console.WriteLine(data1);
        }
        public Derived(int mynum, int number) : base(number)
        {
            data1 = mynum;
            Console.WriteLine(data1);
        }
    }
}
