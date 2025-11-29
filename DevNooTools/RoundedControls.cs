using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    public static class RoundedHelper
    {
        public static GraphicsPath CreateRoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            if (diameter > bounds.Width) diameter = bounds.Width;
            if (diameter > bounds.Height) diameter = bounds.Height;

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }

    public class RoundedPanel : Panel
    {
        private int _radius = 16;
        private Color _borderColor = Color.FromArgb(55, 65, 81);
        private int _borderSize = 1;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentColor = Parent != null ? Parent.BackColor : BackColor;
            e.Graphics.Clear(parentColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (_borderSize > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(_borderColor, _borderSize))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }
    }

    public class RoundedButton : Button
    {
        private int _radius = 10;
        private Color _hoverColor = Color.Empty;
        private Color _normalColor;
        private bool _isHovering = false;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            _normalColor = BackColor;
            if (_hoverColor == Color.Empty)
                _hoverColor = ControlPaint.Light(BackColor, 0.15f);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentColor = Parent != null ? Parent.BackColor : Color.Transparent;
            e.Graphics.Clear(parentColor);

            Color bgColor = _isHovering ? _hoverColor : _normalColor;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (SolidBrush brush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }
    }

    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 10;
        private Color _borderColor = Color.FromArgb(55, 65, 81);
        private Color _focusBorderColor = Color.FromArgb(34, 197, 94);
        private bool _isFocused = false;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }

        public Color FocusBorderColor
        {
            get { return _focusBorderColor; }
            set { _focusBorderColor = value; Invalidate(); }
        }

        public override string Text
        {
            get { return _textBox != null ? _textBox.Text : ""; }
            set { if (_textBox != null) _textBox.Text = value; }
        }

        public override Color ForeColor
        {
            get { return _textBox != null ? _textBox.ForeColor : base.ForeColor; }
            set
            {
                if (_textBox != null) _textBox.ForeColor = value;
                base.ForeColor = value;
            }
        }

        public HorizontalAlignment TextAlign
        {
            get { return _textBox != null ? _textBox.TextAlign : HorizontalAlignment.Left; }
            set { if (_textBox != null) _textBox.TextAlign = value; }
        }

        public new event EventHandler TextChanged;

        public RoundedTextBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);

            Height = 44;
            BackColor = Color.FromArgb(31, 41, 55);

            _textBox = new TextBox();
            _textBox.BorderStyle = BorderStyle.None;
            _textBox.BackColor = BackColor;
            _textBox.ForeColor = Color.White;
            _textBox.Font = new Font("Segoe UI", 11F);

            _textBox.Enter += (s, e) => { _isFocused = true; Invalidate(); };
            _textBox.Leave += (s, e) => { _isFocused = false; Invalidate(); };
            _textBox.TextChanged += (s, e) => { if (TextChanged != null) TextChanged(this, e); };

            Controls.Add(_textBox);
            UpdateTextBoxPosition();
        }

        private void UpdateTextBoxPosition()
        {
            int padding = 14;
            _textBox.Location = new Point(padding, (Height - _textBox.Height) / 2);
            _textBox.Width = Width - padding * 2;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTextBoxPosition();
            Invalidate();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (_textBox != null) _textBox.BackColor = BackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color parentColor = Parent != null ? Parent.BackColor : BackColor;
            e.Graphics.Clear(parentColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                Color borderColor = _isFocused ? _focusBorderColor : _borderColor;
                using (Pen pen = new Pen(borderColor, 2))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        public new void Focus()
        {
            if (_textBox != null) _textBox.Focus();
        }
    }
}
