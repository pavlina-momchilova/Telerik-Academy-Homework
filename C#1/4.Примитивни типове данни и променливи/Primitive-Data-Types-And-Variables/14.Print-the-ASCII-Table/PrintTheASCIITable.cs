using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class PrintTheASCIITable
    {
        /*
            Problem 14.* Print the ASCII Table

            Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

            Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
            
            Note: You may need to use for-loops (learn in Internet how).
         */
        static void Main(string[] args)
        {
            char symbols;
            for (int i = 0; i <= 255;i++)
            {
                while (i >= 7 && i <14)
                {
                    i++;
                }
                symbols = (char)i;
                Console.Write(symbols+"   ");
            }
        }
    }
}
