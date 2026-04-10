using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    // Абстрактный базовый класс для всех фигур
    public abstract class CShape
    {
        protected int _x;
        protected int _y;
        protected Color _color = Color.LightGray;

        public bool IsSelected { get; set; }

        // Перемещает фигуру на (dx, dy) с учётом границ области
        public virtual void Move(int dx, int dy, int maxWidth, int maxHeight)
        {
            _x = Math.Clamp(_x + dx, 0, maxWidth);
            _y = Math.Clamp(_y + dy, 0, maxHeight);
        }

        // Изменяет размер фигуры на delta
        public abstract void Resize(int delta);

        // Рисует фигуру на холсте
        public abstract void Draw(Graphics g);

        // Возвращает true если точка (x, y) попадает в фигуру
        public abstract bool HitTest(int x, int y);

        public void SetColor(Color color)
        {
            _color = color;
        }
    }
}
