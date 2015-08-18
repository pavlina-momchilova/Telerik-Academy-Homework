namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StudentsAndCourses;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UniqueNumberShouldThrowErrorIfIsLessThanMinValue()
        {
            string name = "Petur Petrov";
            int uniqueNumber = 652;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void UniqueNumberShouldThrowErrorIfIsMoreThanMaxValue()
        {
            string name = "Georgi Ivanov";
            int uniqueNumber = 654563152;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NameShouldThrowErrorIfIsEmpty()
        {
            string name = "";
            int uniqueNumber = 10001;
            Student student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        public void IfStudentIsValidExpectToCreateNewStudent()
        {
            string name = "Stamat";
            int uniqueNumber = 10021;
            Student student = new Student(name, uniqueNumber);
        }
    }
}
