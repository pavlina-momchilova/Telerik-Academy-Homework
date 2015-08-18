using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadFileContents
{
    class ReadFileContents
    {
        /*
         Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
         */
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter full path and name of the file: ");
                string pathAndName = Console.ReadLine();
                string textFile = File.ReadAllText(@pathAndName);
                Console.WriteLine("The content of the file: ");
                Console.WriteLine(textFile);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path is too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The path is not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The access to the path is denied");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("The file cannot load");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path is empty");
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
