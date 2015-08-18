using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    public class Mortgage :Account,IDeposit
    {
        #region constructor
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }
        #endregion

        #region methods
        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (Customer.GetType().Name.CompareTo("Individuals") == 0)
            {
                if (numberOfMonths <= 6)
                {
                    return 0.0M;
                }
                else
                {
                    return (numberOfMonths - 6) * (this.InterestRate/100);
                }
            }
            else 
            {
                if (numberOfMonths <= 12)
                {
                    return (numberOfMonths) * this.InterestRate * 0.5M;
                }
                return ((12 * (this.InterestRate/100) * 0.5M) + ((numberOfMonths - 12) * this.InterestRate));
            }
        }

        public void DepositMoney(decimal sumToDeposit)
        {
            if (sumToDeposit <= 0)
            {
                throw new ArgumentException("The sum to deposit cannot be less or equal to zero");
            }
            else
            {
                this.Balance += sumToDeposit;
            }
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("Deposit: Client name: {0} - Balance: {1} - Interest rate: {2}", this.Customer.Name, this.Balance, this.InterestRate);
        }
        #endregion
    }
}
