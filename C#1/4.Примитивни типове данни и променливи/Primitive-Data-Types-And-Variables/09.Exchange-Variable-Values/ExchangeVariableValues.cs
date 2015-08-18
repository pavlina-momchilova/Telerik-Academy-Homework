using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        /*
            Problem 9. Exchange Variable Values

            Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
            Print the variable values before and after the exchange.
         */
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("before exchange a=" + a + "b=" + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after exchange a=" + a + "b=" + b);
        }
    }
}
