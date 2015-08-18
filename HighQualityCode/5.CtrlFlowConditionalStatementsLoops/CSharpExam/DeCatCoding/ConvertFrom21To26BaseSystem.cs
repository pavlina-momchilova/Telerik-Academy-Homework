namespace ConvertSystems
{
    using System;

    public class ConvertFrom21To26BaseSystem
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            string[] arr = input.Split(' ');
            string result = string.Empty;

            for (long i = 0; i < arr.Length; i++)
            {
                result = string.Concat(result, Converter.ConvertFrom21To26(arr[i]).ToString());
                result += " ";
            }

            Console.WriteLine(result);
        }
    }
}
