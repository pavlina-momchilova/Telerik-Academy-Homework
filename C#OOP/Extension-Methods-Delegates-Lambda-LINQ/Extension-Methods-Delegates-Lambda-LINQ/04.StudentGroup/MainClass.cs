namespace _04.StudentGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        /*
            Problem 9. Student groups

            Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
            Create a List<Student> with sample students. Select only the students that are from group number 2.
            Use LINQ query. Order the students by FirstName.
         */
        static void Main()
        {


            List<Student> Students = new List<Student>();
            Students.Add(new Student("Gregary", "Simpson", 133405, "028978912342", "gregary.simpson@gmail.com", new List<int>(new int[] { 6, 6, 5,5,6 }), 2));
            Students.Add(new Student("Foster", "Loly", 133404, "08898712342", "lolly.pop@gmail.com", new List<int>(new int[] { 6,6,6,6,4 }), 1));
            Students.Add(new Student("Fular", "Bernadet", 133406, "08897897342", "b.fl@abv.bg", new List<int>(new int[] { 2,5,3,4,2,3 }), 2));
            Students.Add(new Student("Jorge", "Polstone", 254705, "029978254342", "radio.station@yahoo.com", new List<int>(new int[] { 2, 3, 5 }), 3));
            Students.Add(new Student("Derek", "Frozen", 568706, "02978978342", "Frozen.Zone@abv.bg", new List<int>(new int[] { 2, 3, 5,2 }), 1));

            /*
                Problem 9. Student groups

                Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
                Create a List<Student> with sample students. Select only the students that are from group number 2.
                Use LINQ query. Order the students by FirstName.
             */
            var GroupAndOrder = from student in Students
                               where student.GroupNumber == 2
                               orderby student.FirstName
                               select student;
            Console.WriteLine("Students in 2 group with sorted names using just LINQ query: ");
            foreach (var student in GroupAndOrder)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);   
            }
            /*
                Problem 10. Student groups extensions

                Implement the previous using the same query expressed with extension methods.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine();
            Console.WriteLine("Students in 2 group with sorted names using extension containing LINQ query: ");
            var OrderAndGroup = Students.OrderAndGroup();
            foreach (var student in OrderAndGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            /*
                Problem 11. Extract students by email

                Extract all students that have email in abv.bg.
                Use string methods and LINQ.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine();
            Console.WriteLine("Student with post in abv.bg: ");
            var abv = AbvPost(Students); 
            foreach (Student student in abv)
            {
                Console.WriteLine(student.ToString());
            }
            /*
                Problem 12. Extract students by phone

                Extract all students with phones in Sofia.
                Use LINQ.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine();
            Console.WriteLine("Student with phone in Sofia: ");
            Console.WriteLine();
            var phoneSofia = PhoneSofia(Students);
            foreach (Student student in phoneSofia)
            {
                Console.WriteLine(student.ToString());
            }
            /*
                Problem 13. Extract students by marks

                Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
                Use LINQ.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students with at least one mark Excellent (6) are: ");
            Console.WriteLine();
            var fullName = from student in Students
                           where student.Marks.Contains(6)
                           select student.FirstName +" "+ student.LastName;
            var marksToExc = from student in Students
                           where student.Marks.Contains(6)
                           select student.Marks;
            var Excellent = new { FullName = fullName, Marks = marksToExc };

            foreach (var name in Excellent.FullName)
            {
                Console.WriteLine(name);
               
            }
            int count = 1;
            foreach (var mark in Excellent.Marks)
            {
                Console.WriteLine("The marks of the {0} student are: ",count);
                for (int i = 0; i < mark.Count; i++)
                {
                    Console.Write(mark[i]);
                    if (i != mark.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                count++;
            }
            /*
                Problem 14. Extract students with two marks

                Write down a similar program that extracts the students with exactly two marks "2".
                Use extension methods.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students with exactly two marks 2 are: ");
            Console.WriteLine();

            List<Student> twomarks=new List<Student>();
            foreach (var student in Students)
            {
                foreach (var mark in student.Marks)
                {
                    if (student.Marks.ExactlyTwoMarks() == true)
                    {
                        twomarks.Add(student);
                        break;
                    }
                }   
            }

            foreach (var student in twomarks)
            {
                Console.WriteLine(student.ToString());
            }

            /*
             
                Problem 15. Extract marks

                Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Marks of the student that enrolled in 2006: ");
            Console.WriteLine();
            var marksSt = from student in Students
                          where (student.FN % 10) == 6 || (student.FN % 100) == 0
                          select student.Marks;
            foreach (var student in marksSt)
            {
                for (int i = 0; i < student.Count; i++)
                {
                    Console.Write(student[i]);
                    if (i != student.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
            /*
                Problem 18. Grouped by GroupNumber

                Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
                Use LINQ.
             */

            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students Group by GroupNumber: ");
            Console.WriteLine();
            var groupedStudents = from student in Students
                                  orderby student.GroupNumber
                                  group student by student.GroupNumber;

            int countgr=1;
            foreach (var student in groupedStudents)
            {
                Console.WriteLine("Group {0}",countgr);
                Console.WriteLine();
                foreach (var item in student)
                {
                    Console.WriteLine(item);
                }
                countgr++;
            }
            /*
                Problem 19. Grouped by GroupName extensions

                Rewrite the previous using extension methods.
             */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students Group by GroupNumber using extension method: ");
            Console.WriteLine();
            var grouped = Students.Grouping();
            int countgrExt = 1;
            foreach (var student in grouped)
            {
                Console.WriteLine("Group {0}", countgrExt);
                Console.WriteLine();
                foreach (var item in student)
                {
                    Console.WriteLine(item);
                }
                countgrExt++;
            }
        }
        public static List<Student> AbvPost(List<Student> St)
        {
            var studentsWithAbv = from student in St
                                  where student.Email.Substring(student.Email.Length - 6, 6) == "abv.bg"
                                  select student;
            return studentsWithAbv.ToList();

        }
        public static List<Student> PhoneSofia(List<Student> St)
        {
            var PhoneSofia = from student in St
                                  where student.Tel.Substring(0, 2) == "02"
                                  select student;
            return PhoneSofia.ToList();

        }
    }
}
