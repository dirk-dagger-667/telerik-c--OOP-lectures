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
