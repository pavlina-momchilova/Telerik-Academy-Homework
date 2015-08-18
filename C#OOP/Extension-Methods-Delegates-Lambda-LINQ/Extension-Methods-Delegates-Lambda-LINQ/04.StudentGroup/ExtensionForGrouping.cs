using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentGroup
{
    public static class ExtensionForGrouping
    {
            /*
                Problem 19. Grouped by GroupName extensions

                Rewrite the previous using extension methods.
             */
        public static IEnumerable<IEnumerable<Student>> Grouping(this List<Student> students)
        {
            var groupedStudents = from student in students
                                  orderby student.GroupNumber
                                  group student by student.GroupNumber;
            return groupedStudents;
        }
    }
}
