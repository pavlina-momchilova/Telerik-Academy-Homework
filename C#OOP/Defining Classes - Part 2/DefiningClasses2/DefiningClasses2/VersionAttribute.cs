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

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }
            private set
            {
                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
            private set
            {
                this.minor = value;
            }
        }

    }
}
