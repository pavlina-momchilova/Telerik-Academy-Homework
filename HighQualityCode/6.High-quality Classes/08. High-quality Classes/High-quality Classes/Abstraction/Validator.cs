namespace Abstraction
{
    using System;

    internal class Validator
    {
        internal static void IsPositiveNumber(double value, string name)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The " + name + " must be positive number!");
            }
        }
    }
}
