using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            this.width = width;
            this.height = height;
        }

        public override void Resize(double scale)
        {
            width *= scale;
            height *= scale;
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
            return string.Format("Прямоугольник - {0}, Ширина: {1}, Длина: {2}", base.ToString(), width, height);
        }
    }
}
