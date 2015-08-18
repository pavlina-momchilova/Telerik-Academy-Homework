namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student:Person,IComment
    {
        #region fields
        private string uniqueClassNum;
        #endregion

        #region constructors
        public Student(string name, string uniqueNum)
            : base(name)
        {
            this.UniqueClassNum = uniqueNum;
        }
        #endregion

        #region properties
        public string UniqueClassNum
        {
            get
            {
                return this.uniqueClassNum;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The uniqueClassNum cannot be empty or null!");
                }
                else if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The uniqueClassNum cannot be empty or null!");
                }
                else
                {
                    this.uniqueClassNum = value;
                }
            }
        }
        #endregion

        #region methods
        List<string> StudentComment = new List<string>();
        public void AddComment(string comment)
        {
            StudentComment.Add(comment);
        }
        #endregion

        #region ToString
        public override string ToString()
        {
            return String.Format("Name: {0},  UniqueClassNum: {1}, {2} ",this.Name,this.UniqueClassNum,StudentComment.Count>0?"\nComments: "+String.Join("\n",StudentComment):" ");
        }
        #endregion
       
    }
}
