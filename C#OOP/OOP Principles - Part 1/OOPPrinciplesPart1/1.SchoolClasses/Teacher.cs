namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teacher :Person,IComment
    {
        #region fields
        private HashSet<Discipline> setOfDisciplines;
        #endregion

        #region constructors
        public Teacher(string name,HashSet<Discipline> discipline): base(name)
        {
            this.SetOfDisciplines = discipline;
        }
        #endregion

        #region properties
        public HashSet<Discipline> SetOfDisciplines
        {
            get
            {
                return this.setOfDisciplines;
            }
            private set
            {
                this.setOfDisciplines = value;
            }
        }
        #endregion

        #region methods
        public void AddDiscipline(Discipline newDiscipline)
        {
            SetOfDisciplines.Add(newDiscipline);
        }

        public void RemoveDiscipline(Discipline newDiscipline)
        {
            SetOfDisciplines.Remove(newDiscipline);
        }

        List<string> TeacherComments = new List<string>();
        public void AddComment(string comment)
        {
            TeacherComments.Add(comment);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("- Name:{0}, - Disciplines: {1},{2}", this.Name, String.Join("\n ", this.SetOfDisciplines), TeacherComments.Count > 0 ? "\nComments: " + String.Join("\n", TeacherComments) : " ");
        }
        #endregion
    }
}
