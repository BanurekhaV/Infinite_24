using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Your Card Choice (MoneyBack/Titanium/Platinum)");
            string ctype = Console.ReadLine();
            CreditCard cardDetails = CreditCardFactory.GetCreditCard(ctype);
           

            if(cardDetails!=null)
            {
                Console.WriteLine("CardType : {0}", cardDetails.GetCardType());
                Console.WriteLine("Card Limit :{0}", cardDetails.GetCreditLimit());
                Console.WriteLine("Annual Charges :{0}",cardDetails.GetAnnualCharges());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }

            Console.Read();
        }
    }
}
