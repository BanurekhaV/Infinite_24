using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class Shapes
    {
        protected float R, L, B;

        public virtual float Area()
        {
            return 3.14f * R * R; //area of a circle
        }
    }

    class Rectangle : Shapes
    {
        public void GetLengthnBreadth()
        {
            Console.Write("Enter Length : ");
            L = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());          
        }

        //overriding the Area() of the Parent/base class

        public override float Area()
        {
            GetLengthnBreadth();
            return L * B;
        }
    }

    class Circle : Shapes
    {
        public void GetRadius()
        {
            Console.Write("Enter Radius : ");
            R = Convert.ToSingle(Console.ReadLine());
        }
    }
    class Override_Eg
    {

        public static void Main()
        {
             Rectangle rect = new Rectangle();
             rect.GetLengthnBreadth();
             Console.WriteLine("Area of Rectangle is :{0}", rect.Area());
             Console.WriteLine("--------------");

             Circle c = new Circle();
             c.GetRadius();
             Console.WriteLine("Area of Circle is :{0}", c.Area());
            
           
            //Shapes s = new Shapes();
            //Console.WriteLine(s.Area());
            //s = new Rectangle();   //co variance
            
            //Console.WriteLine(s.Area());

            Console.Read();
        }
    }
}
