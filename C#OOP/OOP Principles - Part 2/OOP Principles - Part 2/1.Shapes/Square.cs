using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public class Square : Shape
    {
        public Square(decimal side)
            : base(side, side)
        {

        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}
