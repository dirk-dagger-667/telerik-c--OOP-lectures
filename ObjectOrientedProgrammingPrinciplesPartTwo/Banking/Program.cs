using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var differentAccounts = new Account[]
            {
                new Loan(new Customer(true), 700m, 17.5m, 6),
                new Deposit(new Customer(false), 1500m, 12.3m, 13),
                new Mortgage(new Customer(true), 600m, 14m, 14)
            };

            foreach (var item in differentAccounts)
            {
                Console.WriteLine(item.GetType() + " " + item.CalculateInterestForAPeriodOfMonths());
            }
        }
    }
}
