using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        private double sideLength;

        public Square(double x, double y, double sideLength) : base(x, y)
        {
            this.sideLength = sideLength;
        }

        public override void Resize(double scale)
        {
            sideLength *= scale;
        }

        public override void Rotate(double angle)
        {
            double radians = Math.PI * angle / 180;
            double newX = x * Math.Cos(radians) - y * Math.Sin(radians);
            double newY = x * Math.Sin(radians) + y * Math.Cos(radians);
            x = newX;
            y = newY;
        }

        public override string ToString()
        {
            return string.Format("Квадрат - {0}, Длина ребра: {1}", base.ToString(), sideLength);
        }
    }
}
