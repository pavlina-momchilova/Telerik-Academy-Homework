﻿using System;
class AllocateArray

{
    /*
        Problem 1. Allocate array

        Write a program that allocates array of 20 integers and
        initializes each element by its index multiplied by 5.
        Print the obtained array on the console.
     */
    static void Main()
    {
        Console.Title = "Allocate array";
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}
