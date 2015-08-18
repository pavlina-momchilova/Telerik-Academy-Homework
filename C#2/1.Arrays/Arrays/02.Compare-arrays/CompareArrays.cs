using System;

class CompareArrays
{
    /*
        Problem 2. Compare arrays

        Write a program that reads two integer arrays from
        the console and compares them element by element.
     */
    static void Main()
    {
        Console.Title = "Compare arrays";
        
        Console.Write("Enter the size of the first array:");
        int size1 = int.Parse(Console.ReadLine());

        int[] array1 = new int[size1];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < size1; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

            Console.Write("Enter the size of the second array:");
        int size2 = int.Parse(Console.ReadLine());

        int[] array2 = new int[size2];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < size2; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        if (size1 == size2)
        {
            for (int i = 0; i < size1; i++)
            {
                if (array1[i] == array2[i])
                {
                    Console.WriteLine("the elements on position {0} in  two arrays are equal!",i);
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine("{0}>{1} => array1[{2}]>array2[{2}]",array1[i],array2[i],i);
                }
                else
                {
                    Console.WriteLine("{0}<{1} => array1[{2}]<array2[{2}]", array1[i], array2[i], i);
                }
            }
        }
        else
        {
            Console.WriteLine("the sizes of the arrays are different and comparing is not possible!");
        }
    }
}
