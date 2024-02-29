using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day6
{
    class Flower 
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine(name + " " + "is in " + color + " Color");
        }
    }

    class FloweVase
    {
        Flower[] flowerobj = new Flower[5];  //aggregation

        //indexer, that keeps track of the array object
        public Flower this[int pos]
        {
            get { return flowerobj[pos]; }
            set { flowerobj[pos] = value; }
        }

    }
    class Indexers_Eg2
    {
        static void Main()
        {
            FloweVase fv = new FloweVase();
            fv[0] = new Flower("Rose", "Red");
            fv[1] = new Flower("Lilly", "White");
            fv[2] = new Flower("Hibiscus", "Pink");
            fv[3] = new Flower("Chrysanthimum", "Yellow");
            fv[4] = new Flower("Marigold", "Orange");

            for(int i=0; i<5;i++)
            {
                fv[i].Display();
            }
            Console.Read();
        }
    }
}
