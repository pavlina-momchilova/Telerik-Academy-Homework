using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class WordsCount
    {
        /*
         Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
         */
        static void Main()
        {
            Console.WriteLine("Enter sequense of words: ");
            List<string> words = new List<string>();
            words = Console.ReadLine().Split(' ').ToList();
            List<string> allWords = new List<string>();
            int lenght = words.Count;
            int count = 0;
            while (lenght > 0)
            {
                string word = words[0];
                for (int i = 0; i < words.Count; i++)
                {
                    if (word == words[i])
                    {
                        count++;
                        words.Remove(words[i]);
                        i--;
                        lenght--;
                    }
                }
                allWords.Add(word);
                allWords.Add(count.ToString());
                count = 0;
            }
            Console.WriteLine("Result: ");
            for (int i = 0; i < allWords.Count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(allWords[i]);
                }
                else
                {
                    Console.Write(allWords[i] + " - ");
                }
            }
            Console.WriteLine();
        }
    }
}
