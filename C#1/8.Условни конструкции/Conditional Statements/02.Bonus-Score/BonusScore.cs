using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class BonusScore
    {
        /*
            Problem 2. Bonus Score

            Write a program that applies bonus score to given score in the range [1…9] by the following rules:
            If the score is between 1 and 3, the program multiplies it by 10.
            If the score is between 4 and 6, the program multiplies it by 100.
            If the score is between 7 and 9, the program multiplies it by 1000.
            If the score is 0 or more than 9, the program prints “invalid score”.

         */
        static void Main()
        {
            Console.Title = "Bonus Score";
            Console.WriteLine("Enter score between 1 and 9: ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 1 && score <= 3)
             {
                 score = score * 10;
                 Console.WriteLine("Your score after bonus are: {0}",score);
             }
             else if (score >= 4 && score <= 6)
             {
                 score = score * 100;
                 Console.WriteLine("Your score after bonus are: {0}", score);
             }
            else if (score >= 7 && score <= 9)
            {
                score = score * 1000;
                Console.WriteLine("Your score after bonus are: {0}", score);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
