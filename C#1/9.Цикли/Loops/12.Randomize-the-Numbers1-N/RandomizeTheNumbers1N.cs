using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _12.Randomize_the_Numbers1_N
{
    class RandomizeTheNumbers1N
    {
        /*
            Problem 12.* Randomize the Numbers 1…N

            Write a program that enters in integer n and
            prints the numbers 1, 2, …, n in random order.
         */
        static void Main()
        {
            Console.WriteLine("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your random numbers from 1 to n are: ");
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            Random randomGenerator = new Random();
            List<int> ListOfRandoms = new List<int>();
            ListOfRandoms.Add(randomGenerator.Next(numbers[0], numbers[n-1]+1));
            bool addNumber = false;
            while (ListOfRandoms.Count < n)
            {
                int random = randomGenerator.Next(numbers[0], numbers[n - 1] + 1);
                addNumber = true;
                for (int i = 0; i < ListOfRandoms.Count; i++)
                {
                    if (random == ListOfRandoms[i])
                    {
                        addNumber = false;
                        break;
                    }
                }
                if(addNumber)
                {
                    ListOfRandoms.Add(random);
                }
            }
            for (int i = 0; i < ListOfRandoms.Count; i++)
            {
                Console.WriteLine(ListOfRandoms[i]);
            }
        }
    }
}
