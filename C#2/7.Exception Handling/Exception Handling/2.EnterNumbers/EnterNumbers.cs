using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EnterNumbers
{
    class EnterNumbers
    {
        /*
         Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
         */
        static void Main()
        {
            int index = 0;
            List<int> num = new List<int>();
            int numbers=0;
            while (index < 10)
            {
                if (index == 0)
                {
                    numbers = ReadNumber(1, 100);
                    if (numbers == -1)
                    {
                        while (numbers == - 1)
                        {
                            Console.WriteLine("Number is less or equal to previous number: ");
                            Console.WriteLine("Enter another one: ");
                            numbers = ReadNumber(1, 100);
                        }
                    }
                        num.Add(numbers);
                        index++;
                }
                else
                {
                    numbers = ReadNumber(1, 100);
                    if (numbers > num[index - 1])
                    {
                        num.Add(numbers);
                        index++;
                    }
                    else
                    {
                        while (numbers <= num[index - 1])
                        {
                            Console.WriteLine("Number is less or equal to previous number: ");
                            Console.WriteLine("Enter another one: ");
                            numbers = ReadNumber(1, 100);
                        }
                        num.Add(numbers);
                        index++;
                    }
                }
               
                
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (i != num.Count - 1)
                {
                    Console.Write(num[i] + " < ");
                }
                else
                {
                    Console.Write(num[i]);
                }
            }
            Console.WriteLine();
        }
        static int ReadNumber(int start, int end)
        {
            int number=0;
            try
            {
                Console.WriteLine("Enter a numbers: ");
                number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end)
                {
                    Exception ex = new Exception();
                    throw ex;
                }
                return number;
            }
            catch (Exception)
            {
                Console.WriteLine("Number is not in range [{0},{1}] or is not a number",start,end);
                return -1;
            }
        }
    }
}
