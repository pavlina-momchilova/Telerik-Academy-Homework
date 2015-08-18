namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;
    using System.Collections.Generic;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void AddStudentsShouldAddTheStudent()
        {
            string name = "Petur Petrov";
            int uniqueNumber = 10002;
            Student student = new Student(name, uniqueNumber);
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students,"Math");
            newCourse.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddStudentsShouldThrowErrorIfStudentsAreMoreThanMaxStudents()
        {
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students,"English");
            for (int i = 0; i <35 ; i++)
            {
                Student student = new Student("Petur Iordanov", (10001+i));
                newCourse.AddStudent(student);  
            }
          
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowErrorIfNameOfTheCourseIsEmpty()
        {
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students, "");
        }

        [TestMethod]
        public void RemoveStudentsShouldRemoveStudentsThatAlreadyExist()
        {
            string name = "Petur Petrov";
            int uniqueNumber = 10002;
            Student student = new Student(name, uniqueNumber);
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students,"Math");
            newCourse.AddStudent(student);
            newCourse.RemoveStudents(student);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentsShouldThrowErrorIfStudentDoesNotExist()
        {
            string name = "Petur Petrov";
            int uniqueNumber = 10002;
            Student student2 = new Student("Goshko", uniqueNumber + 1);
            Student student = new Student(name, uniqueNumber);
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students, "Math");
            newCourse.AddStudent(student);
            newCourse.RemoveStudents(student2);
        }
    }
}
