namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxStudentsCount = 29;
        private bool studentIsNotFound = true;
        private string name;
        private List<Student> students;

        public Course(List<Student> students, string name)
        {
            this.Students = students;
            this.Name = name;
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

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count + 1 <= MaxStudentsCount)
            {
                this.Students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The course is Full! Must have maximum 29 students!");
            }
        }

        public void RemoveStudents(Student student)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.Students[i].UniqueNumber == student.UniqueNumber)
                {
                    this.Students.RemoveAt(i);
                    this.studentIsNotFound = false;
                    break;
                }
            }

            if (this.studentIsNotFound)
            {
                throw new ArgumentException("The student is not found!");
            }
        }
    }
}
