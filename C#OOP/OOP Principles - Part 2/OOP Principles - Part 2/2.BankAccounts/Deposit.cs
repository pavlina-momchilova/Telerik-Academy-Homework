using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BankAccounts
{
    class Deposit :Account,IWithdraw,IDeposit
    {
        #region constructor
        public Deposit(Customer client, decimal balance, decimal interestRate)
            : base(client, balance, interestRate)
        {

        }
        #endregion

        #region methods
        public void WithdrawMoney(decimal SumToWithdraw)
        {
            if (SumToWithdraw <= 0)
            {
                throw new ArgumentException("Sum to withdraw cannot be less or equal to zero ");
            }
            else
            {
                this.Balance -= SumToWithdraw;
            }
        }

        public void DepositMoney(decimal sumToDeposit)
        {
            if (sumToDeposit <= 0)
            {
                throw new ArgumentException("Sum to Deposit cannot be less or equal to zero ");
            }
            else
            {
                this.Balance+=sumToDeposit;
            }

        }

        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (this.Balance >= 1000.0M)
            {
                return (this.InterestRate/100) * numberOfMonths;
            }
            return 0.0M;
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
