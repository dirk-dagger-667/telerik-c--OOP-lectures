using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class Deposit : Account, IWithrdrawMoney, IDepositMoney
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate, int periodOfMonths): base(customer, balance, interestRate, periodOfMonths)
        {

        }

        public decimal WithdrawMoney(decimal value)
        {
            return this.Balance += value;
        }

        public decimal DepositMoney(decimal value)
        {
            return this.Balance -= value;
        }

        public override decimal CalculateInterestForAPeriodOfMonths()
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestForAPeriodOfMonths();
            }
        }
    }
}
