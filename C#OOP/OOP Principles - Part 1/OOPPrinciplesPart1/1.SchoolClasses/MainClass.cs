namespace _1.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainClass
    {
        static void Main()
        {
            HashSet<Teacher> teachers =new HashSet<Teacher>();
            HashSet<Student> students =new HashSet<Student>();
            HashSet<Discipline> discipline = new HashSet<Discipline>();
            HashSet<Class> classes = new HashSet<Class>();
            School EmilianStanev = new School(classes);
            Class IA = new Class(teachers, students, "IA");
            Class IB = new Class(teachers, students, "IB");
            Class IC = new Class(teachers, students, "IC");
            Teacher Georgi = new Teacher("Georgi Georgiev", discipline);
            Teacher Petar = new Teacher("Petar Avramov", discipline);
            Teacher Stamat = new Teacher("Stamat Ivanov", discipline);
            Discipline Matematica = new Discipline("Matematica", 5, 7);
            Discipline Literature = new Discipline("Literature", 4, 8);
            Discipline English = new Discipline("English", 7, 9);
            Discipline History = new Discipline("History", 3, 1);
            Discipline Geography = new Discipline("Geography", 2, 1);
            Discipline Fizichesko = new Discipline("Fizichesko", 1, 1);
            Georgi.AddDiscipline(Matematica);
            Georgi.AddDiscipline(Literature);
            Georgi.AddDiscipline(English);
            Petar.AddDiscipline(History);
            Petar.AddDiscipline(Geography);
            Stamat.AddDiscipline(Fizichesko);
            Georgi.RemoveDiscipline(Literature);
            Student Alex = new Student("Alex Kostadinov", "1");
            Student Veronica = new Student("Veronika Stancheva", "5");
            Student Benedeta = new Student("Benedeta Kucarova", "2");
            Student Caroline = new Student("Caroline Simpson", "3");
            Student David = new Student("David Jhones", "4");
            Student Megan = new Student("Megan Fox", "6");
            Student Philip = new Student("Philip Avramov", "7");

            EmilianStanev.AddClass(IA);
            IA.AddTeacher(Georgi);
            IA.AddTeacher(Petar);
            IA.AddStudent(Alex);
            IA.AddStudent(Veronica);
            IA.AddStudent(Benedeta);
            IB.AddTeacher(Georgi);
            IB.AddTeacher(Stamat);
            IB.AddStudent(Caroline);
            IB.AddStudent(David);
            IC.AddTeacher(Petar);
            IC.AddTeacher(Georgi);
            IC.AddTeacher(Stamat);
            IC.AddStudent(Megan);
            IC.AddStudent(Philip);

            EmilianStanev.AddClass(IB);
            EmilianStanev.AddClass(IC);

            Veronica.AddComment("The smartest girl in class");
            IA.AddComment("IA is the coolest class ever");
            Matematica.AddComment("Matematica is the best Subject!");
            Console.WriteLine(EmilianStanev.ToString());
        }
    }
}
