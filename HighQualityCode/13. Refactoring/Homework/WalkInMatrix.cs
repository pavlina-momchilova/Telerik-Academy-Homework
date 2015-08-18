namespace RotatingWalkInMatrix
{
    using System;

    public class WalkInMatrica
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the matrix between 1 and 100");
            string input = Console.ReadLine();
            int size = 0;
            while (!int.TryParse(input, out size) || size < 0 || size > 100)
            {
                Console.WriteLine("You enter wrong input, please enter number between 1 and 100: ");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(size);
            Console.WriteLine(matrix);
        }
    }
}
