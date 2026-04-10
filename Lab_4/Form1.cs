namespace Lab_4
{
    public partial class Form1 : Form
    {
        private ShapeStorage _storage = new ShapeStorage();
        private string _currentTool = "Круг";

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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnCircle_Click(object sender, EventArgs e) => _currentTool = "Круг";
        private void btnSquare_Click(object sender, EventArgs e) => _currentTool = "Квадрат";
        private void btnTriangle_Click(object sender, EventArgs e) => _currentTool = "Треугольник";
        private void btnSegment_Click(object sender, EventArgs e) => _currentTool = "Отрезок";
    }
}
