namespace _05.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MainClass
    {
        /*
            Problem 17. Longest string

            Write a program to return the string with maximum length from an array of strings.
            Use LINQ.
         */
        static void Main()
        {
            string[] arr = new string[]
            {
                "2s","3ss","8sssssss","6sssss","5ssss","7sssssss","4sss"
            };

            var maxString = from element in arr
                            where element == arr.Max()
                            select element;
            //Console.WriteLine(maxString);
            foreach (var max in maxString)
            {
                Console.WriteLine(max);
            }
        }
    }
}
