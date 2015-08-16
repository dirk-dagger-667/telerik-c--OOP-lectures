namespace BankSystemAndShit
{
    using System;
    public interface IAccount
    {
        Customer Customer { get; }
        decimal Balance { get; }
        decimal MonthlyInterestRate { get; }
        void DepositMoney(decimal amountOfMoney);
        decimal CalcInterest(int months);
        
    }
}
