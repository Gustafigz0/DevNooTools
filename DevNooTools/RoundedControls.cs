using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    #region Theme Manager

    public static class ThemeManager
    {
        public static bool IsDarkTheme { get; set; } = true;

        public static event Action ThemeChanged;

        public static void ToggleTheme()
        {
            IsDarkTheme = !IsDarkTheme;
            ThemeChanged?.Invoke();
        }

        // Light Theme (GitHub Light)
        public static class Light
        {
            public static readonly Color BgPrimary = Color.FromArgb(255, 255, 255);
            public static readonly Color BgSecondary = Color.FromArgb(246, 248, 250);
            public static readonly Color BgCard = Color.FromArgb(255, 255, 255);
            public static readonly Color BgInput = Color.FromArgb(246, 248, 250);
            public static readonly Color BgHover = Color.FromArgb(234, 238, 242);

            public static readonly Color TextPrimary = Color.FromArgb(36, 41, 47);
            public static readonly Color TextSecondary = Color.FromArgb(87, 96, 106);
            public static readonly Color TextMuted = Color.FromArgb(140, 149, 159);

            public static readonly Color BorderDefault = Color.FromArgb(216, 222, 228);
        }

        // Dark Theme (GitHub Dark)
        public static class Dark
        {
            public static readonly Color BgPrimary = Color.FromArgb(13, 17, 23);
            public static readonly Color BgSecondary = Color.FromArgb(22, 27, 34);
            public static readonly Color BgCard = Color.FromArgb(22, 27, 34);
            public static readonly Color BgInput = Color.FromArgb(33, 38, 45);
            public static readonly Color BgHover = Color.FromArgb(48, 54, 61);

            public static readonly Color TextPrimary = Color.FromArgb(230, 237, 243);
            public static readonly Color TextSecondary = Color.FromArgb(139, 148, 158);
            public static readonly Color TextMuted = Color.FromArgb(110, 118, 129);

            public static readonly Color BorderDefault = Color.FromArgb(48, 54, 61);
        }

        // Accent colors
        public static readonly Color AccentBlue = Color.FromArgb(56, 139, 253);
        public static readonly Color AccentBlueDark = Color.FromArgb(31, 111, 235);
        public static readonly Color AccentGreen = Color.FromArgb(46, 160, 67);
        public static readonly Color AccentGreenDark = Color.FromArgb(35, 134, 54);
        public static readonly Color AccentOrange = Color.FromArgb(227, 98, 9);
        public static readonly Color AccentPurple = Color.FromArgb(130, 80, 223);
        public static readonly Color AccentRed = Color.FromArgb(218, 54, 51);
        public static readonly Color AccentRedDark = Color.FromArgb(191, 38, 35);

        // Current theme colors
        public static Color BgPrimary => IsDarkTheme ? Dark.BgPrimary : Light.BgPrimary;
        public static Color BgSecondary => IsDarkTheme ? Dark.BgSecondary : Light.BgSecondary;
        public static Color BgCard => IsDarkTheme ? Dark.BgCard : Light.BgCard;
        public static Color BgInput => IsDarkTheme ? Dark.BgInput : Light.BgInput;
        public static Color BgHover => IsDarkTheme ? Dark.BgHover : Light.BgHover;
        public static Color TextPrimary => IsDarkTheme ? Dark.TextPrimary : Light.TextPrimary;
        public static Color TextSecondary => IsDarkTheme ? Dark.TextSecondary : Light.TextSecondary;
        public static Color TextMuted => IsDarkTheme ? Dark.TextMuted : Light.TextMuted;
        public static Color BorderDefault => IsDarkTheme ? Dark.BorderDefault : Light.BorderDefault;
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
            return ThemeManager.BgPrimary;
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

        public static void DrawShadow(Graphics g, Rectangle rect, int radius, int shadowDepth, int alpha = 12)
        {
            for (int i = shadowDepth; i > 0; i--)
            {
                var shadowRect = new Rectangle(rect.X + i, rect.Y + i, rect.Width, rect.Height);
                using (var path = CreateRoundedRectangle(shadowRect, radius))
                using (var brush = new SolidBrush(Color.FromArgb(alpha, 0, 0, 0)))
                {
                    g.FillPath(brush, path);
                }
            }
        }
    }

    #endregion

    #region Toggle Switch (Animated)

    public class ToggleSwitch : Control
    {
        private bool _isOn = false;
        private Color _onColor = ThemeManager.AccentBlue;
        private Color _offColor = Color.FromArgb(110, 118, 129);
        private bool _isHovering = false;
        private float _animationProgress = 0f;
        private Timer _animationTimer;

        public bool IsOn
        {
            get => _isOn;
            set
            {
                if (_isOn != value)
                {
                    _isOn = value;
                    _animationProgress = value ? 1f : 0f;
                    Invalidate();
                    OnToggled?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public Color OnColor { get => _onColor; set { _onColor = value; Invalidate(); } }
        public Color OffColor { get => _offColor; set { _offColor = value; Invalidate(); } }

        public event EventHandler OnToggled;

        public ToggleSwitch()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(48, 26);
            Cursor = Cursors.Hand;

            _animationTimer = new Timer { Interval = 16 };
            _animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            float target = _isOn ? 1f : 0f;
            float diff = target - _animationProgress;

            if (Math.Abs(diff) < 0.05f)
            {
                _animationProgress = target;
                _animationTimer.Stop();
            }
            else
            {
                _animationProgress += diff * 0.3f;
            }
            Invalidate();
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _isOn = !_isOn;
            _animationTimer.Start();
            OnToggled?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var trackRect = new Rectangle(0, 0, Width - 1, Height - 1);
            
            Color trackColor = InterpolateColor(_offColor, _onColor, _animationProgress);
            if (_isHovering)
            {
                trackColor = RoundedHelper.LightenColor(trackColor, 0.15f);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(trackRect, Height / 2))
            using (var brush = new SolidBrush(trackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Thumb
            int thumbSize = Height - 6;
            int thumbX = (int)(3 + (Width - thumbSize - 6) * _animationProgress);
            var thumbRect = new Rectangle(thumbX, 3, thumbSize, thumbSize);

            // Thumb shadow
            var shadowRect = new Rectangle(thumbX + 1, 4, thumbSize, thumbSize);
            using (var shadowPath = RoundedHelper.CreateRoundedRectangle(shadowRect, thumbSize / 2))
            using (var shadowBrush = new SolidBrush(Color.FromArgb(40, 0, 0, 0)))
            {
                e.Graphics.FillPath(shadowBrush, shadowPath);
            }

            using (var thumbPath = RoundedHelper.CreateRoundedRectangle(thumbRect, thumbSize / 2))
            using (var thumbBrush = new SolidBrush(Color.White))
            {
                e.Graphics.FillPath(thumbBrush, thumbPath);
            }
        }

        private Color InterpolateColor(Color from, Color to, float progress)
        {
            int r = (int)(from.R + (to.R - from.R) * progress);
            int g = (int)(from.G + (to.G - from.G) * progress);
            int b = (int)(from.B + (to.B - from.B) * progress);
            return Color.FromArgb(r, g, b);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _animationTimer?.Dispose();
            base.Dispose(disposing);
        }
    }

    #endregion

    #region User Profile Panel

    public class UserProfilePanel : Panel
    {
        private int _radius = 12;
        private bool _isHovering = false;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }

        public UserProfilePanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
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

            Color bgColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(22, 27, 34) 
                : Color.FromArgb(246, 248, 250);
            
            if (_isHovering)
            {
                bgColor = ThemeManager.BgHover;
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (var brush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (var pen = new Pen(ThemeManager.BorderDefault, 1f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }

    #endregion

    #region Rounded Panel

    public class RoundedPanel : Panel
    {
        private int _radius = 12;
        private Color _borderColor = ThemeManager.BorderDefault;
        private int _borderSize = 1;
        private bool _showShadow = false;
        private int _shadowDepth = 4;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; Invalidate(); } }
        public bool ShowShadow { get => _showShadow; set { _showShadow = value; Invalidate(); } }
        public int ShadowDepth { get => _shadowDepth; set { _shadowDepth = value; Invalidate(); } }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = ThemeManager.BgCard;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            int padding = _showShadow ? _shadowDepth : 0;
            var rect = new Rectangle(padding, padding, Width - 1 - padding * 2, Height - 1 - padding * 2);

            if (_showShadow)
            {
                RoundedHelper.DrawShadow(e.Graphics, rect, _radius, _shadowDepth);
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

    #region Rounded Button

    public class RoundedButton : Button
    {
        private int _radius = 8;
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
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

            if (_isPressed) rect.Inflate(-1, -1);

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                Color startColor = BackColor;
                Color endColor = _gradientEndColor != Color.Empty ? _gradientEndColor : RoundedHelper.DarkenColor(BackColor, 0.15f);

                if (_isHovering)
                {
                    startColor = RoundedHelper.LightenColor(startColor, 0.12f);
                    endColor = RoundedHelper.LightenColor(endColor, 0.12f);
                }
                if (_isPressed)
                {
                    startColor = RoundedHelper.DarkenColor(BackColor, 0.1f);
                    endColor = RoundedHelper.DarkenColor(endColor, 0.1f);
                }

                if (_useGradient && rect.Height > 0 && rect.Width > 0)
                {
                    using (var brush = new LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
                else
                {
                    using (var brush = new SolidBrush(startColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, rect, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    #endregion

    #region Rounded TextBox

    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 8;
        private Color _borderColor = ThemeManager.BorderDefault;
        private Color _focusBorderColor = ThemeManager.AccentBlue;
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

        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; if (_textBox != null) _textBox.BackColor = value; Invalidate(); }
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

        public RoundedTextBox()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = ThemeManager.BgInput;

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = ThemeManager.BgInput,
                ForeColor = ThemeManager.TextPrimary,
                Font = new Font("Segoe UI", 10F)
            };

            _textBox.Enter += (s, e) => { _isFocused = true; Invalidate(); };
            _textBox.Leave += (s, e) => { _isFocused = false; Invalidate(); };

            Controls.Add(_textBox);
            Height = 36;
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

                Color borderColor = _isFocused ? _focusBorderColor : _borderColor;
                float borderWidth = _isFocused ? 2f : 1f;

                using (var pen = new Pen(borderColor, borderWidth))
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
            _textBox.ForeColor = ForeColor;
            int padding = 12;
            int textBoxHeight = _textBox.PreferredHeight;
            int y = (Height - textBoxHeight) / 2;
            _textBox.Location = new Point(padding, y);
            _textBox.Width = Width - (padding * 2);
        }

        public new void Focus() => _textBox?.Focus();
    }

    #endregion

    #region Gradient Card

    public class GradientCard : Panel
    {
        private int _radius = 12;
        private Color _gradientStartColor = ThemeManager.AccentBlue;
        private Color _gradientEndColor = ThemeManager.AccentBlueDark;
        private bool _showShadow = true;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color GradientStartColor { get => _gradientStartColor; set { _gradientStartColor = value; Invalidate(); } }
        public Color GradientEndColor { get => _gradientEndColor; set { _gradientEndColor = value; Invalidate(); } }
        public Color BorderColor { get; set; }
        public Color AccentColor { get; set; }
        public int AccentWidth { get; set; }
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

            if (_showShadow)
            {
                RoundedHelper.DrawShadow(e.Graphics, rect, _radius, 5, 18);
            }

            if (rect.Width > 0 && rect.Height > 0)
            {
                using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
                using (var brush = new LinearGradientBrush(rect, _gradientStartColor, _gradientEndColor,
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }

    #endregion

    #region Nav Panel

    public class NavPanel : Panel
    {
        private int _radius = 8;
        private bool _isHovering = false;
        private bool _isSelected = false;
        private Color _hoverColor = ThemeManager.BgHover;
        private Color _selectedColor = ThemeManager.AccentBlue;

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
                using (var brush = new SolidBrush(Color.FromArgb(35, _selectedColor)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                var accentRect = new Rectangle(0, 6, 3, Height - 12);
                using (var accentPath = RoundedHelper.CreateRoundedRectangle(accentRect, 2))
                using (var brush = new SolidBrush(_selectedColor))
                {
                    e.Graphics.FillPath(brush, accentPath);
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

    #region Glass Panel (Sidebar)

    public class GlassPanel : Panel
    {
        private int _radius = 0;
        private Color _borderColor = ThemeManager.BorderDefault;
        private int _borderSize = 1;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
        public int BorderSize { get => _borderSize; set { _borderSize = value; Invalidate(); } }
        public bool ShowGlow { get; set; }
        public Color GlowColor { get; set; }
        public int GlowSize { get; set; }

        public GlassPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = ThemeManager.BgPrimary;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            if (_borderSize > 0)
            {
                using (var pen = new Pen(_borderColor, _borderSize))
                {
                    e.Graphics.DrawLine(pen, Width - 1, 0, Width - 1, Height);
                }
            }
        }
    }

    #endregion
}
