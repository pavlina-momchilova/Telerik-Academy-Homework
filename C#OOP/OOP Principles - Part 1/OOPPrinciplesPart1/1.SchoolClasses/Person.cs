namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Person
    {
        #region fielads
        private string name;
        #endregion

        #region constructors
        public Person(string name)
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
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty or null!");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name cannot be empty or null!");
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
