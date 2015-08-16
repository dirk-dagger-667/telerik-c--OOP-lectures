using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Loan : Account, IDepositMoney
    {
        public Loan(Customer customer, decimal balance, decimal interestRate, int periodOfMonths): base(customer, balance, interestRate, periodOfMonths)
        {

        }

        public decimal DepositMoney(decimal value)
        {
            return this.Balance -= value;
        }

        public override decimal CalculateInterestForAPeriodOfMonths()
        {
            if (this.Customer.IsIndividual == false)
            {
                if (this.PeriodOfMonths <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestForAPeriodOfMonths() - 2 * this.InterestRate;
                }
            }
            else
            {
                if (this.PeriodOfMonths <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestForAPeriodOfMonths() - 3 * this.InterestRate;
                }
            }
        }
    }
}
