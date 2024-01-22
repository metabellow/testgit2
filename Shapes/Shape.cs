using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        protected double x;
        protected double y;

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        public virtual void Resize(double scale)
        {

        }

        public virtual void Rotate(double angle)
        {
        }

        public override string ToString()
        {
            return string.Format("Позиция: ({0}, {1})", x, y);
        }
    }
}
