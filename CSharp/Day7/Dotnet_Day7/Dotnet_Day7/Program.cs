using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{

    abstract class Shapes
    {
        public int sample { get; set; }
        //abstract method
        abstract public int Area();
        public void method1() { }
        public virtual void DrawShape()
        {
            Console.WriteLine("It is the Shape");
        }
    }

    class Square : Shapes
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }

        public override void DrawShape()
        {
            base.DrawShape();
            Console.WriteLine("This is Square Shape");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shapes s = new Square(4);
            Console.WriteLine("Area of Square : " + s.Area());
            s.DrawShape();
            Console.Read();               
            
        }
    }
}
