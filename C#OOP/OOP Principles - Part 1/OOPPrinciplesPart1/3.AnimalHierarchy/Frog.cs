using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Frog :Animals
    {
          #region constructors
        public Frog(byte age, string name, Sex sex)
            : base(age, name, sex)
        {

        }
        #endregion

        #region methods
        public override void produceSound()
        {
            Console.WriteLine("kvak");
        }
        #endregion

    }
}
