namespace Abstraction
{
    using System;

    class Rectangle : Figure
    {
        public double height;
        public double width;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width {
            get
            {
                return this.width;
            }
            set
            {
                Validator.IsPositiveNumber(value, "width");
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                Validator.IsPositiveNumber(value, "height");
                this.height = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
