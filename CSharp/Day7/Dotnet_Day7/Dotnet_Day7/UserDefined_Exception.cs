using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    //define an exception class

    class VotingException : ApplicationException
    {
        public VotingException(string msg) : base(msg)
        {

        }
    }

    class Vote
    {
        int age;

        public void AcceptAge()
        {
            Console.WriteLine("Enter your Age :");
            age = Convert.ToInt32(Console.ReadLine());

            if(age<=18)
            {
                throw (new VotingException("Age should be greater than 18 to Vote"));
            }
            else
                Console.WriteLine("Thanks for Voting...");
        }
    }
    class UserDefined_Exception
    {

        static void Main()
        {
            Vote vote = new Vote();
            try
            {
                vote.AcceptAge();
            }
            catch(VotingException ve)
            {
                Console.WriteLine(ve.Message);
            }

            Console.Read();
        }
    }
}
