namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;
    using System.Collections.Generic;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void AddCourseShouldAddTheCourse()
        {
            List<Course> courses = new List<Course>();
            List<Student> students = new List<Student>();
            School IodaSchool = new School(courses);
            string name = "Math";
            Course newCourse = new Course(students, name);
            IodaSchool.AddCourse(newCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCoursesShouldThrowErrorIfCoursesAreMoreThanMaxCourses()
        {
            List<Course> courses = new List<Course>();
            School IodaSchool = new School(courses);
            List<Student> students = new List<Student>();
            
            for (int i = 0; i < 35; i++)
            {
                Course newCourse = new Course(students, ("English"+i));
                IodaSchool.AddCourse(newCourse);
            }
        }

        [TestMethod]
        public void RemoveCourseShouldRemoveCourseThatAlreadyExist()
        {
            string name = "English";
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students,name);
            List<Course> courses = new List<Course>();
            School IodaSchool = new School(courses);
            IodaSchool.AddCourse(newCourse);
            IodaSchool.RemoveCourse(newCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveCourseShouldThrowErrorIfCourseDoesNotExist()
        {
            string name = "English";
            List<Student> students = new List<Student>();
            Course newCourse = new Course(students, name);
            Course newCourse2 = new Course(students, name + 2);
            List<Course> courses = new List<Course>();
            School IodaSchool = new School(courses);
            IodaSchool.AddCourse(newCourse);
            IodaSchool.RemoveCourse(newCourse2);
        }
    }
}
