using System;

namespace Enhancements
{
    class ExpressionBodied_Eg
    {
        public int SquareArea(int side) => side * side;
        public int calcOps(int a, int b) => ((a + b) + (a - b) + (a * b) + (a / b));
    }
    class TestExpression
    {
        static void Main()
        {
            ExpressionBodied_Eg ebe = new ExpressionBodied_Eg();
            Console.WriteLine("Area of Square Calculation");
            Console.WriteLine("Enter a value for side :");
            int side = Convert.ToInt32(Console.ReadLine());
            int Area = ebe.SquareArea(side);
            Console.WriteLine($"Area of the Square is {Area}");
            Console.Read();
        }
    }
}
