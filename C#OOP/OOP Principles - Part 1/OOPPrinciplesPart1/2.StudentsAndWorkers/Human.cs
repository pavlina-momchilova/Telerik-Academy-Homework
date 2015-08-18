namespace _2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        #region fields
        private string firstName;
        private string lastName;
        #endregion

        #region constructors
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        #endregion

        #region properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Fisrt name cannot be empty or null");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Fisrt name cannot be just a space or null");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Last name cannot be empty or null");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Last name cannot be just a space or null");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        #endregion

    }
}
