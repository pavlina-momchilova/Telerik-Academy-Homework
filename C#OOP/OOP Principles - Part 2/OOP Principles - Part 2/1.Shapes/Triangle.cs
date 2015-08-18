namespace _1.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height)
            : base(width, height)
        {

        }

        public override decimal CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
