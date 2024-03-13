using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
{
   public class Accounts
    {
        string AccountNo;
        float Balance=1000;

        public Accounts(string accno)
        {
            this.AccountNo = accno;
        }

        public float CheckBalance()
        {
            return Balance;
        }

        public void Deposit(float amt)
        {
            Balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (Balance >= amt)
                Balance -= amt;
            else
                throw new Exception("Not Enough Funds to Withdraw");
        }
    }
}
