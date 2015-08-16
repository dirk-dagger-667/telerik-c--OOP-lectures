namespace BankSystemAndShit
{
    using System;
    public class Loan : Account, IAccount
    {
        private readonly int monthsWithoutInterestForIndividuals = 3;
        private readonly int monthsWithoutInterestForCompanies = 2;
        public Loan(Customer customer, decimal monthlyInterest)
            : base(customer, monthlyInterest)
        {

        }
        public Loan(Customer customer, decimal balance, decimal montlyInterest)
            : base(customer, balance, montlyInterest)
        {

        }

        public override decimal CalcInterest(int months)
        {
            if (this.Customer.GetType().Name == "Individual")
            {
                if (months > monthsWithoutInterestForIndividuals)
                {
                    return (months - monthsWithoutInterestForIndividuals) * this.MonthlyInterestRate;    
                }
                else
                {
                    return 0m;
                }
            }
            else
            {
                if (months > monthsWithoutInterestForCompanies)
                {
                    return (months - monthsWithoutInterestForCompanies) * this.MonthlyInterestRate;
                }
                else
                {
                    return 0m;
                }
            }
        }
    }
}
