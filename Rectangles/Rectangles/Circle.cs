using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rectangles
{
    class Circle : Figure
    {
        #region переменные дляконструктора
        
        private Pen p;
        #endregion

        #region конструкторы

        public Circle(int width, int height, Point center, Pen p) : base(width, height, center, p)
        {
            this.width = width;
            this.height = height;
            this.center.X = center.X;
            this.center.Y = center.Y;
            this.p = p;
        }
        #endregion

        override public void  Draw(Graphics g)
        {
            Point point = new Point();

            point.X = center.X - width / 2;
            point.Y = center.Y - height / 2;
            g.DrawEllipse(p, point.X, point.Y, width, height);
        }

        override public void Move(Point cursor)
        {
            center = cursor;
        }

        override public bool IsPointInside(Point cursor)
        {
            int lenX = Math.Abs(center.X - cursor.X);
            int lenY = Math.Abs(center.Y - cursor.Y);
            double rad = Math.Sqrt(Math.Pow(lenX,2) + Math.Pow(lenY,2));
            if (rad <= width / 2) return true;
            else return false;
        }
    }
}
