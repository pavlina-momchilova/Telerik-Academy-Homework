namespace _2.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank
    {
        #region fields
        private string name;
        private Dictionary<string,Account> accounts;
        #endregion

        #region constructor
        public Bank(string name)
        {
            this.Name = name;
            this.Accounts = new Dictionary<string, Account>();
        }
        #endregion

        #region properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be null or just a space!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public Dictionary<string, Account> Accounts
        {
            get
            {
                return this.accounts;
            }
            private set
            {
                this.accounts = value;
            }
        }
        #endregion

        #region methods
        public void AddAccount(Account account)
        {
            bool addAccount = true;
            foreach (var ac in this.Accounts)
            {
                if (ac.Key == account.Customer.Name && ac.Value.GetType().Name == account.GetType().Name)
                {
                    addAccount = false;
                    break;
                }
            }
            if (addAccount == true)
            {
                this.Accounts.Add(account.Customer.Name, account);
            }
            else
            {
                Console.WriteLine("this account already exists");
            }
        }
        public void RemoveAccount(Account account)
        {
            this.Accounts.Remove(account.Customer.Name);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("BANK {0} : \nAccounts:\n {1}",this.Name,string.Join("\n ",accounts));
        }
        #endregion
    }
}
