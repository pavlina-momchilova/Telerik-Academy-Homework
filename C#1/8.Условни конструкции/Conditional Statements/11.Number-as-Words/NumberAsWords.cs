using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Number_as_Words
{
    class NumberAsWords
    {
        /*
            Problem 11.* Number as Words

            Write a program that converts a number in
            the range [0…999] to words, corresponding to
            the English pronunciation.

         */
        static void Main()
        {
            Console.WriteLine("Enter an number between 0 and 999");
            Console.Title = "Number as Words";
            int intNumber=int.Parse(Console.ReadLine());
            string number = Convert.ToString(intNumber);
            while (intNumber > 999 || intNumber < 0)
            {
                Console.WriteLine("Wrong number!! Pleas insert a number between 0 and 999!!!");
                intNumber = int.Parse(Console.ReadLine());
                number = Convert.ToString(intNumber);
            }
           
            #region 3DigitNumber
                if (number.Length == 3)
                {
                    switch (number[0])
                    {
                        case '1': Console.Write("One");
                            break;
                        case '2': Console.Write("Two");
                            break;
                        case '3': Console.Write("Three");
                            break;
                        case '4': Console.Write("Four");
                            break;
                        case '5': Console.Write("Five");
                            break;
                        case '6': Console.Write("Six");
                            break;
                        case '7': Console.Write("Seven");
                            break;
                        case '8': Console.Write("Eight");
                            break;
                        case '9': Console.Write("Nine");
                            break;
                    }
                    Console.Write(" hundred ");
                    if (number[1] == '0')
                    {
                        if (number[2] != '0')
                        {
                            Console.Write(" and ");
                            switch (number[2])
                            {
                                case '0': Console.Write("zero ");
                                    break;
                                case '1': Console.Write("one ");
                                    break;
                                case '2': Console.Write("two ");
                                    break;
                                case '3': Console.Write("three ");
                                    break;
                                case '4': Console.Write("four ");
                                    break;
                                case '5': Console.Write("five ");
                                    break;
                                case '6': Console.Write("six ");
                                    break;
                                case '7': Console.Write("seven ");
                                    break;
                                case '8': Console.Write("eight ");
                                    break;
                                case '9': Console.Write("nine ");
                                    break;
                            }

                        }

                    }
                    else if (number[1] == '1')
                    {
                        Console.Write(" and ");
                        switch (number[2])
                        {
                            case '0': Console.Write("ten ");
                                break;
                            case '1': Console.Write("eleven ");
                                break;
                            case '2': Console.Write("twelve ");
                                break;
                            case '3': Console.Write("thirteen ");
                                break;
                            case '4': Console.Write("fourteen ");
                                break;
                            case '5': Console.Write("fiveteen ");
                                break;
                            case '6': Console.Write("sixteen ");
                                break;
                            case '7': Console.Write("seventeen ");
                                break;
                            case '8': Console.Write("eighteen ");
                                break;
                            case '9': Console.Write("nineteen ");
                                break;
                        }
                    }
                    else
                    {
                        Console.Write(" and ");
                        switch (number[1])
                        {
                            case '2': Console.Write("twenty ");
                                break;
                            case '3': Console.Write("thirty ");
                                break;
                            case '4': Console.Write("fourty ");
                                break;
                            case '5': Console.Write("fifty ");
                                break;
                            case '6': Console.Write("sixty ");
                                break;
                            case '7': Console.Write("seventy ");
                                break;
                            case '8': Console.Write("eighty ");
                                break;
                            case '9': Console.Write("ninety ");
                                break;
                        }
                        switch (number[2])
                        {
                            case '1': Console.Write("one ");
                                break;
                            case '2': Console.Write("two ");
                                break;
                            case '3': Console.Write("three ");
                                break;
                            case '4': Console.Write("four ");
                                break;
                            case '5': Console.Write("five ");
                                break;
                            case '6': Console.Write("six ");
                                break;
                            case '7': Console.Write("seven ");
                                break;
                            case '8': Console.Write("eight ");
                                break;
                            case '9': Console.Write("nine ");
                                break;
                        }
                    }
                }
                #endregion
            #region 2DigitNumber
                if (number.Length == 2)
                {
                    if (number[0] == '1')
                    {
                        switch (number[1])
                        {
                            case '0': Console.Write("Ten ");
                                break;
                            case '1': Console.Write("Eleven ");
                                break;
                            case '2': Console.Write("Twelve ");
                                break;
                            case '3': Console.Write("Thirteen ");
                                break;
                            case '4': Console.Write("Fourteen ");
                                break;
                            case '5': Console.Write("Fiveteen ");
                                break;
                            case '6': Console.Write("Sixteen ");
                                break;
                            case '7': Console.Write("Seventeen ");
                                break;
                            case '8': Console.Write("Eighteen ");
                                break;
                            case '9': Console.Write("Nineteen ");
                                break;
                        }
                    }
                    else
                    {
                        switch (number[0])
                        {
                            case '2': Console.Write("Twenty ");
                                break;
                            case '3': Console.Write("Thirty ");
                                break;
                            case '4': Console.Write("Fourty ");
                                break;
                            case '5': Console.Write("Fifty ");
                                break;
                            case '6': Console.Write("Sixty ");
                                break;
                            case '7': Console.Write("Seventy ");
                                break;
                            case '8': Console.Write("Eighty ");
                                break;
                            case '9': Console.Write("Ninety ");
                                break;
                        }
                        switch (number[1])
                        {
                            case '1': Console.Write("one ");
                                break;
                            case '2': Console.Write("two ");
                                break;
                            case '3': Console.Write("three ");
                                break;
                            case '4': Console.Write("four ");
                                break;
                            case '5': Console.Write("five ");
                                break;
                            case '6': Console.Write("six ");
                                break;
                            case '7': Console.Write("seven ");
                                break;
                            case '8': Console.Write("eight ");
                                break;
                            case '9': Console.Write("nine ");
                                break;
                        }
                    }
                }
                #endregion
            #region 1DigitNumber
                if (number.Length == 1)
                {
                    switch (number[0])
                    {
                        case '0': Console.Write("Zero ");
                            break;
                        case '1': Console.Write("One ");
                            break;
                        case '2': Console.Write("Two ");
                            break;
                        case '3': Console.Write("Three ");
                            break;
                        case '4': Console.Write("Four ");
                            break;
                        case '5': Console.Write("Five ");
                            break;
                        case '6': Console.Write("Six ");
                            break;
                        case '7': Console.Write("Seven ");
                            break;
                        case '8': Console.Write("Eight ");
                            break;
                        case '9': Console.Write("Nine ");
                            break;
                    }
                }
                #endregion
        }
    }
}
