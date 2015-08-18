namespace _3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dog : Animals
    {
        #region constructors
        public Dog(byte age, string name, Sex sex)
            : base(age, name, sex)
        {

        }
        #endregion

        #region methods
        public override void produceSound()
        {
            Console.WriteLine("Bau Bau");
        }
        #endregion
    }
}
