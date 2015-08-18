namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Discipline:IComment
    {
        #region fields
        private string nameOfDiscipline;
        private byte numOfLectures;
        private byte numOfExcercises;
        #endregion

        #region constructors
        public Discipline(string name, byte lectures, byte excercises)
        {
            this.NameOfDiscipline = name;
            this.NumOfLectures = lectures;
            this.NumOfExcercises = excercises;
        }
        #endregion

        #region properties
        public string NameOfDiscipline
        {
            get
            {
                return this.nameOfDiscipline;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name Of the Discipline cannot be empty or null!");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name Of the Discipline cannot be empty or null!");
                }
                else
                {
                    this.nameOfDiscipline = value;
                }
            }
        }

        public byte NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentException("The lectures must be more or equal to 1!");
                }
                else
                {
                    this.numOfLectures = value;
                }
            }
        }
        public byte NumOfExcercises
        {
            get
            {
                return this.numOfExcercises;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The excercises must be more or equal to 1!");
                }
                else
                {
                    this.numOfExcercises = value;
                }
            }
        }
        #endregion

        #region methods
        List<String> DisciplinesComments =new List<String>();
        public void AddComment(string comment)
        {
            DisciplinesComments.Add(comment);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("- Name:{0}, - Number of lectures: {1} , - Number of Excercises: {2},{3}", this.NameOfDiscipline, this.NumOfLectures, this.NumOfExcercises, DisciplinesComments.Count > 0 ? "\nComments: " + String.Join("\n", DisciplinesComments) : " ");
        }
        #endregion

    }
}
