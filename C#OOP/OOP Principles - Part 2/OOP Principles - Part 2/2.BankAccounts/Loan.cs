namespace _2.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Loan:Account,IDeposit
    {
        #region constructor
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }
        #endregion

        #region methods
        public override decimal CalculateInterest(decimal numberOfMonths)
        {
            if (Customer.GetType().Name.CompareTo("Individuals") == 0)
            {
                if (numberOfMonths <= 3)
                {
                    return 0.0M;
                }
                else
                {
                    return (numberOfMonths - 3) * (this.InterestRate/100);
                }
            }
            else
            {
                if (numberOfMonths <= 2)
                {
                    return 0.0M;
                }
                else
                {
                    return (numberOfMonths - 2) * (this.InterestRate/100);
                }
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
            return String.Format("Deposit: Client name: {0} - Balance: {1} - Interest rate: {2}", this.Customer.Name, this.Balance,this.InterestRate);
        }
        #endregion
    }
}
