using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day2
{
    class ProgramConstructs
    {
        //if else
        public void CheckGrades()
        {
            char grade;
            Console.WriteLine("Enter your Grade O/A/B/C/D");
            grade = Convert.ToChar(Console.ReadLine());
            if(grade=='O')
                Console.WriteLine("Outstanding");
            else if(grade == 'A')
                    Console.WriteLine("Excellent");
            else if (grade == 'B')
                Console.WriteLine("Very Good");
            else if (grade == 'C')
                Console.WriteLine("Good");
            else if (grade == 'D')
                Console.WriteLine("Can Improve");
            else
                Console.WriteLine("Invalid Grade");
        }

        public void CheckGrades_With_Switch()
        {
            char grade;
            Console.WriteLine("Enter Grade");
            grade = Convert.ToChar(Console.ReadLine());

            switch(grade)
            {
                case 'O':
                    Console.WriteLine("outstanding");
                    break;
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Good");
                    break;
                case 'D':
                    Console.WriteLine("Can Improve");
                    break;
                default:
                    Console.WriteLine("invalid Grade");
                    break;
            }
        }

        static void Main()
        {
            ProgramConstructs pc = new ProgramConstructs();
            pc.CheckGrades();
            pc.CheckGrades_With_Switch();
            Console.Read();
        }
    }
}
