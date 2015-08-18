namespace _2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        #region fields
        private decimal weekSalary;
        private decimal workHoursPerDay;
        #endregion

        #region cnstructors
        public Worker(string firstName,string lastName ,decimal weekSalary,decimal workHoursPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        #endregion

        #region properties
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The week Salary cannot be less than 0");
                }
                else
                {
                    this.weekSalary = value;
                }
            }
        }
        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The work hours per day cannot be less than 0");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }
        #endregion

        #region methods
        public decimal MoneyPerHour()
        {
            decimal daylySalary = this.WeekSalary / 7;
            decimal moneyHour = daylySalary / this.WorkHoursPerDay;
            return moneyHour;
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("Name: {0} {1},  WeekSalary: {2}, WorkHoursPerDay: {3}, Money Per Hour: {4:C2}",this.FirstName,this.LastName,this.WeekSalary,this.WorkHoursPerDay,this.MoneyPerHour());
        }
        #endregion

    }
}
