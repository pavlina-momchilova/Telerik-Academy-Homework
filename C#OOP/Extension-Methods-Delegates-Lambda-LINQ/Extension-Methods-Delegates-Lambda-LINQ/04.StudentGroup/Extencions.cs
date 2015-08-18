namespace _04.StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Extencions
    {
            /*
               Problem 10. Student groups extensions

               Implement the previous using the same query expressed with extension methods.
            */
        public static List<Student> OrderAndGroup(this List<Student> students)
        {
             var GroupandOrder = from student in students 
                                 where student.GroupNumber == 2
                                 orderby student.FirstName
                                 select student;
             return GroupandOrder.ToList();
        }
    }
}