namespace RefactorTheFollowingLoop
{
    using System;

    public class SearchValue
    {
        public static void Main(string[] args)
        {
            int[] array = new int[100];
            int expectedValue = 0;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);

                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}
