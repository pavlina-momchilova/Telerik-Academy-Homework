namespace _04.StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /*
        Problem 9. Student groups

        Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        Create a List<Student> with sample students. Select only the students that are from group number 2.
        Use LINQ query. Order the students by FirstName.
         
     */
    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string firstName,string lastName, int fn,
            string tel,string email, List<int> marks,int groupNumber)
        {
            this.FirstName=firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public int FN
        {
            get
            {
                return this.fn;
            }
            set
            {
                this.fn = value;
            }
        }
        public string Tel
        {
            get
            {
                return this.tel;
            }
            set
            {
                this.tel = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }
        public override string ToString()
        {
            return String.Format("FirstName: {0}\n LastName: {1}\n FN: {2}\n Tel: {3}\n Email: {4}\n Marks: {5}\n GrouopNumber: {6}\n ", this.FirstName, this.LastName, this.FN, this.Tel, this.Email, string.Join(", ",this.Marks.ToArray()), this.GroupNumber);
        }
    }
}
