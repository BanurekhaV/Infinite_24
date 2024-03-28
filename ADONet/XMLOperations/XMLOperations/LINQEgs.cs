using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLOperations
{
    class LINQEgs
    {
        static void Main()
        {
            //AggregateFunctions.fncount();
            //AggregateFunctions.Aggregate1();
            //AggregateFunctions.Aggregate2();
            // ElementOperators.Element_At();
            // ElementOperators.Positional_Operator();
            //ElementOperators.SingleOperators();
            // Others.OrderListEg();
            Others.GrpBy();
            Console.Read();
        }

    }
    class ElementOperators
    {
        public static void Element_At()
        {
            string[] flowers = { "Rose", "Lily", "Jasmine", "Marigold", "Hibiscus" };
            Console.WriteLine(flowers.ElementAt(4));

            // Console.WriteLine(flowers.ElementAt(5)); throws an exception

            Console.WriteLine(flowers.ElementAtOrDefault(5));
        }

        public static void Positional_Operator()
        {
            string[] flowers = { "Rose", "Lily", "Jasmine", "Marigold", "Hibiscus" };
            Console.WriteLine(flowers.First());
            Console.WriteLine(flowers.Last());

            string[] empty = { };
            //Console.WriteLine(empty.First());
            // Console.WriteLine(empty.Last());
            Console.WriteLine(empty.FirstOrDefault());

            //  Console.WriteLine(empty.Last());
            Console.WriteLine(empty.LastOrDefault());
        }

        public static void SingleOperators()
        {
            string[] names1 = { "Ashoka" };
            string[] names2 = { "Narendra Modi", "JoeBiden", "Donald", "Obama" };
            string[] names3 = { };

            Console.WriteLine(names1.Single());

            // Console.WriteLine(names2.Single()); //throws exception

            // Console.WriteLine(names3.Single());  //throws exception

            Console.WriteLine(names3.SingleOrDefault());
            Console.WriteLine(names1.SingleOrDefault());
            //  Console.WriteLine(names2.SingleOrDefault()); //throws exception

            Console.WriteLine("----------");
            //sort the collection
            var sortednames = names2.OrderByDescending(n => n);

            foreach (var v in sortednames)
            {
                Console.WriteLine(v);
            }
        }
    }

    class Others
    {
        public static void OrderListEg()
        {
            string[] capitals = { "Delhi", "Ambala", "Mumbai", "Agra", "Bangalore",
           "Hyderabad","Nagpur","Chennai","abcd" };

            var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            foreach(var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("------------");

            var result1 = capitals.OrderByDescending(c => c.Length).ThenByDescending(c => c);

            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }

        }

        public static void GrpBy()
        {
            int[] numbers = { 10, 15, 20, 25, 30, 35, 42 };
            var result = numbers.GroupBy(num => (num % 10 == 0));

            foreach(IGrouping<bool,int> grp in result)
            {
                if(grp.Key==true)
                {
                    Console.WriteLine("Group 1 : Divisible by 10");
                }
                else
                    Console.WriteLine("Group 2 : Not Divisible by 10");

                foreach(int n in grp)
                {
                    Console.WriteLine(n);
                }
            }
        }

    }
        class AggregateFunctions
        {
            public static void fncount()
            {
                string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange", "White" };
                var count = colors.Count();

                int[] numbers = { 23, 2, 34, 56, 78, 45 };
                var maxnum = numbers.Max();
                Console.WriteLine($"Count is {count} and max number is {maxnum}");
            }

            //aggregation by simple accumulation
            public static void Aggregate1()
            {
                var numbers = new int[] { 1, 2, 3, 4, 5 }; //{2,3,4,5} {6,4,5}{24,5}{120}
                var result = numbers.Aggregate((x, y) => x * y);
                Console.WriteLine("Aggregated value :{0}", result);
            }

            //aggregation with seed value

            public static void Aggregate2()
            {
                var numbers = new int[] { 1, 2, 3, 4, 5 };//{10,2,3,4,5}
                var result = numbers.Aggregate(10, (x, y) => x * y);
                Console.WriteLine(result);
            }
        }
    }

