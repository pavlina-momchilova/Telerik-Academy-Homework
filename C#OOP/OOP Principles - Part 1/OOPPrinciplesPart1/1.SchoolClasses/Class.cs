namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Class : IComment
    {
        #region fields
        private HashSet<Teacher> setOfTeachers;
        private HashSet<Student> setOfStudents;
        private string uniqueTextID;
        #endregion

        #region constructors
        public Class(HashSet<Teacher> teachers, HashSet<Student> students, string uniqueID)
        {
            this.SetOfTeachers = teachers;
            this.SetOfStudents = students;
            this.UniqueTextID = uniqueID;
        }
        #endregion

        #region properties
        public HashSet<Teacher> SetOfTeachers
        {
            get
            {
                return this.setOfTeachers;
            }
            private set
            {
                this.setOfTeachers = value;
            }
        }
        public HashSet<Student> SetOfStudents
        {
            get
            {
                return this.setOfStudents;
            }
            private set
            {
                this.setOfStudents = value;
            }
        }
        public string UniqueTextID
        {
            get
            {
                return this.uniqueTextID;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The uniqueTextID cannot be empty or null!");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The uniqueTextID cannot be empty or null!");
                }
                else
                {
                    this.uniqueTextID = value;
                }
            }
        }
        #endregion

        #region methods
        List<string> classComments = new List<string>();
        public void AddComment(string comment)
        {
            classComments.Add(comment);   
        }

        public void AddTeacher(Teacher newTeacher)
        {
            SetOfTeachers.Add(newTeacher);
        }

        public void RemoveTeacher(Teacher newTeacher)
        {
            SetOfTeachers.Remove(newTeacher);
        }

        public void AddStudent(Student newStudent)
        {
            SetOfStudents.Add(newStudent);
        }

        public void RemoveStudent(Student newStudent)
        {
            SetOfStudents.Remove(newStudent);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("{0},   - Teachers:{1},   - Students:{2}\n ,{3}", this.UniqueTextID, String.Join("\n ", this.SetOfTeachers), String.Join("\n ", this.SetOfStudents), classComments.Count > 0 ? "\nComments: " + String.Join("\n", classComments) : " ");
        }
        #endregion
    }
}
