using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        /*
         Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
         */
        static void Main()
        {
            Console.WriteLine("Enter an expression");
            string expression = Console.ReadLine();
            int countOpen = 0;
            int countClose = 0;
            bool flag = true;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    countOpen++;
                }
                else if (expression[i] == ')')
                {
                    countClose++;
                }
                if(countClose > countOpen)
                {
                    flag = false;
                    break;
                }
            }
            if (expression[0] == ')' || flag==false)
            {
                Console.WriteLine("The brackets are not put correctly");
            }
            else if (countClose == countOpen)
            {
                Console.WriteLine("The brackets are put correctly");
            }
            else
            {
                Console.WriteLine("The brackets are not put correctly");
            }
        }
    }
}
