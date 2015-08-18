using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Solve_Tasks
{
    class SolveTasks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose what you want to do: ");
            Console.WriteLine("1.Reverses the digits of a number");
            Console.WriteLine("2.Calculates the average of a sequence of integers");
            Console.WriteLine("3.Solves a linear equation a * x + b = 0");
            Console.WriteLine();
            Console.Write("Yours choice is: ");
            int choosen = int.Parse(Console.ReadLine());
            if (choosen == 1)
            {
                Console.Write("Enter a positive number for reverse: ");
                decimal number = decimal.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    Console.Write("Reverse number is: ");
                    Console.Write(Rverese(number));
                    Console.WriteLine();
                }
            }
            else if (choosen == 2)
            {
                Console.WriteLine("Enter sequence of integer separated by single space: ");
                string sequence = Console.ReadLine();
                if (sequence.Length < 1)
                {
                    Console.WriteLine("Wrong input!");
                }
                else
                {
                    string[] array = sequence.Split(' ');
                    Console.WriteLine(Average(array));
                }
               
            }
            else if (choosen == 3)
            {
                Console.WriteLine("Enter coefficient a!=0 a= ");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter coefficient b= ");
                decimal b = decimal.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a = 0 so you enter wrong input!");
                }
                else
                {
                    Console.WriteLine("Your equation is: ");
                    Console.WriteLine("{0} * x + {1} = 0", a, b);
                    Console.WriteLine("x = " + LinearEquation(a, b));
                }
                
            }
            else
            {
                Console.WriteLine("You enter wrong number!");
            }
        }

        private static decimal LinearEquation(decimal a, decimal b)
        {
            return (b / a) * (-1);
        }

        static double Average(string[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Convert.ToInt32(array[i]);
            }
            double avarage = sum / array.Length;
            return avarage;

        }

        static decimal Rverese(decimal number)
        {
            string NumberInString = number.ToString();
            string Reverse = "";
            for (int i = NumberInString.Length-1; i >=0 ; i--)
            {
                Reverse += NumberInString[i];
            }
            return Convert.ToInt32(Reverse);
        }
    }
}
