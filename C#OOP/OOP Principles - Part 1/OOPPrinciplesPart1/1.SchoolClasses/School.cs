namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        #region fields
        private HashSet<Class> classesOfStudent;
        #endregion

        #region constructorst
        public School(HashSet<Class> classes)
        {
            this.ClassesOfStudent = classes;
        }
        #endregion

        #region properties
        public HashSet<Class> ClassesOfStudent
        {
            get
            {
                return this.classesOfStudent;
            }
            private set
            {
                this.classesOfStudent = value;
            }
        }
        #endregion

        #region methods
        public void AddClass(Class newClass)
        {
            ClassesOfStudent.Add(newClass);
        }
        public void RemoveClass(Class newClass)
        {
            ClassesOfStudent.Remove(newClass);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("School:\n Class in school: {0} ",string.Join("\n ",ClassesOfStudent));
        }
        #endregion
    }
}
