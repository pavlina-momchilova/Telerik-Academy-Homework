using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public abstract class Account
    {
        #region fields
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        #endregion

        #region constructors
        public Account(Customer customer, decimal balance, decimal rate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = rate;
        }
        #endregion

        #region properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance cannot be less than null");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest Rate cannot be less than null");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }
        #endregion

        #region methods
        public abstract decimal CalculateInterest(decimal numberOfMonths);
        #endregion
    }
}
