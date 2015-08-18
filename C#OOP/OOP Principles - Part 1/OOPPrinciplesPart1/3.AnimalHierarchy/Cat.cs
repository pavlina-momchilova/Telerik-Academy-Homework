namespace _3.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cat : Animals
    {
         #region constructors
        public Cat(byte age, string name, Sex sex)
            : base(age, name, sex)
        {

        }
        #endregion

        #region methods
        public override void produceSound()
        {
            Console.WriteLine("meaw");
        }
        #endregion
    }
}
