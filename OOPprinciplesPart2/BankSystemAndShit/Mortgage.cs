namespace BankSystemAndShit
{
    using System;
    public class Mortgage : Account, IAccount
    {
        public Mortgage(Customer customer, decimal montlyInterest)
            :base(customer, montlyInterest)
        {

        }
        public Mortgage(Customer customer, decimal balance, decimal monthlyInterest)
            :base(customer, balance, monthlyInterest)
        {

        }

        public override decimal CalcInterest(int months)
        {
            if (months >= 0)
            {
                if (this.Customer.GetType().Name == "Individual")
                {
                    if (months <= 6)
                    {
                        return 0m;
                    }
                    else
                    {
                        return (months - 6) * this.MonthlyInterestRate;
                    }
                }
                else
                {
                    if (months <= 12)
                    {
                        return 12 * this.MonthlyInterestRate / 2;
                    }
                    else
                    {
                        return 12 * this.MonthlyInterestRate / 2 + (months - 12) * this.MonthlyInterestRate;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("monthes cannot be negative");
            }
        }
    }
}
