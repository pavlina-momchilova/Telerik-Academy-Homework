

namespace _01.StringBuilder.Substring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public static class StringBuilderExtencions
    {
        /*
            Problem 1. StringBuilder.Substring

            Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
         */
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder substring = new StringBuilder();
            for (int i = index; i < (index+length); i++)
            {
                substring.Append(sb[i]);
            }
            return substring;
        }
    }
}
