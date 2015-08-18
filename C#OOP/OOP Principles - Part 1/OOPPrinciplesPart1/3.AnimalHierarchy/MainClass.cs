namespace _3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        static double AverageAge(Animals[] arr)
        {
            return arr.Average(a => a.Age);
        }
        static void Main()
        {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog(5, "Rex", Sex.male);
            dogs[1] = new Dog(2, "Lara", Sex.female);
            dogs[2] = new Dog(14, "Sharo", Sex.male);
            double averageDog = AverageAge(dogs);
            Console.WriteLine("Dog average age: {0:F2}",averageDog);

            Frog[] frogs = new Frog[3];
            frogs[0] = new Frog(1, "Kikerica", Sex.female);
            frogs[1] = new Frog(2, "Juji", Sex.female);
            frogs[2] = new Frog(3, "Kermit", Sex.male);
            double averageFrog = AverageAge(frogs);
            Console.WriteLine("Frog average age: {0:F2}", averageFrog);

            Cat[] cats = new Cat[3];
            cats[0] = new Cat(5, "Pisio", Sex.male);
            cats[1] = new Cat(12, "Maca", Sex.female);
            cats[2] = new Cat(11, "Garfield", Sex.male);
            double averageCat = AverageAge(cats);
            Console.WriteLine("Cat average age: {0:F2}", averageCat);

            Kitten[] kittens = new Kitten[3];
            kittens[0] = new Kitten(1, "Pisanka");
            kittens[1] = new Kitten(2, "Topcho");
            kittens[2] = new Kitten(1, "Puhcho");
            double averageKitten = AverageAge(kittens);
            Console.WriteLine("Kitten average age: {0:F2} ", averageKitten);

            Tomcat[] tomcats = new Tomcat[3];
            tomcats[0] = new Tomcat(7, "Tommy");
            tomcats[1] = new Tomcat(8, "Tomcho");
            tomcats[2] = new Tomcat(4, "Tomario");
            double averageTomcat = AverageAge(tomcats);
            Console.WriteLine("Tomcat average age: {0:F2} ", averageTomcat);
        }
    }
}
