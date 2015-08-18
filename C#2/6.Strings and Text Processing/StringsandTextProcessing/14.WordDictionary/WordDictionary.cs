using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class WordDictionary
    {
        /*
       14. Word dictionary

       A dictionary is stored as a sequence of text lines containing 
       words and their explanations.
       Write a program that enters a word and translates it by using the
       dictionary.
        
   */
        static void Main(string[] args)
        {
            Dictionary<string, string> theDicrionary = new Dictionary<string, string>();
            theDicrionary.Add(".NET", "platform for applications from Microsoft");
            theDicrionary.Add("CLR", "managed execution environment for .NET");
            theDicrionary.Add("namespace", "hierarchical organization of classes");
            Console.WriteLine("Enter a word or definition: ");
            string input = Console.ReadLine();
            if (theDicrionary.ContainsKey(input) || theDicrionary.ContainsValue(input))
            {
                Console.Write(input + " - ");
                Console.WriteLine(theDicrionary[input]);
            }
            else
            {
                Console.WriteLine("This is not in the dictionary!");
            }

        }
    }
}
