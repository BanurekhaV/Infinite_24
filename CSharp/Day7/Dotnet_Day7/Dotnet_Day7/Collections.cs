using System;
using System.Collections;

namespace Dotnet_Day7
{
    class Collections
    {
        static void Main()
        {
            // ArrayList_Function();
            // HashTableFunction();
            // SortedListFn();
            //Stackfn();
            QueFn();
            Console.Read();
        }

        public static void ArrayList_Function()
        {
            ArrayList arrlist1 = new ArrayList();
            arrlist1.Add(10);
            arrlist1.Add('g');
            arrlist1.Add("Hi");
            arrlist1.Add(12.10f);
            arrlist1.Add(true);
            arrlist1.Add("Infinite");

            foreach(var x in arrlist1)
            {
                Console.WriteLine(x);
            }

            arrlist1.Add("Ram");
            arrlist1.Add(345.658);
            arrlist1.Add(false);

            arrlist1.Insert(7, "Seetha");

            Console.WriteLine("adding a range of values");
            ArrayList arrlist2 = new ArrayList();
            arrlist2.Add(25);
            arrlist2.Add(6);
            arrlist2.Add(21);
            arrlist2.Add(12);

            arrlist1.AddRange(arrlist2);

            arrlist1.RemoveAt(2);
            Console.WriteLine("-----------");

            //sorting an arraylist with different types
           
            foreach (var x in arrlist1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Count is :{0} and the Capacity is :{1}",arrlist1.Count,arrlist1.Capacity);

            Console.WriteLine("-----List2-----");
            arrlist2.Sort();
            foreach(int x in arrlist2)
            {
                Console.WriteLine(x);
            }
        }

        public static void HashTableFunction()
        {
            Hashtable ht = new Hashtable();
            ht.Add("E001", "Yashika");
            ht.Add("E007", "Vikash");
            ht.Add("E008", "Sanjeev");
            ht.Add("E010", "Simran");
            ht.Add("E002", null);
            ht.Add("E005", "Vikash");
            ht.Add("5", "Banurekha");

            foreach(var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=======");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=====Key and Values=====");
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Search in Hash Table");
            Console.WriteLine("Enter a key to search :");
            string eid = Console.ReadLine();
            if(ht.ContainsKey(eid))
            {
                Console.WriteLine(eid + "=" + ht[eid]);
            }   
            else
                Console.WriteLine(eid + "does not exists");
        }

        public static void SortedListFn()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "Oracle");
            sl.Add("vb", "Visual Basic");
            sl.Add("cs", "CSharp");
            sl.Add("asp", "Asp.Net");

            foreach(DictionaryEntry de in sl)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }
        }

        public static void Stackfn()
        {
            Stack st = new Stack();
            st.Push(12);
            st.Push(23);
            st.Push("AAA");

            foreach(object obj in st)
            {
                Console.WriteLine(obj);
            }

            st.Pop();
            Console.WriteLine(st.Peek()); 
        }

        public static void QueFn()
        {
            Queue q = new Queue();
            q.Enqueue("Csharp.Net");
            q.Enqueue(123);
            q.Enqueue("Sql");

            foreach(var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

    }
}
