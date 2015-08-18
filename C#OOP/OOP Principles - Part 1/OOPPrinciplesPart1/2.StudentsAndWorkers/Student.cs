namespace _2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        #region fields
        private byte grade; 
        #endregion

        #region constructors
        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        #endregion

        #region properties
        public byte Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                if (value <= 1 && value > 6)
                {
                    throw new ArgumentException("The grades must be between 2 and 6! ");
                }
                else
                {
                    this.grade = value;
                }
            }
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("Name: {0} {1}, Grade: {2} ",this.FirstName,this.LastName,this.Grade);
        }
        #endregion
    }
}
