using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        /*
         Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
         */
        static void Main()
        {
            StreamReader FirstFile = new StreamReader(@"..\..\..\TextFile.txt");
            StreamReader SecondFile = new StreamReader(@"..\..\..\AnotherTextFile.txt");
            StreamWriter ConcatenateFile = new StreamWriter(@"..\..\..\ConcatenateFile.txt");

            using (FirstFile)
            {
                string linesFirst = FirstFile.ReadToEnd();
                using (SecondFile)
                {
                    string linesSecond = SecondFile.ReadToEnd();
                     using (ConcatenateFile)
                    {
                        ConcatenateFile.Write(linesFirst);
                        ConcatenateFile.Write(linesSecond);
                    }
                }
               
            }
        }
    }
}
