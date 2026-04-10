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
        protected Color _color = Color.LightGray;

        public virtual void Move(int dx, int dy)
        {
            _x += dx;
            _y += dy;
        }

        public abstract void Draw(Graphics g);

        public abstract bool HitTest(int x, int y);

        public bool IsSelected { get; set; }

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
