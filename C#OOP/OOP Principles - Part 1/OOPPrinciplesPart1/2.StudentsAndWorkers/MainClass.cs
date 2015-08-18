namespace _2.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        static void Main()
        {
            Console.WriteLine(new string('-',80));
            Console.WriteLine("10 Students ordered by Grade by ascending order: ");
            Console.WriteLine();
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivelina", "Vurbanova", 1));
            students.Add(new Student("Ivan", "Georgiev", 3));
            students.Add(new Student("Biserka", "Stoqnova", 2));
            students.Add(new Student("Maria", "Purvanova", 3));
            students.Add(new Student("Katerina", "Asenova", 1));
            students.Add(new Student("Petur", "Vurtanov", 2));
            students.Add(new Student("Petur", "Purvanov", 1));
            students.Add(new Student("Emiliqn", "Stanev", 7));
            students.Add(new Student("Atanas", "Burov", 7));
            students.Add(new Student("Ivelina", "Kostadinova", 12));

            var orderedStudents = from student in students
                                  orderby student.Grade ascending
                                  select student;
            foreach (var st in orderedStudents)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("10 Workers ordered by Money per hour by descending order: ");
            Console.WriteLine();
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Alexandur", "Ivanov", 500, 8));
            workers.Add(new Worker("Alexandur", "Karaivanov", 400, 6));
            workers.Add(new Worker("Ekaterina", "Ivanov", 580, 7.5M));
            workers.Add(new Worker("Momchil", "Petrov", 200.40M, 4));
            workers.Add(new Worker("Paulina", "Karadjova", 510, 4));
            workers.Add(new Worker("Denica", "Koedjikova", 1200, 2));
            workers.Add(new Worker("Milena", "Stefanova", 1200, 4));
            workers.Add(new Worker("Alexandur", "Purvanov", 500, 8.7M));
            workers.Add(new Worker("Katq", "Vurbanova", 1000, 8));
            workers.Add(new Worker("Vanq", "Angelova", 5000, 4));

            var orderedWorkers = from worker in workers
                                 orderby worker.MoneyPerHour() descending
                                 select worker;

            foreach (var wo in orderedWorkers)
            {
                Console.WriteLine(wo);
            }

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Merged List ordered by first name and than by last name by descending order: ");
            Console.WriteLine();
            List<Human> merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);

            var orderedMerged = from humen in merged
                                orderby humen.FirstName, humen.LastName
                                select humen;

            foreach (var humen in orderedMerged)
            {
                Console.WriteLine(humen);
            }


        }
    }
}
