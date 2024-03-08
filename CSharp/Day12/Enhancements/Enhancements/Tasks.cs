using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class Account
    {
        double Balance;
        public Account(double bal) { Balance = bal; }
        public void Credit(double amt) { Balance += amt; }

        public void Debit(double amt) { Balance -=amt; }
    }
    class Tasks
    {
        public static void RandomlyUpdate(Account account)
        {
            var rnd = new Random();
            for(int i=0; i<10;i++)
            {
                var amount = rnd.Next(1, 100);
                bool doCredit = rnd.NextDouble() < 0.5;
                if(doCredit)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(amount);
                }
            }
        }

        static void Main()
        {
            var account = new Account(1000);
            var tasks = new Task[50];
            for(int i=0; i<tasks.Length;i++)
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(tasks);
            Console.ReadKey();
        }
    }
}
