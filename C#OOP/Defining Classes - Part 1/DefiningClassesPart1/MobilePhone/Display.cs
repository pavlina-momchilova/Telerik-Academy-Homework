using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Display
    {
        private double? size;
        private int? colors;

        public Display()
            : this(null)
        {

        }

        public Display(double? size)
            : this(size, null)
        {

        }

        public Display(double? size, int? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                this.colors = value;
            }
        }

        public override string ToString()
        {
            return String.Format("\n   - Size : {0}\n   - Colors : {1}",
            this.size.ToString() ?? "[unknown]", this.colors.ToString() ?? "[unknown]");
        }
    }
}
