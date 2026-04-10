using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public abstract class CShape
    {
        protected int _x;
        protected int _y;
        protected Color _color;
        protected bool _isSelected;

        public void Move(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public abstract void Draw(Graphics g);

        public abstract bool HitTest(int x, int y);
    }
}
