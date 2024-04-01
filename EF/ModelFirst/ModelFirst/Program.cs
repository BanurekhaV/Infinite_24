using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static Model1Container db = new Model1Container();
        static void Main(string[] args)
        {
            AddCar();
            ShowCars();
            Console.Read();           
        }

        public static void AddCar()
        {
            var car = new Car
            {
                CarName = "Venue",
                CarCost = 2700000,
                ManufacturerId=2,
            };
            db.Cars.Add(car);
            db.SaveChanges();
        }
        public static void ShowCars()
        {
            var car = db.Cars.ToList();

            foreach(var c in car)
            {
                Console.WriteLine(c.CarID + " "+ c.CarName+" "+ c.CarCost);
            }
        }
    }
}
