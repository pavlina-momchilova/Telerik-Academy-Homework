using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        /*
         Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
         */
        static void Main()
        {
            StreamReader Input = new StreamReader(@"..\..\..\06Input.txt");
            StreamWriter Output = new StreamWriter(@"..\..\..\06Output.txt");
            using (Input)
            {
                using (Output)
                {
                    string line = Input.ReadLine();
                    List<string> words = new List<string>();
                    while (line != null)
                    {
                        words.Add(line);
                        line = Input.ReadLine();
                    }
                    string firstWord = String.Empty;
                    List<string> result = new List<string>();
                    int lenght = 0;
                    int lenghtOfList = words.Count;
                    while (lenght < lenghtOfList)
                    {
                        string Sort = words[0];
                        for (int i = 0; i < words.Count - 1; i++)
                        {
                            int Result = String.Compare(words[i], words[i + 1]);
                            if (Result == -1)
                            {
                                firstWord = String.Concat(firstWord, words[i]);
                            }
                            else
                            {
                                firstWord = String.Concat(firstWord, words[i + 1]);
                            }
                            if (String.Compare(firstWord, Sort) == -1)
                            {
                                Sort = firstWord;
                            }
                            firstWord = String.Empty;
                        }
                        result.Add(Sort);
                        result.Add(" ");
                        words.Remove(Sort);
                        firstWord = String.Empty;
                        lenght++;
                        
                    }
                    for (int i = 0; i < result.Count; i++)
                    {
                        Output.WriteLine(result[i]);
                    }    
                }

            }
            
            
        }
    }
}
