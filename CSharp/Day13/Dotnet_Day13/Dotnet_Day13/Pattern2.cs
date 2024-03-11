using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    public class Shape
    {
        public const float PI = 3.14f;
    }

    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; }
        public double Breadth { get; }

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }        
    }

    class Triangle : Shape
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double base1, double height)
        {
            Base = base1;
            Height = height;
        }
    }
    class Pattern2
    {
        public static void DisplayArea(Shape shape)
        {
            if (shape is Circle)
            {
                Circle c = (Circle)shape;
                Console.WriteLine("Area of the citcle is :" + c.Radius * c.Radius * Shape.PI);
            }
            else if (shape is Rectangle)
            {
                Rectangle r = (Rectangle)shape;
                Console.WriteLine("Area of the Rectangle is :" + r.Length * r.Breadth);
            }
            else if (shape is Triangle)
            {
                Triangle t = (Triangle)shape;
                Console.WriteLine("Area of Triangle is :" + 0.5 * t.Base * t.Height);
            }
            else
            {
                throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            }
        }

        public static void DisplayArea_withSwitch(Shape shape)
        {
            switch(shape)
            {
                case Rectangle r when r.Length == r.Breadth:
                    Console.WriteLine("Area of Square is : " + r.Length * r.Breadth);
                    break;
                    case Rectangle r:
                    Console.WriteLine("Area of Rectangle is : " + +r.Length * r.Breadth);
                    break;
                case Circle c:
                    Console.WriteLine("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
                    break;

                case Triangle t:
                    Console.WriteLine("Area of traingle is : " + 0.5 * t.Base * t.Height);
                    break;
                default:
                    throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
            
            }
        }
        static void Main()
        {
            //1.
            //Rectangle square = new Rectangle(6, 6);
            //DisplayArea(square);
            //Rectangle rect = new Rectangle(6, 10);
            //DisplayArea(rect);
            //Circle circle = new Circle(10);
            //DisplayArea(circle);
            //Triangle triangle = new Triangle(10, 7);
            //DisplayArea(triangle);
           
            //2.
            
            Rectangle square = new Rectangle(6, 6);
            DisplayArea_withSwitch(square);
            Rectangle rect = new Rectangle(6, 10);
            DisplayArea_withSwitch(rect);

            //3.

            Products products = new Products() { Pid = "1", ProdName = "Pens", Price = 20, Quantity = 50 };
            Products.Patternmatch(products);
            Console.Read();

        }
    }

    class Products
    {
        public string Pid { get; set; }
        public string ProdName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public static void Patternmatch(Products p)
        {
            switch(p)
            {
                case null:
                    Console.WriteLine("It is a constant pattern");
                    break;
                case Products prod when prod.ProdName.StartsWith("P"):
                    Console.WriteLine("It is a Product ");
                    break;
                case var v: Console.WriteLine(v?.GetType().Name);
                    break;
                default: Console.WriteLine("Wrong object");
                    break;
            }
        }
    }
}
