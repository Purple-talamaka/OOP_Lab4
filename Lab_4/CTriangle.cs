using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class CTriangle : CShape
    {
        private int _size;
        public CTriangle(int x, int y, int size)
        {
            _x = x;
            _y = y;
            _size = size;
        }

        public override void Resize(int delta)
        {
            _size = Math.Max(5, _size + delta);
        }

        public override void Move(int dx, int dy, int maxWidth, int maxHeight)
        {
            _x = Math.Clamp(_x + dx, _size, maxWidth - _size);
            _y = Math.Clamp(_y + dy, _size, maxHeight - _size);
        }

        private Point[] GetVertices()
        {
            return new Point[]
            {
          new Point(_x + (int)(_size * Math.Cos(Math.PI / 2)),   _y - (int)(_size * Math.Sin(Math.PI / 2))),
          new Point(_x + (int)(_size * Math.Cos(7 * Math.PI / 6)), _y - (int)(_size * Math.Sin(7 * Math.PI / 6))),
          new Point(_x + (int)(_size * Math.Cos(11 * Math.PI / 6)), _y - (int)(_size * Math.Sin(11 * Math.PI / 6)))
            };
        }

        public override bool HitTest(int x, int y)
        {
            Point[] v = GetVertices();
            int d1 = Sign(x, y, v[0], v[1]);
            int d2 = Sign(x, y, v[1], v[2]);
            int d3 = Sign(x, y, v[2], v[0]);

            bool hasNeg = (d1 < 0) || (d2 < 0) || (d3 < 0);
            bool hasPos = (d1 > 0) || (d2 > 0) || (d3 > 0);

            return !(hasNeg && hasPos);
        }

        private int Sign(int px, int py, Point a, Point b)
        {
            return (px - b.X) * (a.Y - b.Y) - (a.X - b.X) * (py - b.Y);
        }

        public override void Draw(Graphics g)
        {
            Point[] v = GetVertices();
            if (IsSelected)
            {
                g.FillPolygon(new SolidBrush(_color), v);
                g.DrawPolygon(new Pen(Color.Blue, 2), v);
            }
            else
            {
                g.FillPolygon(new SolidBrush(_color), v);
                g.DrawPolygon(Pens.Black, v);
            }
        }
    }
}
