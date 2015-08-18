using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        /*
         Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
         */
        static void Main()
        {
            StreamReader firstFile = new StreamReader(@"..\..\..\04Text.txt");
            StreamReader secondFile = new StreamReader(@"..\..\..\04Text2.txt");
            using (firstFile)
            {
                int same = 0;
                int different = 0;
                using (secondFile)
                {
                    string lineFirst = firstFile.ReadLine();
                    string lineSecond = secondFile.ReadLine();
                    
                    while (lineFirst != null)
                    {
                        if (lineFirst == lineSecond)
                        {
                            same++;
                        }
                        else
                        {
                            different++;
                        }
                        lineFirst = firstFile.ReadLine();
                        lineSecond = secondFile.ReadLine();
                    }

                }
                Console.WriteLine("The same rows are : "+same);
                Console.WriteLine("Different rows are : " + different);
            }

        }
    }
}
