﻿using System;

namespace Shapes
{
    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Height;
        }
    }
}
