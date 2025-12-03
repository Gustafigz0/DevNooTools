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

        /// <summary>
        /// Gets the actual background color by walking up the parent hierarchy
        /// </summary>
        public static Color GetActualParentBackColor(Control control)
        {
            Control parent = control.Parent;
            while (parent != null)
            {
                if (parent.BackColor != Color.Transparent && parent.BackColor.A == 255)
                {
                    return parent.BackColor;
                }
                parent = parent.Parent;
            }
            return SystemColors.Control;
        }

        /// <summary>
        /// Lightens a color by a percentage
        /// </summary>
        public static Color LightenColor(Color color, float percent)
        {
            float r = color.R + (255 - color.R) * percent;
            float g = color.G + (255 - color.G) * percent;
            float b = color.B + (255 - color.B) * percent;
            return Color.FromArgb(color.A, (int)Math.Min(255, r), (int)Math.Min(255, g), (int)Math.Min(255, b));
        }

        /// <summary>
        /// Darkens a color by a percentage
        /// </summary>
        public static Color DarkenColor(Color color, float percent)
        {
            float r = color.R * (1 - percent);
            float g = color.G * (1 - percent);
            float b = color.B * (1 - percent);
            return Color.FromArgb(color.A, (int)Math.Max(0, r), (int)Math.Max(0, g), (int)Math.Max(0, b));
        }
    }

    /// <summary>
    /// Panel com bordas arredondadas
    /// </summary>
    public class RoundedPanel : Panel
    {
        private int _radius = 16;
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
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
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

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }

    /// <summary>
    /// Botão com bordas arredondadas e efeito hover suave
    /// </summary>
    public class RoundedButton : Button
    {
        private int _radius = 12;
        private Color _hoverColor = Color.Empty;
        private Color _normalColor;
        private Color _pressedColor = Color.Empty;
        private bool _isHovering = false;
        private bool _isPressed = false;

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

        public Color PressedColor
        {
            get => _pressedColor;
            set { _pressedColor = value; }
        }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            UpdateColors();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            UpdateColors();
        }

        private void UpdateColors()
        {
            _normalColor = BackColor;
            // Hover mais suave - apenas 8% mais claro
            _hoverColor = RoundedHelper.LightenColor(BackColor, 0.08f);
            // Pressed mais escuro - 10% mais escuro
            _pressedColor = RoundedHelper.DarkenColor(BackColor, 0.10f);
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
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var bgColor = _isPressed ? _pressedColor : (_isHovering ? _hoverColor : _normalColor);

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

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }

    /// <summary>
    /// TextBox com bordas arredondadas
    /// </summary>
    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 12;
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
            get => _textBox?.Text ?? string.Empty;
            set { if (_textBox != null) _textBox.Text = value; }
        }

        public override Color ForeColor
        {
            get => _textBox?.ForeColor ?? base.ForeColor;
            set { if (_textBox != null) _textBox.ForeColor = value; base.ForeColor = value; }
        }

        public HorizontalAlignment TextAlign
        {
            get => _textBox?.TextAlign ?? HorizontalAlignment.Left;
            set { if (_textBox != null) _textBox.TextAlign = value; }
        }

        public new event EventHandler TextChanged
        {
            add { if (_textBox != null) _textBox.TextChanged += value; }
            remove { if (_textBox != null) _textBox.TextChanged -= value; }
        }

        public new event EventHandler Enter
        {
            add { if (_textBox != null) _textBox.Enter += value; }
            remove { if (_textBox != null) _textBox.Enter -= value; }
        }

        public new event EventHandler Leave
        {
            add { if (_textBox != null) _textBox.Leave += value; }
            remove { if (_textBox != null) _textBox.Leave -= value; }
        }

        public RoundedTextBox()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.FromArgb(31, 41, 55);

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(31, 41, 55),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F)
            };

            _textBox.Enter += (s, e) => { _isFocused = true; Invalidate(); };
            _textBox.Leave += (s, e) => { _isFocused = false; Invalidate(); };

            Controls.Add(_textBox);
            Height = 40;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(new Rectangle(0, 0, Width - 1, Height - 1), _radius))
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (var pen = new Pen(_isFocused ? _focusBorderColor : _borderColor, _isFocused ? 2f : 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            PositionTextBox();
            Invalidate();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            PositionTextBox();
        }

        private void PositionTextBox()
        {
            if (_textBox == null) return;

            _textBox.BackColor = BackColor;

            int padding = 12;
            int textBoxHeight = _textBox.PreferredHeight;
            int y = (Height - textBoxHeight) / 2;

            _textBox.Location = new Point(padding, y);
            _textBox.Width = Width - (padding * 2);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (_textBox != null)
                _textBox.BackColor = BackColor;
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        public new void Focus()
        {
            _textBox?.Focus();
        }
    }

    /// <summary>
    /// Card com gradiente e bordas arredondadas - Design melhorado
    /// </summary>
    public class GradientCard : Panel
    {
        private int _radius = 16;
        private Color _gradientStartColor = Color.FromArgb(30, 41, 59);
        private Color _gradientEndColor = Color.FromArgb(24, 33, 52);
        private Color _borderColor = Color.FromArgb(55, 65, 81);
        private Color _accentColor = Color.FromArgb(99, 102, 241);
        private int _accentWidth = 3;

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public Color GradientStartColor
        {
            get => _gradientStartColor;
            set { _gradientStartColor = value; Invalidate(); }
        }

        public Color GradientEndColor
        {
            get => _gradientEndColor;
            set { _gradientEndColor = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        public Color AccentColor
        {
            get => _accentColor;
            set { _accentColor = value; Invalidate(); }
        }

        public int AccentWidth
        {
            get => _accentWidth;
            set { _accentWidth = value; Invalidate(); }
        }

        public GradientCard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                // Gradient fill
                using (var brush = new LinearGradientBrush(rect, _gradientStartColor, _gradientEndColor, LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Border
                using (var pen = new Pen(_borderColor, 1f))
                {
                    e.Graphics.DrawPath(pen, path);
                }

                // Clip to rounded rectangle for accent
                e.Graphics.SetClip(path);

                // Accent bar on left with gradient
                if (_accentWidth > 0)
                {
                    var accentRect = new Rectangle(0, 0, _accentWidth + 2, Height);
                    using (var accentBrush = new LinearGradientBrush(
                        new Rectangle(0, 0, _accentWidth + 2, Height),
                        _accentColor,
                        RoundedHelper.DarkenColor(_accentColor, 0.3f),
                        LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(accentBrush, accentRect);
                    }
                }

                e.Graphics.ResetClip();
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }

    /// <summary>
    /// Panel de navegação com hover effect
    /// </summary>
    public class NavPanel : Panel
    {
        private int _radius = 10;
        private bool _isHovering = false;
        private bool _isSelected = false;
        private Color _hoverColor = Color.FromArgb(40, 255, 255, 255);
        private Color _selectedColor = Color.FromArgb(99, 102, 241);

        public int Radius
        {
            get => _radius;
            set { _radius = value; Invalidate(); }
        }

        public bool IsSelected
        {
            get => _isSelected;
            set { _isSelected = value; Invalidate(); }
        }

        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        public Color SelectedColor
        {
            get => _selectedColor;
            set { _selectedColor = value; Invalidate(); }
        }

        public NavPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
            Cursor = Cursors.Hand;
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

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            Color bgColor;
            if (_isSelected)
                bgColor = _selectedColor;
            else if (_isHovering)
                bgColor = _hoverColor;
            else
                return;

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            using (var brush = new SolidBrush(bgColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }
    }
}
