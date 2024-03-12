using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFcatoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalfactory = null;
            string sound = null;

            //create respective factory objects
            animalfactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory is " + " " + animalfactory.GetType().Name);
            Console.WriteLine();

            //animal object
            animal = animalfactory.GetAnimal("Shark");
            Console.WriteLine("Animal Chosen is :" + " "+ animal.GetType().Name);

            sound = animal.Speak();
            Console.WriteLine($"The Factory is {animalfactory}, The Animal is {animal} and the sound of the animal is {sound})");
            Console.Read();
        }
    }
}
