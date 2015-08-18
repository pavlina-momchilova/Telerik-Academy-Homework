namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name) :
            base(name)
        {
        }

        public LocalCourse(string name, string teacherName) :
            base(name, teacherName)
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students) :
            base(name, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                Validator.IsEmpty(value, "lab");
                this.lab = value;
            }
        }

        public override string ToString()
        {
            return base.ToString(this.Lab, "LocalCourse", "Lab");
        }
    }
}
