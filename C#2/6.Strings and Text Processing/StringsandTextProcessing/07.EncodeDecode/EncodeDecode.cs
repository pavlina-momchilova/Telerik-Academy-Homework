using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        /*
         Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
         */
        static void Main()
        {
            Console.WriteLine("Enter string to encode; ");
            string toEncode = Console.ReadLine();
            Console.WriteLine("Enter a key: ");
            string key = Console.ReadLine();
            if (key.Length < toEncode.Length)
            {
                int index=0;
                for (int i = key.Length; i < toEncode.Length; i++)
                {
                    key += key[index];
                    index++;
                }
            }
            else if (key.Length > toEncode.Length)
            {
                int index=0;
                string newKey = "";
                for (int i = 0; i < toEncode.Length; i++)
                {
                    newKey+= key[index];
                    index++;
                }
                key = newKey;
            }
            string encoding = String.Empty;

            for (int i = 0; i < toEncode.Length; i++)
            {
                encoding += (char)((toEncode[i] ^ key[i]));
            }
            Console.WriteLine("Encoding: " + encoding);
            string decoding = String.Empty;
            for (int i = 0; i < toEncode.Length; i++)
            {
                decoding += (char)((encoding[i] ^ key[i]));
            }
            Console.WriteLine("Decoding: " + decoding);
        }
    }
}
