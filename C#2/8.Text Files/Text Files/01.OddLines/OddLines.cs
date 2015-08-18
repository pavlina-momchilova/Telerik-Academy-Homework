using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        /*
         Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
         */
        static void Main()
        {
            string path = @"..\..\..\TextFile.txt";
            StreamReader read = new StreamReader(path);
            using (read)
            {
                int lineNumber = 0;
                string line = read.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = read.ReadLine();
                }
            }
        }
    }
}
