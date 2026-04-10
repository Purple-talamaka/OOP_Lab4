using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    // Контейнер для хранения фигур
    public class ShapeStorage
    {
        private List<CShape> _shapes = new List<CShape>();

        public void Add(CShape shape) => _shapes.Add(shape);

        public void Remove(CShape shape) => _shapes.Remove(shape);

        public int GetCount() => _shapes.Count;

        public CShape GetObject(int i) => _shapes[i];
    }
}
