namespace BankSystemAndShit
{
    using System;
    public class Deposit : Account, IAccount, IWithdrawable
    {
        public Deposit(Customer customer, decimal montrlyInterest)
            :base(customer, montrlyInterest)
        {

        }
        public Deposit(Customer customer, decimal balance, decimal montrlyInterest)
            : base(customer, balance, montrlyInterest)
        {

        }

        public override decimal CalcInterest(int months)
        {
            if (this.Balance <= 1000)
            {
                return 0m;
            }
            else
            {
                return this.MonthlyInterestRate * months;
            }
        }
        public void WithdrawMoney(decimal amountOfMoney)
        {
            if (this.Balance <= amountOfMoney)
            {
                throw new InvalidOperationException("You have less money in the balance than the reqeusted ammount for withdrawel");
            }
            else
            {
                this.Balance -= amountOfMoney;
            }
        }
    }
}
