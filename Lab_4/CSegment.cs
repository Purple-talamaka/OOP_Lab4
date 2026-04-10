using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class CSegment : CShape
    {
        private int _x1, _y1, _x2, _y2;
        public CSegment(int x1, int y1, int x2, int y2)
        {
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
        }

        public override void Move(int dx, int dy)
        {
            _x1 += dx;
            _y1 += dy;
            _x2 += dx;
            _y2 += dy;
        }

        public override bool HitTest(int x, int y)
        {
            int tolerance = 5;
            float dx = _x2 - _x1;
            float dy = _y2 - _y1;
            float len = (float)Math.Sqrt(dx * dx + dy * dy);
            if (len == 0) return false;
            float dist = Math.Abs(dy * x - dx * y + _x2 * _y1 - _y2 * _x1) / len;
            return dist <= tolerance;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = _isSelected ? new Pen(Color.Blue, 2) : Pens.Black;
            g.DrawLine(pen, _x1, _y1, _x2, _y2);
        }
    }
    
}
