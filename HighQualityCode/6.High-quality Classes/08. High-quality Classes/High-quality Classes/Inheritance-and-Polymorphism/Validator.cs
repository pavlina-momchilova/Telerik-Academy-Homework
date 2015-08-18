namespace InheritanceAndPolymorphism
{
    using System;

    internal class Validator
    {
        internal static void IsEmpty(string value, string name)
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The " + name + " cannot be empty!");
            }
        }
    }
}
