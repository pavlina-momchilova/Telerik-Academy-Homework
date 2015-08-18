namespace _04.StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class ExtencionsToList
    {
            /*
                Problem 14. Extract students with two marks

                Write down a similar program that extracts the students with exactly two marks "2".
                Use extension methods.
             */
        public static bool ExactlyTwoMarks(this List<int> Marks)
        {
            int count = 0;
            bool flag=false;
            for (int i = 0; i < Marks.Count; i++)
            {
                if (Marks[i] == 2)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                flag = true;

            }
            return flag;
        }
    }
}
