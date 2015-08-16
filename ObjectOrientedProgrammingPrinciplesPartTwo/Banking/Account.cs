using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private int periodOfMonths;

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                this.customer = value;
            }
        }
        public decimal Balance
        {
            get { return this.balance; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The balance cannot be less or equal to 0!");
                }
                else
                {
                    this.balance = value;
                }
            }
        }
        public decimal InterestRate
        {
            get { return this.interestRate; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The interest rate cannot be a negative value!");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
        public int PeriodOfMonths
        {
            get { return this.periodOfMonths; }
            set
            {
                if (value <= 0 && value > 12)
                {
                    throw new ArgumentOutOfRangeException("The peroid of time cannot be less or equal to 0 or more than 12!");
                }
                else
                {
                    this.periodOfMonths = value;
                }
            }
        }

        protected Account(Customer customer, decimal balance, decimal interestRate, int periodOfMonths)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.PeriodOfMonths = periodOfMonths;
        }

        public virtual decimal CalculateInterestForAPeriodOfMonths()
        {
            return this.PeriodOfMonths * this.InterestRate;
        }
     
    }
}
