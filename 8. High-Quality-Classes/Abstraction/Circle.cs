using System;

namespace Abstraction
{
    public class Circle : Figure
    {
        private double radius;
        private double Radius
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Must be a positive number.");
                }
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
