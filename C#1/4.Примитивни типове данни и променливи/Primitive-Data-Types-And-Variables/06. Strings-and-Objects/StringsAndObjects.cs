using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class StringsAndObjects
    {
        /*
            Problem 6. Strings and Objects

            Declare two string variables and assign them with Hello and World.
            Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
            Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

         */
        static void Main(string[] args)
        {
            string hello="Hello";
            string world = "World";
            object concatenation = hello + " " + world;
            string result = (string)concatenation;
            Console.WriteLine("The concatenation is :" + result);
        }
    }
}
