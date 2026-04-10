using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class CCircle : CShape
    {
        private int _radius;
        public CCircle(int x, int y, int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Move(int dx, int dy, int maxWidth, int maxHeight)
        {
            _x = Math.Clamp(_x + dx, _radius, maxWidth - _radius);
            _y = Math.Clamp(_y + dy, _radius, maxHeight - _radius);
        }

        public override bool HitTest(int x, int y)
        {
            int dx = x - _x;
            int dy = y - _y;
            return dx * dx + dy * dy <= _radius * _radius;
        }

        public override void Draw(Graphics g)
        {
            int left = _x - _radius;
            int top = _y - _radius;
            int size = _radius * 2;

            if (IsSelected)
            {
                g.FillEllipse(new SolidBrush(_color), left, top, size, size);
                g.DrawEllipse(new Pen(Color.Blue, 2), left, top, size, size);
            }
            else
            {
                g.FillEllipse(new SolidBrush(_color), left, top, size, size);
                g.DrawEllipse(Pens.Black, left, top, size, size);
            }
        }
    }
}
