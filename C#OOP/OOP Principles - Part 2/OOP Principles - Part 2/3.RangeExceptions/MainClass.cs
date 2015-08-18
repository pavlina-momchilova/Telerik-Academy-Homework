namespace _3.RangeExceptions
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
            try
            {
                throw new InvalidRangeException<int>(1, 100,"Wrong Input!");
            }
            catch(InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            try
            {
                throw new InvalidRangeException<DateTime>(new DateTime(1980,1,1), new DateTime(2013,12,31),"Wrong date!");
            }
            catch(InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
