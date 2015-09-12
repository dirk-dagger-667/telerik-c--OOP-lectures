//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//    All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.


namespace BankSystemAndShit
{
    using System;
    public abstract class Account : IAccount
    {
        private readonly decimal initialBalance = 5M;
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterest;

        public Account(Customer customer, decimal monthlyBalance)
        {
            this.Customer = customer;
            this.MonthlyInterestRate = monthlyInterest;
            this.Balance = initialBalance;
        }
        public Account(Customer customer, decimal balance, decimal monthlyInterest)
            :this(customer, monthlyInterest)
        {
            this.Balance = balance;
        }
        public Customer Customer
        {
            get 
            {
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("the customer cannot be a null value");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance
        {
            get 
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the balance cannot be a negative number");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterest;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the monthly interest rate cannot be a negative number");
                }
                else
                {
                    this.monthlyInterest = value;
                }
            }
        }

        public void DepositMoney(decimal amountOfMoney)
        {
            this.Balance += amountOfMoney;
        }


        public abstract decimal CalcInterest(int months);

    }
}
