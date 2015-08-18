namespace StudentClass
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
            Student Pesho = new Student("Pesho", "Petrov", "Petrov", 12546, "Sofia", "+356 558 566 552", "P3@abv.bg");
            Pesho.UniversityInf(Student.EnumUniversity.SofiaUniversity, 3, Student.EnumFaculty.MatematicaAndInformatica, Student.EnumSpeciality.MatematicaAndInformatica);
            Console.WriteLine(Pesho.GetHashCode());
            Student Gosho = new Student("Georgi", "Georgiev", "Stanchev", 536312, "Varna", "+245 526 665 523", "GoshoStanchev@gmail.com");
            Gosho.UniversityInf(Student.EnumUniversity.VTU, 4, Student.EnumFaculty.Medicine, Student.EnumSpeciality.Dentist);
            Console.WriteLine(Gosho.GetHashCode());

            Console.WriteLine(Pesho);
            Console.WriteLine(Gosho);
            Console.WriteLine(Pesho==Gosho);
            Console.WriteLine(Pesho.Equals(Pesho));
            Console.WriteLine(Pesho.Equals(Gosho));
            Console.WriteLine(Pesho!=Gosho);
        }
    }
}
