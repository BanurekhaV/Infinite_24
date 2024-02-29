using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day6
{
    class Indexers_Eg
    {
        private string[] names = new string[3];

        //indexer decl.

        public string this[int f]
        {
            get { return names[f]; }
            set { names[f] = value; }
        }

        public static void Main()
        {
            Indexers_Eg indeg = new Indexers_Eg();
            indeg[0] = "Avinash"; //set the value for names[0]
            indeg[1] = "Basavaraju";
            indeg[2] = "Hemalatha";
            Console.WriteLine(indeg[0] + " " +indeg[1] +" " + indeg[2]);
            Console.ReadLine();
        }
    }
}
