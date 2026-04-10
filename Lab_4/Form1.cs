namespace Lab_4
{
    public partial class Form1 : Form
    {
        private ShapeStorage _storage = new ShapeStorage();
        private string _currentTool = "Круг";
        private bool _isDragging = false;
        private Point _lastMousePos;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < _storage.GetCount(); i++)
                _storage.GetObject(i).Draw(e.Graphics);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                CShape? clicked = null;
                for (int i = 0; i < _storage.GetCount(); i++)
                {
                    if (_storage.GetObject(i).HitTest(e.X, e.Y))
                        clicked = _storage.GetObject(i);
                }

                if (clicked != null)
                {
                    if (Control.ModifierKeys == Keys.Control)
                    {
                        clicked.IsSelected = !clicked.IsSelected;
                    }
                    else
                    {
                        for (int i = 0; i < _storage.GetCount(); i++)
                            _storage.GetObject(i).IsSelected = false;
                        clicked.IsSelected = true;
                    }
                    _isDragging = true;
                    _lastMousePos = new Point(e.X, e.Y);
                }
                else
                {
                    for (int i = 0; i < _storage.GetCount(); i++)
                        _storage.GetObject(i).IsSelected = false;

                    switch (_currentTool)
                    {
                        case "Круг":
                            _storage.Add(new CCircle(e.X, e.Y, 50));
                            break;
                        case "Квадрат":
                            _storage.Add(new CSquare(e.X, e.Y, 100));
                            break;
                        case "Треугольник":
                            _storage.Add(new CTriangle(e.X, e.Y, 50));
                            break;
                        case "Отрезок":
                            _storage.Add(new CSegment(e.X, e.Y, e.X + 100, e.Y));
                            break;
                    }
                }

                Invalidate();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                int dx = e.X - _lastMousePos.X;
                int dy = e.Y - _lastMousePos.Y;
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).Move(dx, dy);
                _lastMousePos = new Point(e.X, e.Y);
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e); if (e.KeyCode == Keys.Delete)
            {
                for (int i = _storage.GetCount() - 1; i >= 0; i--)
                {
                    if (_storage.GetObject(i).IsSelected)
                        _storage.Remove(_storage.GetObject(i));
                }
                Invalidate();
            }

            int step = 5; if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).Move(-step, 0);
                Invalidate();
            }
            else if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).Move(step, 0);
                Invalidate();
            }
            else if (e.KeyCode == Keys.Up)
            {
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).Move(0, -step);
                Invalidate();
            }
            else if (e.KeyCode == Keys.Down)
            {
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).Move(0, step);
                Invalidate();
            }


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void menuItemColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < _storage.GetCount(); i++)
                    if (_storage.GetObject(i).IsSelected)
                        _storage.GetObject(i).SetColor(dlg.Color);
                Invalidate();
            }
        }

        private void btnCircle_Click(object sender, EventArgs e) => _currentTool = "Круг";
        private void btnSquare_Click(object sender, EventArgs e) => _currentTool = "Квадрат";
        private void btnTriangle_Click(object sender, EventArgs e) => _currentTool = "Треугольник";
        private void btnSegment_Click(object sender, EventArgs e) => _currentTool = "Отрезок";
    }
}
