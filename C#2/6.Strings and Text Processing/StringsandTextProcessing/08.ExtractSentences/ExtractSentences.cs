﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        /*
    8. Extract sentences

   Write a program that extracts from a given text all sentences containing 
   given word.

       Example:
        
       The word is: in
        
       The text is: We are living in a yellow submarine. We don't have anything 
       else. Inside the submarine is very tight. So we are drinking all the day. 
       We will move out of it in 5 days.
        
       The expected result is: We are living in a yellow submarine. We will move 
       out of it in 5 days.
        
       Consider that the sentences are separated by . and the words – by 
       non-letter symbols.
   */
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            string[] sentences = text.Trim().Split('.');
            StringBuilder strB = new StringBuilder();
            Console.WriteLine("Example: " + text);
            Console.WriteLine("The word is: " + word);
            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split();
                bool foundWord = false;
                foreach (string wordInWords in words)
                {
                    if (wordInWords == word)
                    {
                        foundWord = true;
                        break;
                    }
                }
                if (foundWord)
                {
                    strB.Append(sentence + ". ");
                }
            }
            Console.WriteLine("\nResult: " + strB.ToString());
        }
    }
}
