namespace StudentsAndCourses
{
    using System;

    public class Student
    {
        private const int MinUniqueNumberValue = 10000;
        private const int MaxUniqueNumberValue = 99999;
        private string name;
        private int uniqueNumber;
        
        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("The name can not be empty!");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < MinUniqueNumberValue || value > MaxUniqueNumberValue)
                {
                    throw new ArgumentException("Unique number is between 10000 and 99999!");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
