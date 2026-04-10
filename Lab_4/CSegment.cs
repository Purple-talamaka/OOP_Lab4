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

        public override void Resize(int delta)
        {
            // Удлиняем/укорачиваем отрезок от центра
            float cx = (_x1 + _x2) / 2f;
            float cy = (_y1 + _y2) / 2f;
            float dx = _x2 - _x1;
            float dy = _y2 - _y1;
            float len = (float)Math.Sqrt(dx * dx + dy * dy);
            if (len == 0) return;
            float newLen = Math.Max(5, len + delta);
            float scale = newLen / len;
            _x1 = (int)(cx - dx / 2 * scale);
            _y1 = (int)(cy - dy / 2 * scale);
            _x2 = (int)(cx + dx / 2 * scale);
            _y2 = (int)(cy + dy / 2 * scale);
        }

        public override void Move(int dx, int dy, int maxWidth, int maxHeight)
        {
            int newX1 = _x1 + dx, newY1 = _y1 + dy;
            int newX2 = _x2 + dx, newY2 = _y2 + dy;
            if (newX1 >= 0 && newX1 <= maxWidth && newX2 >= 0 && newX2 <= maxWidth &&
                newY1 >= 0 && newY1 <= maxHeight && newY2 >= 0 && newY2 <= maxHeight)
            {
                _x1 = newX1; _y1 = newY1;
                _x2 = newX2; _y2 = newY2;
            }
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
            Pen pen = IsSelected ? new Pen(Color.Blue, 2) : Pens.Black;
            g.DrawLine(pen, _x1, _y1, _x2, _y2);
        }
    }
    
}
