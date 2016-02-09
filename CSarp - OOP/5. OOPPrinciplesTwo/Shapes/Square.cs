namespace Shapes
{
    using System;

    internal class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        {
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Heigth;
        }
    }
}
