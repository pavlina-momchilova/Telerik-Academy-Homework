namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name) :
            base(name)
        {
        }

        public OffsiteCourse(string name, string teacherName) :
            base(name, teacherName)
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students) :
            base(name, teacherName, students)
        {
            this.Town = null;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                Validator.IsEmpty(value, "Town");
                this.town = value;
            }
        }

        public override string ToString()
        {
            return base.ToString(this.Town, "OffisiteCourse", "Town");
        }
    }
}
