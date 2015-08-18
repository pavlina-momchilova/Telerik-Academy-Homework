namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /*
        Problem 11. Version attribute

        Create a [Version] attribute that can be applied to structures, classes, interfaces,
        enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
        Apply the version attribute to a sample class and display its version at runtime.
     */
    [Version(2,0)]
    class Sample
    {
        static void Main()
        {
            Type type = typeof(Sample);
            object[] versionAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attribute in versionAttributes)
            {
                Console.WriteLine("The version is: {0}.{1}",attribute.Major,attribute.Minor);
            }
            Console.WriteLine();
        }
    }
}
