using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Mortgage : Account, IDepositMoney
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate, int periodOfMonths): base(customer, balance, interestRate, periodOfMonths)
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
                if (this.PeriodOfMonths <= 12)
                {
                    return (base.CalculateInterestForAPeriodOfMonths() / 2);
                }
                else
                {
                    return base.CalculateInterestForAPeriodOfMonths() - ((12 * this.InterestRate) / 2);
                }
            }
            else
            {
                if (this.PeriodOfMonths <= 6)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterestForAPeriodOfMonths() - 6 * this.InterestRate;
                }
            }
        }
    }
}
