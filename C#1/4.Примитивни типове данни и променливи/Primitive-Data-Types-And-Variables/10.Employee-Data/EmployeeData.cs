using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Employee_Data
{
    class EmployeeData
    {
        /*
            Problem 10. Employee Data

            A marketing company wants to keep record of its employees. Each record would have the following characteristics:

            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)

            Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
         */
        static void Main(string[] args)
        {
            string firstName = "Anastasia";
            string lastName = "Petrovich";
            byte age = 21;
            char gender = 'f';
            long idNumber = 830611257;
            ulong employeeNumber = 2756000027569999;
            Console.WriteLine("First name : " + firstName);
            Console.WriteLine("Last name : " + lastName);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Personal ID number : " + idNumber);
            Console.WriteLine("Unique employee number : " + employeeNumber);
        }
    }
}
