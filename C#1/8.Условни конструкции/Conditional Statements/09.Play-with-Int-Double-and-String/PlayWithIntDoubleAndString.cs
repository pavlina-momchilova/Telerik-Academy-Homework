using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Play_with_Int_Double_and_String
{
    class PlayWithIntDoubleAndString
    {
        /*
            Problem 9. Play with Int, Double and String

            Write a program that, depending on the user’s choice, inputs an int, double or string variable.
            If the variable is int or double, the program increases it by one.
            If the variable is a string, the program appends * at the end.
            Print the result at the console. Use switch statement.

         */
        static void Main(string[] args)
        {
            Console.Title = "Play with Int, Double and String";
            Console.WriteLine("Choose a type and enter it's number: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int type =int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1: Console.WriteLine("Enter an integer number: ");
                    int integerType = int.Parse(Console.ReadLine());
                    integerType = integerType + 1;
                    Console.WriteLine("The double number + 1: "+integerType);
                    break;
                case 2: Console.WriteLine("Enter a double number: ");
                    double doubleType = double.Parse(Console.ReadLine());
                    doubleType = doubleType + 1;
                    Console.WriteLine("The double number + 1: "+doubleType);
                    break;
                case 3: Console.WriteLine("Enter a string: ");
                    string stringType =Console.ReadLine();
                    stringType+="*";
                    Console.WriteLine("The string with star: "+stringType);
                    break;
                default: Console.WriteLine("Wrong input!");
                    break;
            }
        }
    }
}
