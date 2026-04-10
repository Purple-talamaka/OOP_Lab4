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

            if (IsSelected)
            {
                g.FillRectangle(Brushes.LightBlue, left, top, _side, _side);
                g.DrawRectangle(new Pen(Color.Blue, 2), left, top, _side, _side);
            }
            else
            {
                g.FillRectangle(Brushes.LightGray, left, top, _side, _side);
                g.DrawRectangle(Pens.Black, left, top, _side, _side);
            }
        }
    }
}
