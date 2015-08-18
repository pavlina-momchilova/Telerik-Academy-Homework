using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Zero_Subset
{
    class ZeroSubset
    {
        /*
            Problem 12.* Zero Subset

            We are given 5 integer numbers. Write a program
            that finds all subsets of these numbers whose sum is 0.
            Assume that repeating the same subset several times
            is not a problem.

         */
        static void Main()
        {
            Console.Title = "Zero Subset";

            Console.WriteLine("Enter 1 number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2 number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3 number: ");
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 4 number: ");
            int numberFour = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 5 number: ");
            int numberFive = int.Parse(Console.ReadLine());

            bool flag = false;

            int[] numbers = { numberOne, numberTwo, numberThree, numberFour, numberFive };
            //check if sum of all numbers is 0
            #region FiveNumbers
            if ((numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                flag = true;
            }
            #endregion

            //check if sum of four numbers is 0
            #region FourNumbers
            if ((numbers[0] + numbers[1] + numbers[2] + numbers[3])==0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[1], numbers[2], numbers[3]);
                flag = true;
            }
            if ((numbers[0] + numbers[1] + numbers[2] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[1], numbers[2], numbers[4]);
                flag = true;
            }
            if ((numbers[0] + numbers[1] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[1], numbers[3], numbers[4]);
                flag = true;
            }
            if ((numbers[0] + numbers[2] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[0], numbers[2], numbers[3], numbers[4]);
                flag = true;
            }
            if ((numbers[1] + numbers[2] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[1], numbers[2], numbers[3], numbers[4]);
                flag = true;
            }
            #endregion

            //check if sum of three numbers is 0
            #region ThreeNumbers
            if ((numbers[0] + numbers[1] + numbers[2]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[2]);
                flag = true;
            }
            if ((numbers[0] + numbers[1] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[3]);
                flag = true;
            }
            if ((numbers[0] + numbers[1] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[4]);
                flag = true;
            }
            if ((numbers[0] + numbers[2] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[2], numbers[3]);
                flag = true;
            }
            if ((numbers[0] + numbers[2] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[2], numbers[4]);
                flag = true;
            }
            if ((numbers[0] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[3], numbers[4]);
                flag = true;
            }
            if ((numbers[1] + numbers[2] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[2], numbers[3]);
                flag = true;
            }
            if ((numbers[1] + numbers[2] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[2], numbers[4]);
                flag = true;
            }
            if ((numbers[1] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[3], numbers[4]);
                flag = true;
            }
            if ((numbers[2] + numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[2], numbers[3], numbers[4]);
                flag = true;
            }
            #endregion

            //check if sum of three numbers is 0
            #region TwoNumbers
            if ((numbers[0] + numbers[1]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[1]);
                flag = true;
            }
            if ((numbers[0] + numbers[2]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[2]);
                flag = true;
            }
            if ((numbers[0] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[3]);
                flag = true;
            }
            if ((numbers[0] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[4]);
                flag = true;
            }
            if ((numbers[1] + numbers[2]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[2]);
                flag = true;
            }
            if ((numbers[1] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[3]);
                flag = true;
            }
            if ((numbers[1] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[4]);
                flag = true;
            }
            if ((numbers[2] + numbers[3]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[3]);
                flag = true;
            }
            if ((numbers[2] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[4]);
                flag = true;
            }
            if ((numbers[3] + numbers[4]) == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[3], numbers[4]);
                flag = true;
            }
            #endregion
            
            //if there is no subset
            if (flag == false)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
