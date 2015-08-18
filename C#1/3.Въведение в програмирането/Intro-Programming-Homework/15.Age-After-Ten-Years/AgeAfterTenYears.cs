using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Age_After_Ten_Years
{
    class AgeAfterTenYears
    {
        /*
         Problem 15.* Age after 10 Years

         Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: ");
            Console.WriteLine(a + 10);
        }
    }
}
