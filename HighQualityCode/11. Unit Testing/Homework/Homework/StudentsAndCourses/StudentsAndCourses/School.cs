namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private const int MaxCoursesCount = 29;
        private List<Course> courses;
        private bool courseIsNotFound=true;

        public School(List<Course> courses)
        {
            this.Courses = courses;
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }

            set
            { 
                this.courses = value;
            }
        }

        public void AddCourse(Course course)
        {
            if (this.Courses.Count + 1 <= MaxCoursesCount)
            {
                this.Courses.Add(course);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The school is full with courses! Must have maximum 29 courses!");
            }
        }

        public void RemoveCourse(Course course)
        {
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].Name == course.Name)
                {
                    this.Courses.RemoveAt(i);
                    this.courseIsNotFound = false;
                    break;
                }
            }

            if (this.courseIsNotFound)
            {
                throw new ArgumentException("The course is not found!");
            }
        }
    }
}
