using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.WriteLine("enter series of letter: ");
            string seriesOfLetters = Console.ReadLine();
            int index = 0;
            int count = 0;
            while (index < seriesOfLetters.Length)
            {
                char letter = seriesOfLetters[index];
                for (int i = index; i < seriesOfLetters.Length; i++)
                {
                    if (seriesOfLetters[i] == letter)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                string oldString = String.Empty;
                oldString=String.Concat(oldString,letter);
                oldString=oldString.PadLeft((count),letter);
                seriesOfLetters=seriesOfLetters.Replace(oldString, letter.ToString());
                index++;
                count = 0;
            }
            Console.WriteLine("result: ");
            Console.WriteLine(seriesOfLetters);
        }
    }
}
