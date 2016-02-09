namespace Shapes
{
    using System;

    internal class Rectangle : Shape
    {
        public Rectangle(double x, double y)
            : base(x, y)
        {
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Heigth;
        }
    }
}
