using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   public class CreditCardFactory
    {
        public static CreditCard GetCreditCard(string cardType)
        {
            CreditCard MycardDetails = null;

            if (cardType == "MoneyBack")
            {
                MycardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                MycardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                MycardDetails = new Platinum();
            }
            return MycardDetails;
        }
    }
}
