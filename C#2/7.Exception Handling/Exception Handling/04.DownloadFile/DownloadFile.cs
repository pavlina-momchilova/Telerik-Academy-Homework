using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        /*
         Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
         */
        static void Main()
        {
            WebClient file = new WebClient();
            try
            {
                Console.WriteLine("Enter an address: ");
                string addres = Console.ReadLine();
                Console.WriteLine("Enter file name and file type: ");
                string fileName = Console.ReadLine();

               
                file.DownloadFile(addres, fileName);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Empty path name");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The access to the path is denied");
            }
            catch (WebException)
            {
                Console.WriteLine("Could not find file");
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Invalid path to file");
            }
            catch (Exception)
            {
                Console.WriteLine("Something is wrong");
            }
            finally
            {
                Console.WriteLine("complete");
                file.Dispose();
            }
        }
    }
}
