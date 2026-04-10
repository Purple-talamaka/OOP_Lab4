using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class CSquare : CShape
    {
        private int _side;

        public CSquare(int x, int y, int side)
        {
            _x = x;
            _y = y;
            _side = side;
        }

        public override void Resize(int delta)
        {
            _side = Math.Max(5, _side + delta);
        }

        // Центр не выходит за границы с учётом половины стороны
        public override void Move(int dx, int dy, int maxWidth, int maxHeight)
        {
            int half = _side / 2;
            _x = Math.Clamp(_x + dx, half, maxWidth - half);
            _y = Math.Clamp(_y + dy, half, maxHeight - half);
        }

        public override bool HitTest(int x, int y)
        {
            int half = _side / 2;
            return x >= _x - half && x <= _x + half && y >= _y - half && y <= _y + half;
        }

        public override void Draw(Graphics g)
        {
            int half = _side / 2;
            int left = _x - half;
            int top = _y - half;

            g.FillRectangle(new SolidBrush(_color), left, top, _side, _side);
            g.DrawRectangle(IsSelected ? new Pen(Color.Blue, 2) : Pens.Black, left, top, _side, _side);
        }
    }
}
