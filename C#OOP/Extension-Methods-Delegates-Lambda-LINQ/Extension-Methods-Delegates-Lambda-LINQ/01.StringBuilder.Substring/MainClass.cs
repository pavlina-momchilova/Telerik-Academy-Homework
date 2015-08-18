namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using _01.StringBuilder.Substring.Extencions;

    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("The text is:");
            StringBuilder newString = new StringBuilder();
            newString.Append("Lorem Ipsum е елементарен примерен текст, използван в печатарската и типографската индустрия. Lorem Ipsum е индустриален стандарт от около 1500 година, когато неизвестен печатар взема няколко печатарски букви и ги разбърква, за да напечата с тях книга с примерни шрифтове. Този начин не само е оцелял повече от 5 века, но е навлязъл и в публикуването на електронни издания като е запазен почти без промяна. Популяризиран е през 60те години на 20ти век със издаването на Letraset листи, съдържащи Lorem Ipsum пасажи, популярен е и в наши дни във софтуер за печатни издания като Aldus PageMaker, който включва различни версии на Lorem Ipsum.");
            Console.WriteLine(newString);
            newString = newString.Substring(6, 19);
            Console.WriteLine();
            Console.WriteLine("The substring is:");
            Console.WriteLine(newString);
            Console.WriteLine();
            Console.WriteLine(new string('*', 80));

            Console.WriteLine("The IEnumerable extancions test is: ");
            var arr = new List<double>() { 3.5, 4.2, 7.5, 9.2, 1 };

            Console.WriteLine("The sum is: ");
            Console.WriteLine(arr.Sum());

            Console.WriteLine("The product is: ");
            Console.WriteLine(arr.Product());

            Console.WriteLine("The minimum is: ");
            Console.WriteLine(arr.Min());

            Console.WriteLine("The maximum is: ");
            Console.WriteLine(arr.Max());

            Console.WriteLine("The average is: ");
            Console.WriteLine(arr.Average());
            Console.WriteLine();
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students 3task: ");
            Students();
        }
        public static void Students()
        {
            /*
               Problem 3. First before last

               Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
               Use LINQ query operators.
             
            */
            var students = new[]
            {
                new{FirstName = "Pesho", LastName = "Ganchev", Age=18},
                new{FirstName = "Alexandar", LastName = "Borisov", Age=24},
                new{FirstName = "Veronika", LastName = "Karaivanova", Age=28},
                new{FirstName = "Ivan", LastName = "Kushev", Age=17},
                new{FirstName = "Dragan", LastName = "Draganov", Age=32},
                new{FirstName = "Stefan", LastName = "Petkanov", Age=19},
                new{FirstName = "Ivan", LastName = "Stoqnov", Age=33},
                new{FirstName = "Georgi", LastName = "Hristov", Age=42}
            };
            Console.WriteLine("All Students");
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
            var st = from student in students
                     where student.FirstName.CompareTo(student.LastName) == -1
                     select student;
            Console.WriteLine("Students whose first name is before last name: ");
            Console.WriteLine();
            foreach (var student in st)
            {
                Console.WriteLine(student.FirstName+" "+ student.LastName);
            }
            Console.WriteLine();
            /*
                Problem 4. Age range

                Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
             */
            Console.WriteLine(new string('*', 80));
            var ageInRange = from student in students
                             where student.Age >= 18 && student.Age <= 24
                             select student;
            foreach (var student in ageInRange)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName+" "+student.Age);
            }
            Console.WriteLine();

            /*
                Problem 5. Order students

                Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
                Rewrite the same with LINQ.
            */
            Console.WriteLine(new string('*', 80));
            Console.WriteLine("Students Ordered by first name then by last name with lambda expressions: ");
            Console.WriteLine();
            var OrderedSt=students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            foreach (var student in OrderedSt)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
            Console.WriteLine("Students Ordered by first name then by last name with LINQ query: ");
            Console.WriteLine();
            var OrdeWithLINQ = from student in students
                               orderby student.FirstName descending, student.LastName descending
                               select student;
            foreach (var student in OrdeWithLINQ)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();
        }
    }
}