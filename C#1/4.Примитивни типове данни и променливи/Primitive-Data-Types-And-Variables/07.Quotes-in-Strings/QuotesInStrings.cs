using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Quotes_in_Strings
{
    class QuotesInStrings
    {
        /*
            Problem 7. Quotes in Strings

            Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
            Do the above in two different ways - with and without using quoted strings.
            Print the variables to ensure that their value was correctly defined.

         */
        static void Main(string[] args)
        {
            string quotesBackSlash="The \"use\" of quotations causes difficulties.";
            string quote =@"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("with use of \\ : " + quotesBackSlash);
            Console.WriteLine("with use of @ : " + quote);
        }
    }
}
