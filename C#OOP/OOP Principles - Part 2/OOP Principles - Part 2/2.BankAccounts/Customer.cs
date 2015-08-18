namespace _2.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Customer
    {
        #region fields
        private string name;
        #endregion

        #region constructor
        public Customer(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("The name cannot be null or just a space");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        #endregion
    }
}
