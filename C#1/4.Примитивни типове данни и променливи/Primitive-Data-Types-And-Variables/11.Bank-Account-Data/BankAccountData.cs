using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Bank_Account_Data
{
    class BankAccountData
    {
        /*
            Problem 11. Bank Account Data

            A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
            Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

         */
        static void Main(string[] args)
        {
            string bankAccount = "BANK ACCOUNT";
            string separator = "--------------------------------------------";
            string firstName = "Jane";
            string middleName = "Perez";
            string lastName = "Down";
            string holderName = firstName+ " " + middleName+ " " + lastName;
            double balance = 1956566.53;
            string bankName = "Alliance bank";
            string iban = "GB 12 CPBK 0892 9965 0449 91";
            ulong creditCardNumber1 = 4000123456789123;
            ulong creditCardNumber2 = 3000123456780123;
            ulong creditCardNumber3 = 1000123556789123;
            Console.WriteLine(bankAccount);
            Console.WriteLine(separator);
            Console.WriteLine("Full name : " + holderName);
            Console.WriteLine("Balance : " + balance);
            Console.WriteLine("Bank name : " + bankName);
            Console.WriteLine("IBAN : " + iban);
            Console.WriteLine("First Credit card number : " + creditCardNumber1);
            Console.WriteLine("Second Credit card number : " + creditCardNumber2);
            Console.WriteLine("Third Credit card number : " + creditCardNumber3);
        }
    }
}
