using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Tomcat:Cat
    {
        #region constructors
        public Tomcat(byte age, string name, Sex sex=Sex.male)
            : base(age, name, sex)
        {

        }
        #endregion
    }
}
