using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
//    All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
//Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

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
