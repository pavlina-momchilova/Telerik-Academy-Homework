namespace _1.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        #region fields
        private decimal width;
        private decimal height;
        #endregion

        #region constructors
        public Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }
        #endregion

        #region properties
        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width cannot be less or equal to zero!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width cannot be less or equal to zero!");
                }
                else
                {
                    this.height = value;
                }
            }
        }
        #endregion

        #region Methods
        public abstract decimal CalculateSurface();
        #endregion
    }
}
