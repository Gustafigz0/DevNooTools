using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    #region Modern Light Theme

    /// <summary>
    /// Modern Light Theme Colors - Clean White Design
    /// </summary>
    public static class LightTheme
    {
        // Base colors - Clean whites and grays
        public static readonly Color BgPrimary = Color.FromArgb(250, 251, 252);
        public static readonly Color BgSecondary = Color.FromArgb(255, 255, 255);
        public static readonly Color BgCard = Color.FromArgb(255, 255, 255);
        public static readonly Color BgSidebar = Color.FromArgb(248, 250, 252);
        public static readonly Color BgInput = Color.FromArgb(247, 248, 250);
        public static readonly Color BgHover = Color.FromArgb(243, 244, 246);

        // Accent colors - Vibrant gradients
        public static readonly Color AccentBlue = Color.FromArgb(59, 130, 246);
        public static readonly Color AccentIndigo = Color.FromArgb(99, 102, 241);
        public static readonly Color AccentPurple = Color.FromArgb(139, 92, 246);
        public static readonly Color AccentPink = Color.FromArgb(236, 72, 153);
        public static readonly Color AccentCyan = Color.FromArgb(6, 182, 212);
        public static readonly Color AccentTeal = Color.FromArgb(20, 184, 166);

        // Status colors
        public static readonly Color Success = Color.FromArgb(34, 197, 94);
        public static readonly Color Warning = Color.FromArgb(245, 158, 11);
        public static readonly Color Danger = Color.FromArgb(239, 68, 68);
        public static readonly Color Info = Color.FromArgb(59, 130, 246);

        // Text colors
        public static readonly Color TextPrimary = Color.FromArgb(17, 24, 39);
        public static readonly Color TextSecondary = Color.FromArgb(107, 114, 128);
        public static readonly Color TextMuted = Color.FromArgb(156, 163, 175);

        // Border colors
        public static readonly Color BorderDefault = Color.FromArgb(229, 231, 235);
        public static readonly Color BorderLight = Color.FromArgb(243, 244, 246);
        public static readonly Color BorderFocus = Color.FromArgb(59, 130, 246);

        // Shadow color
        public static readonly Color Shadow = Color.FromArgb(30, 0, 0, 0);
    }

    #endregion

    #region Helper Methods

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
            return LightTheme.BgPrimary;
        }

        public static Color LightenColor(Color color, float percent)
        {
            float r = color.R + (255 - color.R) * percent;
            float g = color.G + (255 - color.G) * percent;
            float b = color.B + (255 - color.B) * percent;
            return Color.FromArgb(color.A, (int)Math.Min(255, r), (int)Math.Min(255, g), (int)Math.Min(255, b));
        }

        public static Color DarkenColor(Color color, float percent)
        {
            float r = color.R * (1 - percent);
            float g = color.G * (1 - percent);
            float b = color.B * (1 - percent);
            return Color.FromArgb(color.A, (int)Math.Max(0, r), (int)Math.Max(0, g), (int)Math.Max(0, b));
        }

        public static Color BlendColors(Color color1, Color color2, float ratio)
        {
            int r = (int)(color1.R * (1 - ratio) + color2.R * ratio);
            int g = (int)(color1.G * (1 - ratio) + color2.G * ratio);
            int b = (int)(color1.B * (1 - ratio) + color2.B * ratio);
            return Color.FromArgb(Math.Min(255, r), Math.Min(255, g), Math.Min(255, b));
        }

        public static void DrawShadow(Graphics g, Rectangle rect, int radius, int shadowDepth)
        {
            for (int i = shadowDepth; i > 0; i--)
            {
                var shadowRect = new Rectangle(rect.X + i, rect.Y + i, rect.Width, rect.Height);
                using (var path = CreateRoundedRectangle(shadowRect, radius))
                using (var brush = new SolidBrush(Color.FromArgb(8, 0, 0, 0)))
                {
                    g.FillPath(brush, path);
                }
            }
        }
    }

    #endregion

    #region Rounded Panel

    public class RoundedPanel : Panel
    {
        private int _radius = 16;
        private Color _borderColor = LightTheme.BorderDefault;
        private int _borderSize = 0;
        private bool _showShadow = false;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; Invalidate(); } }
        public bool ShowShadow { get => _showShadow; set { _showShadow = value; Invalidate(); } }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = LightTheme.BgCard;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            int padding = _showShadow ? 4 : 0;
            var rect = new Rectangle(padding, padding, Width - 1 - padding * 2, Height - 1 - padding * 2);

            // Draw shadow
            if (_showShadow)
            {
                RoundedHelper.DrawShadow(e.Graphics, rect, _radius, 4);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                if (_borderSize > 0)
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

    #endregion

    #region Modern Button

    public class RoundedButton : Button
    {
        private int _radius = 10;
        private bool _isHovering = false;
        private bool _isPressed = false;
        private bool _useGradient = true;
        private Color _gradientEndColor = Color.Empty;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public bool UseGradient { get => _useGradient; set { _useGradient = value; Invalidate(); } }
        public Color GradientEndColor { get => _gradientEndColor; set { _gradientEndColor = value; Invalidate(); } }

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            ForeColor = Color.White;
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

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            if (_isPressed)
            {
                rect.Inflate(-1, -1);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                // Background
                Color bgColor = BackColor;
                if (_isHovering) bgColor = RoundedHelper.LightenColor(BackColor, 0.1f);
                if (_isPressed) bgColor = RoundedHelper.DarkenColor(BackColor, 0.1f);

                if (_useGradient && _gradientEndColor != Color.Empty)
                {
                    using (var brush = new LinearGradientBrush(rect, bgColor,
                        _isHovering ? RoundedHelper.LightenColor(_gradientEndColor, 0.1f) : _gradientEndColor,
                        LinearGradientMode.Horizontal))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
                else
                {
                    using (var brush = new SolidBrush(bgColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
            }

            // Text
            TextRenderer.DrawText(e.Graphics, Text, Font, rect, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    #endregion

    #region Modern TextBox

    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 10;
        private Color _borderColor = LightTheme.BorderDefault;
        private Color _focusBorderColor = LightTheme.AccentBlue;
        private bool _isFocused = false;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public Color FocusBorderColor { get => _focusBorderColor; set { _focusBorderColor = value; Invalidate(); } }

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
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = LightTheme.BgInput;

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = LightTheme.BgInput,
                ForeColor = LightTheme.TextPrimary,
                Font = new Font("Segoe UI", 10F)
            };

            _textBox.Enter += (s, e) => { _isFocused = true; Invalidate(); };
            _textBox.Leave += (s, e) => { _isFocused = false; Invalidate(); };

            Controls.Add(_textBox);
            Height = 42;
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

                using (var pen = new Pen(_isFocused ? _focusBorderColor : _borderColor, _isFocused ? 2f : 1f))
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
            int padding = 14;
            int textBoxHeight = _textBox.PreferredHeight;
            int y = (Height - textBoxHeight) / 2;
            _textBox.Location = new Point(padding, y);
            _textBox.Width = Width - (padding * 2);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            if (_textBox != null) _textBox.BackColor = BackColor;
        }

        public new void Focus() => _textBox?.Focus();
    }

    #endregion

    #region Gradient Card

    public class GradientCard : Panel
    {
        private int _radius = 14;
        private Color _gradientStartColor = LightTheme.AccentBlue;
        private Color _gradientEndColor = LightTheme.AccentIndigo;
        private Color _borderColor = Color.Transparent;
        private Color _accentColor = Color.Transparent;
        private int _accentWidth = 0;
        private bool _showShadow = true;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color GradientStartColor { get => _gradientStartColor; set { _gradientStartColor = value; Invalidate(); } }
        public Color GradientEndColor { get => _gradientEndColor; set { _gradientEndColor = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public Color AccentColor { get => _accentColor; set { _accentColor = value; Invalidate(); } }
        public int AccentWidth { get => _accentWidth; set { _accentWidth = value; Invalidate(); } }
        public bool ShowShadow { get => _showShadow; set { _showShadow = value; Invalidate(); } }

        public GradientCard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            int padding = _showShadow ? 4 : 0;
            var rect = new Rectangle(padding, padding, Width - 1 - padding * 2, Height - 1 - padding * 2);

            // Shadow
            if (_showShadow)
            {
                RoundedHelper.DrawShadow(e.Graphics, rect, _radius, 4);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                // Gradient background
                using (var brush = new LinearGradientBrush(rect, _gradientStartColor, _gradientEndColor,
                    LinearGradientMode.ForwardDiagonal))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Border
                if (_borderColor != Color.Transparent)
                {
                    using (var pen = new Pen(_borderColor, 1f))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }
    }

    #endregion

    #region Nav Panel

    public class NavPanel : Panel
    {
        private int _radius = 10;
        private bool _isHovering = false;
        private bool _isSelected = false;
        private Color _hoverColor = LightTheme.BgHover;
        private Color _selectedColor = LightTheme.AccentBlue;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public bool IsSelected { get => _isSelected; set { _isSelected = value; Invalidate(); } }
        public Color HoverColor { get => _hoverColor; set { _hoverColor = value; Invalidate(); } }
        public Color SelectedColor { get => _selectedColor; set { _selectedColor = value; Invalidate(); } }

        public NavPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
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

            if (_isSelected)
            {
                using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
                using (var brush = new SolidBrush(Color.FromArgb(30, _selectedColor)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Left accent bar
                var accentRect = new Rectangle(0, 4, 4, Height - 8);
                using (var brush = new SolidBrush(_selectedColor))
                {
                    e.Graphics.FillRectangle(brush, accentRect);
                }
            }
            else if (_isHovering)
            {
                using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
                using (var brush = new SolidBrush(_hoverColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }

    #endregion

    #region Glass Panel (simplified for light theme)

    public class GlassPanel : Panel
    {
        private int _radius = 0;
        private Color _borderColor = LightTheme.BorderDefault;
        private int _borderSize = 0;
        private bool _showShadow = false;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; Invalidate(); } }
        public bool ShowGlow { get => _showShadow; set { _showShadow = value; Invalidate(); } }
        public Color GlowColor { get; set; } = Color.Transparent;
        public int GlowSize { get; set; } = 0;

        public GlassPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = LightTheme.BgSidebar;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (_radius > 0)
            {
                Color clearColor = RoundedHelper.GetActualParentBackColor(this);
                using (var clearBrush = new SolidBrush(clearColor))
                {
                    e.Graphics.FillRectangle(clearBrush, ClientRectangle);
                }

                int padding = _showShadow ? 4 : 0;
                var rect = new Rectangle(padding, padding, Width - 1 - padding * 2, Height - 1 - padding * 2);

                if (_showShadow)
                {
                    RoundedHelper.DrawShadow(e.Graphics, rect, _radius, 4);
                }

                using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
                {
                    using (var brush = new SolidBrush(BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    if (_borderSize > 0)
                    {
                        using (var pen = new Pen(_borderColor, _borderSize))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                }
            }
            else
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                }

                // Right border line for sidebar
                if (_borderSize > 0)
                {
                    using (var pen = new Pen(_borderColor, _borderSize))
                    {
                        e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, Height);
                    }
                }
            }
        }
    }

    #endregion
}
