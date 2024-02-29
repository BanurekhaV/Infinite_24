using System;
using static System.Console;

namespace Dotnet_Day6
{
    interface IMyInterface1
    {
        void Show(string s);
    }

    interface IMyInterface2
    {
        void Show(string s);
    }
    class Explicit_Interface_Implementation : IMyInterface1, IMyInterface2
    {
       public void Show(string s)
        {
            WriteLine("Parent 1 show" + " " + s);
        }

        void IMyInterface2.Show(string s)
        {
            WriteLine("Parent 2 show" + " " + s);
        }

        public static void Main()
        {
            Explicit_Interface_Implementation EII = new Explicit_Interface_Implementation();

            EII.Show("Class Method");
            //option 1
            ((IMyInterface1)EII).Show("using parent 1 reference typecast");
            ((IMyInterface2)EII).Show("using parent 2 reference typecast");


            //Option 2

            IMyInterface1 im1 = new Explicit_Interface_Implementation();
            IMyInterface2 im2 = new Explicit_Interface_Implementation();

            im1.Show("interface 1");

            im2.Show("interface 2");

            Read();
        }
    }

    //types of classes
    sealed class typesofclasses 
    {
        static int x;
        public void testfunction()
        {
            Console.WriteLine("sealed");
        }
    }

    class a
    {
        public void func1()
        {
            typesofclasses tc = new typesofclasses();
            tc.testfunction();
        }

    }

    public partial class orderform
    {
        public void ordergeneration()
        {

        }
    }
        
}
    

