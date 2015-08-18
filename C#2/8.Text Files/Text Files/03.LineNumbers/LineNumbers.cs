using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LineNumbers
{
    class LineNumbers
    {
        /*
         Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
         */
        static void Main()
        {
            StreamReader read = new StreamReader(@"..\..\..\TextFile.txt");
            StreamWriter write = new StreamWriter(@"..\..\..\ThirdTaskWritten.txt");
            using (read)
            {
                using (write)
                {
                    string lines = read.ReadLine();
                    int lineNumber = 0;
                    while (lines != null)
                    {
                        lineNumber++;
                        write.WriteLine("{0:D2}: {1}", lineNumber, lines);
                        lines=read.ReadLine();
                    }
                }
            }
        }
    }
}
