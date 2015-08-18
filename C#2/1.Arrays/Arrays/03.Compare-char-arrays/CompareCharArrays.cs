using System;

class CompareCharArrays
{
    /*
        Problem 3. Compare char arrays

        Write a program that compares two
        char arrays lexicographically (letter by letter).
     */
    static void Main()
    {
        Console.Title = "Compare char arrays";

        Console.Write("Enter the size of the first array:");
        int size1 = int.Parse(Console.ReadLine());

        char[] array1 = new char[size1];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < size1; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }

        Console.Write("Enter the size of the second array:");
        int size2 = int.Parse(Console.ReadLine());

        char[] array2 = new char[size2];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < size2; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }
        if (size1 == size2)
        {
            for (int i = 0; i < size2; i++)
            {
                if (Convert.ToInt32(array1[i]) == Convert.ToInt32(array2[i]))
                {
                    Console.WriteLine("the elements on position {0} in  two arrays are equal!", i);
                }
                else if (Convert.ToInt32(array1[i]) < Convert.ToInt32(array2[i]))
                {
                    Console.WriteLine("array1[{0}] is before array2[{0}]", i);
                }
                else
                {
                    Console.WriteLine("array1[{0}] is after array2[{0}]", i);
                }
            }
        }
        else
        {
            Console.WriteLine("the sizes of the arrays are different and comparing is not possible!");
        }


    }
}
