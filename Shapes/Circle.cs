using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Resize(double scale)
        {
            radius *= scale;
        }

        public override string ToString()
        {
            return string.Format("Круг - {0}, Радиус: {1}", base.ToString(), radius);
        }
    }
}
