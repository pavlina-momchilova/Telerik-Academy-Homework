using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Kitten :Cat
    {
        #region constructors
        public Kitten(byte age, string name, Sex sex= Sex.female)
            : base(age, name, sex)
        {

        }
        #endregion
    }
}
