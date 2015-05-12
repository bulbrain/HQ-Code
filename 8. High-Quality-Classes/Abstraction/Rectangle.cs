using System;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width, height;
        private double Width 
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Must be a positive number.");
                }
                this.width = value;
            }
        }
        private double Height 
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Must be a positive number.");
                }
                this.height = value;
            }
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
