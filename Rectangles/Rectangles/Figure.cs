using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rectangles
{
    abstract public class Figure
    {
        private Pen p;

        public Point center;
        public int width;
        public int height;

        public Figure(int width, int height, Point center, Pen p)
        {
            this.height = height;
            this.width = width;
            this.center.X = center.X;
            this.center.Y = center.Y;
            this.p = p;
        }

        virtual public void Draw(Graphics g) { }

        virtual public void Move(Point cursor) { }

        abstract public bool IsPointInside(Point cursor);
    }
}
