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
                g.FillEllipse(Brushes.LightBlue, left, top, size, size);
                g.DrawEllipse(new Pen(Color.Blue, 2), left, top, size, size);
            }
            else
            {
                g.FillEllipse(Brushes.LightGray, left, top, size, size);
                g.DrawEllipse(Pens.Black, left, top, size, size);
            }
        }
    }
}
