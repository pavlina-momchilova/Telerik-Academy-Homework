using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Play_With_Debugger
{
    class PlayWithDebugger
    {
        /*
            Problem 17.* Play with the Debugger in Visual Studio

            Write a program that prints at the console the numbers from 1 to 1000, each at a separate line.
            You might need to learn how to use loops (search in Internet).
            Set a breakpoint in the line, which prints the next number in the Visual Studio code editor. Run the program through the debugger using the [F5] key.
            When the debugger stops at the breakpoint trace the code execution with [F10] key.
            You do not have to submit anything in your homework for this problem. Just play with the debugger to learn how it works.
         */
        static void Main(string[] args)
        {
            for (int i = 1; i < 1001; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
