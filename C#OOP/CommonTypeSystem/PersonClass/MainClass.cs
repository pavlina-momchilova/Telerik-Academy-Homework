namespace PersonClass
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
            Person Pesho = new Person("Pesho", 19);
            Person Gosho = new Person("Gosho");

            Console.WriteLine(Pesho);
            Console.WriteLine(Gosho);
        }
    }
}
