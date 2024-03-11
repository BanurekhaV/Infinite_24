using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };

            //1. calling Calculate iwth tuple return type
            // Tuple<int,double> t = Calculate(values);
            //  Console.WriteLine($"There are :{t.Item1} elements and their sum is {t.Item2}");

            //2. calling Calculate without tuple type
            // var result = Calculate(values);
            // Console.WriteLine($"There are :{result.Item1} elements and their sum is {result.Item2}");

            //3. being able to refer to the return values with proper naes instead of item1,2..
            var result = Calculate(values);
            Console.WriteLine($"There are : {result.count} elements and their sum is{result.sum}");
            //4. explicit names can be given to store the return values
            var(Countresult,Sumresult) = Calculate(values);
            Console.WriteLine($"There are : {Countresult} elements and their sum is {Sumresult}");


            //calling example 2 function
            var res = GetResults(values);
            Console.WriteLine($"Lowest Values :{res.Min}, Highest Value {res.Max} and the Average value is: {res.Average}");
            //deconstruction of tuple using type and name of return values inside the parenthesis
            (double mn, double mx, double avg) = GetResults(values);
            Console.WriteLine($"Lowest :{mn}, Highest : {mx} and Average : {avg}");
            Console.Read();
        }

        //declaring the return type as Tuple<int,double>
        //static Tuple<int,double>Calculate(IEnumerable<double> values)
        //{
        //    int count = 0;
        //    double sum = 0;
        //    foreach(var v in values)
        //    {
        //        count++;
        //        sum += v;

        //    //creating an object of Tuple class by calling the static create method
        //    Tuple<int, double> t = Tuple.Create(count, sum);
        //    return t;
        //}

        //without mentioning the keyword tuple nor creating a tuple object for return
        //static (int, double) Calculate(IEnumerable<double> values)
        //{
        //    int count = 0;
        //    double sum = 0;
        //    foreach (var v in values)
        //    {
        //        count++;
        //        sum += v;
        //    }
        //    return (count, sum);
        //}

        //3. function that can return tuple object values with proper names
        static (int count, double sum) Calculate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0;
            foreach (var v in values)
            {
                count++;
                sum += v;
            }
            return (count, sum);
        }

        //Example 2
        static (double Min,double Max,double Average)GetResults(List<double>values)
        {
            return (values.Min(), values.Max(), values.Average());
        }
    }
}
