using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    /// <summary>
    /// Helper para criar retângulos arredondados
    /// </summary>
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

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static void ApplyRoundedCorners(Control control, int radius)
        {
            control.Region = new Region(CreateRoundedRectangle(new Rectangle(0, 0, control.Width, control.Height), radius));
        }
    }

    /// <summary>
    /// Panel com bordas arredondadas
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _radius = 12;
        private Color _borderColor = Color.Transparent;
        private int _borderSize = 0;

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get => _borderSize;
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
            e.Graphics.Clear(Parent?.BackColor ?? BackColor);

            using (var path = RoundedHelper.CreateRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), _radius))
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (_borderSize > 0 && _borderColor != Color.Transparent)
                {
                    using (var pen = new Pen(_borderColor, _borderSize))
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

    /// <summary>
    /// Botão com bordas arredondadas e efeito hover
    /// </summary>
    public class RoundedButton : Button
    {
        private int _radius = 10;
        private Color _hoverColor = Color.Empty;
        private Color _normalColor;
        private bool _isHovering = false;

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
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
            e.Graphics.Clear(Parent?.BackColor ?? Color.Transparent);

            var bgColor = _isHovering ? _hoverColor : _normalColor;

            using (var path = RoundedHelper.CreateRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), _radius))
            {
                using (var brush = new SolidBrush(bgColor))
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

    /// <summary>
    /// TextBox com bordas arredondadas
    /// </summary>
    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 10;
        private Color _borderColor = Color.FromArgb(55, 65, 81);
        private Color _focusBorderColor = Color.FromArgb(99, 102, 241);
        private bool _isFocused = false;

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public Color FocusBorderColor
        {
            get => _focusBorderColor;
            set { _focusBorderColor = value; Invalidate(); }
        }

        public override string Text
        {
            get => _textBox.Text;
            set => _textBox.Text = value;
        }

        public override Color ForeColor
        {
            get => _textBox.ForeColor;
            set => _textBox.ForeColor = value;
        }

        public HorizontalAlignment TextAlign
        {
            get => _textBox.TextAlign;
            set => _textBox.TextAlign = value;
        }

        public new event EventHandler TextChanged
        {
            add => _textBox.TextChanged += value;
            remove => _textBox.TextChanged -= value;
        }

        public new event EventHandler Enter
        {
            add => _textBox.Enter += value;
            remove => _textBox.Enter -= value;
        }

        public new event EventHandler Leave
        {
            add => _textBox.Leave += value;
            remove => _textBox.Leave -= value;
        }

        public RoundedTextBox()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Color.FromArgb(31, 41, 55);
            Padding = new Padding(12, 0, 12, 0);
            Height = 40;

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(31, 41, 55),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                Dock = DockStyle.Fill
            };

            _textBox.Enter += (s, e) => { _isFocused = true; Invalidate(); };
            _textBox.Leave += (s, e) => { _isFocused = false; Invalidate(); };

            Controls.Add(_textBox);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent?.BackColor ?? BackColor);

            using (var path = RoundedHelper.CreateRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), _radius))
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (var pen = new Pen(_isFocused ? _focusBorderColor : _borderColor, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            _textBox.BackColor = BackColor;
            Invalidate();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (_textBox != null)
                _textBox.BackColor = BackColor;
        }

        public new void Focus()
        {
            _textBox.Focus();
        }
    }
}
