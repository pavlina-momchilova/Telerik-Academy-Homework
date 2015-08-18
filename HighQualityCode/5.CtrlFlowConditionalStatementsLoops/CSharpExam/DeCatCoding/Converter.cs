namespace ConvertSystems
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Text;

    public class Converter
    {
        public static StringBuilder ConvertFrom21To26(string word)
        {
            var lettersAsDigits = new List<BigInteger>();

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        lettersAsDigits.Add(0);
                        break;
                    case 'b':
                        lettersAsDigits.Add(1);
                        break;
                    case 'c':
                        lettersAsDigits.Add(2);
                        break;
                    case 'd':
                        lettersAsDigits.Add(3);
                        break;
                    case 'e':
                        lettersAsDigits.Add(4);
                        break;
                    case 'f':
                        lettersAsDigits.Add(5);
                        break;
                    case 'g':
                        lettersAsDigits.Add(6);
                        break;
                    case 'h':
                        lettersAsDigits.Add(7);
                        break;
                    case 'i':
                        lettersAsDigits.Add(8);
                        break;
                    case 'j':
                        lettersAsDigits.Add(9);
                        break;
                    case 'k':
                        lettersAsDigits.Add(10);
                        break;
                    case 'l':
                        lettersAsDigits.Add(11);
                        break;
                    case 'm':
                        lettersAsDigits.Add(12);
                        break;
                    case 'n':
                        lettersAsDigits.Add(13);
                        break;
                    case 'o':
                        lettersAsDigits.Add(14);
                        break;
                    case 'p':
                        lettersAsDigits.Add(15);
                        break;
                    case 'q':
                        lettersAsDigits.Add(16);
                        break;
                    case 'r':
                        lettersAsDigits.Add(17);
                        break;
                    case 's':
                        lettersAsDigits.Add(18);
                        break;
                    case 't':
                        lettersAsDigits.Add(19);
                        break;
                    case 'u':
                        lettersAsDigits.Add(20);
                        break;
                }
            }

            BigInteger in21BinSystem = 0;
            int pow = lettersAsDigits.Count - 1;

            for (int i = 0; i < lettersAsDigits.Count; i++)
            {
                in21BinSystem += lettersAsDigits[i] * (BigInteger)Math.Pow(21, pow);
                pow--;
            }

            StringBuilder convertedString = new StringBuilder();
            var convertedDigits = new List<ulong>();
            ulong reminder = 0;

            while (in21BinSystem / 26 > 0)
            {
                if (convertedDigits.Count >= 1)
                {
                    in21BinSystem /= 26;
                }

                reminder = (ulong)(in21BinSystem % 26);
                convertedDigits.Add(reminder);
            }

            for (int i = convertedDigits.Count - 1; i >= 0; i--)
            {
                switch (convertedDigits[i])
                {
                    case 0:
                        convertedString.Append('a');
                        break;
                    case 1:
                        convertedString.Append('b');
                        break;
                    case 2:
                        convertedString.Append('c');
                        break;
                    case 3:
                        convertedString.Append('d');
                        break;
                    case 4:
                        convertedString.Append('e');
                        break;
                    case 5:
                        convertedString.Append('f');
                        break;
                    case 6:
                        convertedString.Append('g');
                        break;
                    case 7:
                        convertedString.Append('h');
                        break;
                    case 8:
                        convertedString.Append('i');
                        break;
                    case 9:
                        convertedString.Append('j');
                        break;
                    case 10:
                        convertedString.Append('k');
                        break;
                    case 11:
                        convertedString.Append('l');
                        break;
                    case 12:
                        convertedString.Append('m');
                        break;
                    case 13:
                        convertedString.Append('n');
                        break;
                    case 14:
                        convertedString.Append('o');
                        break;
                    case 15:
                        convertedString.Append('p');
                        break;
                    case 16:
                        convertedString.Append('q');
                        break;
                    case 17:
                        convertedString.Append('r');
                        break;
                    case 18:
                        convertedString.Append('s');
                        break;
                    case 19:
                        convertedString.Append('t');
                        break;
                    case 20:
                        convertedString.Append('u');
                        break;
                    case 21:
                        convertedString.Append('v');
                        break;
                    case 22:
                        convertedString.Append('w');
                        break;
                    case 23:
                        convertedString.Append('x');
                        break;
                    case 24:
                        convertedString.Append('y');
                        break;
                    case 25:
                        convertedString.Append('z');
                        break;
                }
            }

            return convertedString;
        }
    }
}
