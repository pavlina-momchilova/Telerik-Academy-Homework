using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Say_Hello
{
    class SayHello
    {
        /*
            Problem 1. Say Hello

            Write a method that asks the user for his name and prints “Hello, <name>”
            Write a program to test this method.
         */
        static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main()
        {
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Hello(yourName);
        }
    }
}
