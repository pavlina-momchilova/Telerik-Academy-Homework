namespace _03.Delegates
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
            Timer timer = new Timer(2);

            timer.Td += JustMethod;

            timer.ExecutionOfTimer();
        }

        public static void JustMethod()
        {
            Console.WriteLine("Using Delegates");
        }
    }

    
}
