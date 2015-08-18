namespace ClassSizeInCSharp
{
    using System;

    public class Size
    {
        private double width = 0;
        private double heigth = 0;

        public Size(double width, double heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                double.TryParse(value.ToString(), out this.width);
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                double.TryParse(value.ToString(), out this.heigth);
            }

        }

        public static Size GetRotatedSize(Size size, double rotatedAngle)
        {
            double rotatedWidth = Math.Abs(Math.Cos(rotatedAngle)) * size.width + Math.Abs(Math.Sin(rotatedAngle)) * size.heigth;
            double rotatedHeigth = Math.Abs(Math.Sin(rotatedAngle)) * size.width + Math.Abs(Math.Cos(rotatedAngle)) * size.heigth;
            Size newRotatedSize = new Size(rotatedWidth, rotatedHeigth);

            return newRotatedSize;
        }
    }
}
