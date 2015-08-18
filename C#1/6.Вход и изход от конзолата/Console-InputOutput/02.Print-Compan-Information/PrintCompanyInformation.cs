using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Print_Compan_Information
{
    class PrintCompanyInformation
    {
        /*
            Problem 2. Print Company Information

            A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
            Write a program that reads the information about a company and its manager and prints it back on the console.
         */
        static void Main(string[] args)
        {
            Console.Title = "Print Company Information";
            
            Console.Write("Enter Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Enter Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Enter Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter Fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("Enter Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Enter Maneger first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Maneger last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Maneger age: ");
            string age = Console.ReadLine();
            Console.Write("Enter Maneger phone: ");
            string manegerPhone = Console.ReadLine();

            string outputText = "{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\n{5} {6} (age: {7},tel. {8})";
            Console.WriteLine();
            Console.WriteLine(outputText,companyName,companyAddress,phoneNumber,faxNumber,webSite,firstName,lastName,age,manegerPhone);
        }
    }
}
