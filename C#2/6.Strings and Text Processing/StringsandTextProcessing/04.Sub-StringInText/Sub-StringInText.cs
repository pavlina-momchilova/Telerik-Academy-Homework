using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_StringInText
{
    class SubStringInText
    {
        /*
         Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
         */
        static void Main()
        {
            Console.WriteLine("Enter a text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a target: ");
            string subString = Console.ReadLine();
            int index = 0;
            int count = 0;
            while(text.IndexOf(subString,index)!=(-1))
            {
                index = text.IndexOf(subString, index);
                count++;
                index++;
            }
            Console.WriteLine("The sub-string \"{0}\" is contained {1} times in the text",subString,count);
        }
    }
}
