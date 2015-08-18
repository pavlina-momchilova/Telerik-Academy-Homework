using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_Largest_Number
{
    class GetLargestNumber
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int number3 = int.Parse(Console.ReadLine());

            if (GetMax(number1, number2) >= number3)
            {
                Console.WriteLine("The largest of the number is: {0}",GetMax(number1,number2));
            }
            else
            {
                Console.WriteLine("The largest of the number is: {0}", number3);
            }
        }
    }
}
