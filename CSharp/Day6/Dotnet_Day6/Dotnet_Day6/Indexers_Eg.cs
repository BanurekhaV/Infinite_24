using System;

namespace Dotnet_Day6
{
    class Indexers_Eg
    {
        private string[] names = new string[3];

        //public void setnames()
        //{
        //    for(int i=0; i<names.Length;i++)
        //    {
        //        names[i] = Console.ReadLine();
        //    }
        //}

        //indexer decl.

        public string this[int f]
        {
            get { return names[f]; }
            set { names[f] = value; }
        }

        public static void Main()
        {
            //Indexers_Eg indeg = new Indexers_Eg();
            //indeg[0] = "Avinash"; //set the value for names[0]
            //indeg[1] = "Basavaraju";
            //indeg[2] = "Hemalatha";

            //Console.WriteLine(indeg[0] + " " +indeg[1] +" " + indeg[2]);

            // indeg.setnames();

            Indexers_Eg1 indeg1 = new Indexers_Eg1();
            Console.WriteLine(indeg1["Thur"]);

            Console.WriteLine(indeg1["Myday"]);
            Console.ReadLine();
        }
    }

    class Indexers_Eg1
    {
        string[] days = { "Sun", "Mon", "Tue", "Wed", "Thur", "Fri", "Sat" };

        int GetDay(string day)
        {
            for(int i=0; i<days.Length;i++)
            {
                if(days[i]==day)
                {
                    return i;
                }
            }
            Console.WriteLine("Argument must be like \"Sun\",\"Mon\",etc.");
            return -1;
        }

        public int this[string d]
        {
            get
            {
                return (GetDay(d));
            }
        }
    }
}
