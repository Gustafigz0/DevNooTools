using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

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

        public static void DrawGlow(Graphics g, Rectangle rect, int radius, Color glowColor, int glowSize)
        {
            for (int i = glowSize; i > 0; i--)
            {
                var glowRect = new Rectangle(rect.X - i, rect.Y - i, rect.Width + i * 2, rect.Height + i * 2);
                int alpha = (int)(30 * ((float)i / glowSize));
                using (var path = CreateRoundedRectangle(glowRect, radius + i))
                using (var pen = new Pen(Color.FromArgb(alpha, glowColor), 2))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }

    #endregion

    #region Hover Fader

    public static class HoverFader
    {
        private class State
        {
            public Timer Timer;
            public Color Original;
            public Color Target;
            public float Progress; // 0..1
            public bool Hovering;
            public float Intensity;
        }

        private static readonly Dictionary<Control, State> _states = new Dictionary<Control, State>();

        public static void Attach(Control ctrl, float intensity = 0.08f, Color? hoverColor = null)
        {
            if (ctrl == null) return;
            if (_states.ContainsKey(ctrl)) return;

            var state = new State
            {
                Original = ctrl.BackColor,
                Intensity = Math.Max(0f, Math.Min(0.6f, intensity)),
                Progress = 0f,
                Hovering = false
            };
            state.Target = hoverColor ?? RoundedHelper.LightenColor(state.Original, state.Intensity);

            state.Timer = new Timer { Interval = 16 };
            state.Timer.Tick += (s, e) =>
            {
                float speed = 0.18f;
                if (state.Hovering)
                {
                    state.Progress += speed;
                    if (state.Progress > 1f) state.Progress = 1f;
                }
                else
                {
                    state.Progress -= speed;
                    if (state.Progress < 0f) state.Progress = 0f;
                }

                ctrl.BackColor = InterpolateColor(state.Original, state.Target, state.Progress);

                if (!state.Hovering && state.Progress <= 0f)
                {
                    state.Timer.Stop();
                    // restore exact original to avoid drift
                    ctrl.BackColor = state.Original;
                }
            };

            ctrl.MouseEnter += (s, e) =>
            {
                state.Hovering = true;
                // recompute original/target in case theme changed
                state.Original = ctrl.BackColor;
                state.Target = hoverColor ?? RoundedHelper.LightenColor(state.Original, state.Intensity);
                state.Timer.Start();
            };

            ctrl.MouseLeave += (s, e) =>
            {
                state.Hovering = false;
                state.Timer.Start();
            };

            // If the control contains children that capture mouse, also attach to them so hover persists when over them
            ctrl.ControlAdded += (s, e) => AttachRecursive(e.Control, intensity, hoverColor);

            _states[ctrl] = state;
        }

        private static void AttachRecursive(Control ctrl, float intensity, Color? hoverColor)
        {
            Attach(ctrl, intensity, hoverColor);
            foreach (Control c in ctrl.Controls)
                AttachRecursive(c, intensity, hoverColor);
        }

        public static void AttachToAll(Control root, float intensity = 0.08f)
        {
            if (root == null) return;
            foreach (Control c in GetAllControls(root))
            {
                // attach to buttons and custom interactive controls
                if (c is Button || c is RoundedButton || c is NavPanel || c is GradientCard || c is RoundedPanel || c is RoundedTextBox || c is ToggleSwitch)
                {
                    Attach(c, intensity);
                }
            }
        }

        private static IEnumerable<Control> GetAllControls(Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var cur = stack.Pop();
                yield return cur;
                foreach (Control c in cur.Controls)
                    stack.Push(c);
            }
        }

        private static Color InterpolateColor(Color a, Color b, float t)
        {
            int r = (int)(a.R + (b.R - a.R) * t);
            int g = (int)(a.G + (b.G - a.G) * t);
            int bl = (int)(a.B + (b.B - a.B) * t);
            int alpha = (int)(a.A + (b.A - a.A) * t);
            return Color.FromArgb(alpha, r, g, bl);
        }
    }

    #endregion

    #region Toast Notification

    public class ToastForm : Form
    {
        private Label _lblTitle;
        private Label _lblMessage;
        private Timer _closeTimer;
        private float _progress = 0f;

        private ToastForm(string title, string message)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            ShowInTaskbar = false;
            TopMost = true;
            BackColor = ThemeManager.BgPrimary;
            Opacity = 0.0;
            Width = 320;
            Height = 88;

            _lblTitle = new Label
            {
                Text = title,
                AutoSize = false,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = ThemeManager.TextPrimary,
                Dock = DockStyle.Top,
                Height = 22,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 12, 0)
            };

            _lblMessage = new Label
            {
                Text = message,
                AutoSize = false,
                Font = new Font("Segoe UI", 9F),
                ForeColor = ThemeManager.TextSecondary,
                Dock = DockStyle.Fill,
                Padding = new Padding(12, 0, 12, 8)
            };

            Controls.Add(_lblMessage);
            Controls.Add(_lblTitle);

            _closeTimer = new Timer { Interval = 16 };
            _closeTimer.Tick += CloseTimer_Tick;
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            _progress += 0.04f;
            if (_progress < 0.25f)
            {
                Opacity = _progress * 4.0; // fade in
            }
            else if (_progress >= 0.25f && _progress < 0.75f)
            {
                Opacity = 1.0;
            }
            else
            {
                Opacity = Math.Max(0.0f, (float)(1.0 - (_progress - 0.75f) * 4.0));
            }

            if (_progress >= 1.0f)
            {
                _closeTimer.Stop();
                Close();
                Dispose();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Position at bottom-right of owner or screen
            var owner = this.Owner ?? Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.Visible);
            Rectangle bounds = owner != null ? owner.Bounds : Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(bounds.Right - this.Width - 16, bounds.Bottom - this.Height - 16);
            _progress = 0f;
            _closeTimer.Interval = 16;
            _closeTimer.Start();
        }

        public static void Show(Form owner, string title, string message, int durationMs = 3000)
        {
            try
            {
                var toast = new ToastForm(title, message);
                toast.Show(owner);
                // keep visible for durationMs before starting fade out
                var delay = new Timer { Interval = Math.Max(500, durationMs) }; // minimum to allow fade in
                delay.Tick += (s, e) => { delay.Stop(); delay.Dispose(); toast._progress = 0.75f; /* start fade out soon */ };
                delay.Start();
            }
            catch { /* swallow */ }
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

    #region Animated Pulse Button

    public class RoundedButton : Button
    {
        private int _radius = 8;
        private bool _isHovering = false;
        private bool _isPressed = false;
        private bool _useGradient = true;
        private Color _gradientEndColor = Color.Empty;
        private float _pulseProgress = 0f;
        private float _scaleProgress = 1f;
        private float _glowIntensity = 0f;
        private Timer _pulseTimer;
        private Timer _scaleTimer;

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

            _pulseTimer = new Timer { Interval = 25 };
            _pulseTimer.Tick += PulseTimer_Tick;

            _scaleTimer = new Timer { Interval = 16 };
            _scaleTimer.Tick += ScaleTimer_Tick;
        }

        private void PulseTimer_Tick(object sender, EventArgs e)
        {
            _pulseProgress += 0.05f;
            if (_pulseProgress >= 1f)
            {
                _pulseProgress = 0f;
            }
            
            // Smooth glow intensity
            float targetGlow = _isHovering ? 1f : 0f;
            _glowIntensity += (targetGlow - _glowIntensity) * 0.15f;
            
            Invalidate();
        }

        private void ScaleTimer_Tick(object sender, EventArgs e)
        {
            float target = _isHovering ? 1.03f : 1f;
            float diff = target - _scaleProgress;
            
            if (Math.Abs(diff) < 0.003f)
            {
                _scaleProgress = target;
                if (!_isHovering) _scaleTimer.Stop();
            }
            else
            {
                _scaleProgress += diff * 0.18f;
            }
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            _pulseTimer.Start();
            _scaleTimer.Start();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            _scaleTimer.Start();
            // Keep pulse timer running to animate glow fade out
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            _scaleProgress = 0.95f;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            _scaleProgress = 1.03f;
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

            // Calculate scaled rect
            int scaleOffset = (int)((1f - _scaleProgress) * 4);
            var rect = new Rectangle(scaleOffset + 2, scaleOffset + 2, Width - 5 - scaleOffset * 2, Height - 5 - scaleOffset * 2);

            // Draw outer pulse glow when hovering (expanding ring effect)
            if (_glowIntensity > 0.01f && !_isPressed)
            {
                // Outer expanding pulse
                int outerGlowAlpha = (int)(60 * (1f - _pulseProgress) * _glowIntensity);
                int outerGlowSize = (int)(15 * _pulseProgress * _glowIntensity);
                var outerGlowRect = new Rectangle(rect.X - outerGlowSize, rect.Y - outerGlowSize, 
                    rect.Width + outerGlowSize * 2, rect.Height + outerGlowSize * 2);
                
                using (var glowPath = RoundedHelper.CreateRoundedRectangle(outerGlowRect, _radius + outerGlowSize))
                using (var glowBrush = new SolidBrush(Color.FromArgb(outerGlowAlpha, BackColor)))
                {
                    e.Graphics.FillPath(glowBrush, glowPath);
                }

                // Static inner glow (always visible when hovering)
                int innerGlowAlpha = (int)(40 * _glowIntensity);
                var innerGlowRect = new Rectangle(rect.X - 4, rect.Y - 4, rect.Width + 8, rect.Height + 8);
                
                using (var glowPath = RoundedHelper.CreateRoundedRectangle(innerGlowRect, _radius + 4))
                using (var glowBrush = new SolidBrush(Color.FromArgb(innerGlowAlpha, BackColor)))
                {
                    e.Graphics.FillPath(glowBrush, glowPath);
                }
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                Color startColor = BackColor;
                Color endColor = _gradientEndColor != Color.Empty ? _gradientEndColor : RoundedHelper.DarkenColor(BackColor, 0.15f);

                if (_isHovering)
                {
                    startColor = RoundedHelper.LightenColor(startColor, 0.2f);
                    endColor = RoundedHelper.LightenColor(endColor, 0.2f);
                }
                if (_isPressed)
                {
                    startColor = RoundedHelper.DarkenColor(BackColor, 0.15f);
                    endColor = RoundedHelper.DarkenColor(endColor, 0.15f);
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

                // Draw subtle border when hovering
                if (_glowIntensity > 0.1f)
                {
                    int borderAlpha = (int)(100 * _glowIntensity);
                    using (var pen = new Pen(Color.FromArgb(borderAlpha, RoundedHelper.LightenColor(BackColor, 0.4f)), 1f))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            TextRenderer.DrawText(e.Graphics, Text, Font, rect, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _pulseTimer?.Dispose();
                _scaleTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    #endregion

    #region Rounded TextBox with Hover Pulse Effect

    public class RoundedTextBox : UserControl
    {
        private TextBox _textBox;
        private int _radius = 8;
        private Color _borderColor = ThemeManager.BorderDefault;
        private Color _focusBorderColor = ThemeManager.AccentBlue;
        private bool _isFocused = false;
        private bool _isHovering = false;
        private float _pulseProgress = 0f;
        private float _glowIntensity = 0f;
        private Timer _pulseTimer;

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
            _textBox.MouseEnter += (s, e) => { SetHovering(true); };
            _textBox.MouseLeave += (s, e) => { CheckMouseLeave(); };

            _pulseTimer = new Timer { Interval = 25 };
            _pulseTimer.Tick += PulseTimer_Tick;

            Controls.Add(_textBox);
            Height = 36;
        }

        private void SetHovering(bool hovering)
        {
            if (_isHovering != hovering)
            {
                _isHovering = hovering;
                if (hovering)
                {
                    _pulseTimer.Start();
                }
                Invalidate();
            }
        }

        private void CheckMouseLeave()
        {
            Point mousePos = PointToClient(MousePosition);
            if (!ClientRectangle.Contains(mousePos))
            {
                _isHovering = false;
                Invalidate();
            }
        }

        private void PulseTimer_Tick(object sender, EventArgs e)
        {
            _pulseProgress += 0.04f;
            if (_pulseProgress >= 1f)
            {
                _pulseProgress = 0f;
            }
            
            // Smooth glow intensity
            float targetGlow = (_isHovering || _isFocused) ? 1f : 0f;
            _glowIntensity += (targetGlow - _glowIntensity) * 0.12f;
            
            // Stop timer when glow faded out
            if (!_isHovering && !_isFocused && _glowIntensity < 0.01f)
            {
                _pulseTimer.Stop();
                _glowIntensity = 0f;
            }
            
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            SetHovering(true);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CheckMouseLeave();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            var rect = new Rectangle(2, 2, Width - 5, Height - 5);

            // Draw pulse glow when hovering (not focused)
            if (_glowIntensity > 0.01f && !_isFocused)
            {
                // Outer expanding pulse
                int outerGlowAlpha = (int)(35 * (1f - _pulseProgress) * _glowIntensity);
                int outerGlowSize = (int)(12 * _pulseProgress * _glowIntensity);
                var outerGlowRect = new Rectangle(rect.X - outerGlowSize, rect.Y - outerGlowSize, 
                    rect.Width + outerGlowSize * 2, rect.Height + outerGlowSize * 2);
                
                using (var glowPath = RoundedHelper.CreateRoundedRectangle(outerGlowRect, _radius + outerGlowSize))
                using (var glowBrush = new SolidBrush(Color.FromArgb(outerGlowAlpha, _focusBorderColor)))
                {
                    e.Graphics.FillPath(glowBrush, glowPath);
                }

                // Static inner glow
                int innerGlowAlpha = (int)(25 * _glowIntensity);
                var innerGlowRect = new Rectangle(rect.X - 3, rect.Y - 3, rect.Width + 6, rect.Height + 6);
                
                using (var glowPath = RoundedHelper.CreateRoundedRectangle(innerGlowRect, _radius + 3))
                using (var glowBrush = new SolidBrush(Color.FromArgb(innerGlowAlpha, _focusBorderColor)))
                {
                    e.Graphics.FillPath(glowBrush, glowPath);
                }
            }

            // Draw static glow when focused
            if (_isFocused)
            {
                RoundedHelper.DrawGlow(e.Graphics, rect, _radius, _focusBorderColor, 5);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                // Lighten background on hover
                Color bgColor = BackColor;
                if (_isHovering && !_isFocused)
                {
                    bgColor = RoundedHelper.LightenColor(BackColor, 0.05f);
                }
                
                using (var brush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                Color borderColor = _isFocused ? _focusBorderColor : (_isHovering ? _focusBorderColor : _borderColor);
                float borderWidth = _isFocused ? 2f : (_isHovering ? 1.5f : 1f);

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

        protected override void Dispose(bool disposing)
        {
            if (disposing) _pulseTimer?.Dispose();
            base.Dispose(disposing);
        }
    }

    #endregion

    #region Stat Card with Full Area Hover Pulse Effect

    public class GradientCard : Panel
    {
        private int _radius = 12;
        private Color _gradientStartColor = ThemeManager.AccentBlue;
        private Color _gradientEndColor = ThemeManager.AccentBlueDark;
        private bool _showShadow = true;
        private bool _isHovering = false;
        private float _pulseProgress = 0f;
        private float _scaleProgress = 1f;
        private Timer _pulseTimer;
        private Timer _scaleTimer;
        private int _accentWidth = 4;

        public int Radius { get => _radius; set { _radius = value; Invalidate(); } }
        public Color GradientStartColor { get => _gradientStartColor; set { _gradientStartColor = value; Invalidate(); } }
        public Color GradientEndColor { get => _gradientEndColor; set { _gradientEndColor = value; Invalidate(); } }
        public Color BorderColor { get; set; }
        public Color AccentColor { get => _gradientStartColor; set { _gradientStartColor = value; Invalidate(); } }
        public int AccentWidth { get => _accentWidth; set { _accentWidth = value; Invalidate(); } }
        public bool ShowShadow { get => _showShadow; set { _showShadow = value; Invalidate(); } }

        public GradientCard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Cursor = Cursors.Default;

            _pulseTimer = new Timer { Interval = 30 };
            _pulseTimer.Tick += PulseTimer_Tick;

            _scaleTimer = new Timer { Interval = 16 };
            _scaleTimer.Tick += ScaleTimer_Tick;

            // Hook child controls for mouse events
            ControlAdded += GradientCard_ControlAdded;
        }

        private void GradientCard_ControlAdded(object sender, ControlEventArgs e)
        {
            // Subscribe to mouse events of child controls
            e.Control.MouseEnter += ChildControl_MouseEnter;
            e.Control.MouseLeave += ChildControl_MouseLeave;
        }

        private void ChildControl_MouseEnter(object sender, EventArgs e)
        {
            if (!_isHovering)
            {
                _isHovering = true;
                _pulseTimer.Start();
                _scaleTimer.Start();
                Invalidate();
            }
        }

        private void ChildControl_MouseLeave(object sender, EventArgs e)
        {
            // Check if mouse is still within the card bounds
            Point mousePos = PointToClient(MousePosition);
            if (!ClientRectangle.Contains(mousePos))
            {
                _isHovering = false;
                _pulseTimer.Stop();
                _pulseProgress = 0f;
                _scaleTimer.Start();
                Invalidate();
            }
        }

        private void PulseTimer_Tick(object sender, EventArgs e)
        {
            _pulseProgress += 0.04f;
            if (_pulseProgress >= 1f)
            {
                _pulseProgress = 0f;
            }
            Invalidate();
        }

        private void ScaleTimer_Tick(object sender, EventArgs e)
        {
            float target = _isHovering ? 1.015f : 1f;
            float diff = target - _scaleProgress;
            
            if (Math.Abs(diff) < 0.002f)
            {
                _scaleProgress = target;
                if (!_isHovering) _scaleTimer.Stop();
            }
            else
            {
                _scaleProgress += diff * 0.12f;
            }
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!_isHovering)
            {
                _isHovering = true;
                _pulseTimer.Start();
                _scaleTimer.Start();
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            // Check if mouse is still within the card bounds (might be over a child control)
            Point mousePos = PointToClient(MousePosition);
            if (!ClientRectangle.Contains(mousePos))
            {
                _isHovering = false;
                _pulseTimer.Stop();
                _pulseProgress = 0f;
                _scaleTimer.Start();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color clearColor = RoundedHelper.GetActualParentBackColor(this);
            using (var clearBrush = new SolidBrush(clearColor))
            {
                e.Graphics.FillRectangle(clearBrush, ClientRectangle);
            }

            int padding = _showShadow ? 6 : 2;
            
            // Calculate scaled rect
            int scaleOffset = (int)((1f - _scaleProgress) * 2);
            var rect = new Rectangle(padding + scaleOffset, padding + scaleOffset, 
                Width - 1 - (padding + scaleOffset) * 2, Height - 1 - (padding + scaleOffset) * 2);

            // Draw pulsing glow when hovering
            if (_isHovering)
            {
                int glowAlpha = (int)(45 * (1f - _pulseProgress));
                int glowSize = (int)(18 * _pulseProgress);
                var glowRect = new Rectangle(rect.X - glowSize, rect.Y - glowSize, 
                    rect.Width + glowSize * 2, rect.Height + glowSize * 2);
                
                using (var glowPath = RoundedHelper.CreateRoundedRectangle(glowRect, _radius + glowSize))
                using (var glowBrush = new SolidBrush(Color.FromArgb(glowAlpha, _gradientStartColor)))
                {
                    e.Graphics.FillPath(glowBrush, glowPath);
                }
            }

            // Draw shadow when not hovering
            if (_showShadow && !_isHovering)
            {
                RoundedHelper.DrawShadow(e.Graphics, rect, _radius, 4, 15);
            }

            // Draw card background (dark)
            Color bgColor = ThemeManager.IsDarkTheme 
                ? Color.FromArgb(22, 27, 34) 
                : Color.FromArgb(255, 255, 255);
            
            if (_isHovering)
            {
                bgColor = ThemeManager.IsDarkTheme 
                    ? Color.FromArgb(30, 35, 44) 
                    : Color.FromArgb(250, 250, 255);
            }

            using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
            {
                using (var brush = new SolidBrush(bgColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Draw border - changes color on hover
                Color borderCol = _isHovering ? _gradientStartColor : ThemeManager.BorderDefault;
                float borderWidth = _isHovering ? 2f : 1f;
                using (var pen = new Pen(borderCol, borderWidth))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }

            // Draw left accent bar with gradient
            if (rect.Height > 24)
            {
                var accentRect = new Rectangle(rect.X, rect.Y + 12, _accentWidth, rect.Height - 24);
                if (accentRect.Height > 0 && accentRect.Width > 0)
                {
                    using (var accentPath = RoundedHelper.CreateRoundedRectangle(accentRect, 2))
                    using (var brush = new LinearGradientBrush(accentRect, _gradientStartColor, _gradientEndColor, LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillPath(brush, accentPath);
                    }
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _pulseTimer?.Dispose();
                _scaleTimer?.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    #endregion

    #region Nav Panel with Hover Effect

    public class NavPanel : Panel
    {
        private int _radius = 8;
        private bool _isHovering = false;
        private bool _isSelected = false;
        private Color _hoverColor = ThemeManager.BgHover;
        private Color _selectedColor = ThemeManager.AccentBlue;
        private float _hoverProgress = 0f;
        private Timer _hoverTimer;

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

            _hoverTimer = new Timer { Interval = 16 };
            _hoverTimer.Tick += HoverTimer_Tick;

            // Hook child controls for mouse events
            ControlAdded += NavPanel_ControlAdded;
        }

        private void NavPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseEnter += ChildControl_MouseEnter;
            e.Control.MouseLeave += ChildControl_MouseLeave;
        }

        private void ChildControl_MouseEnter(object sender, EventArgs e)
        {
            if (!_isHovering)
            {
                _isHovering = true;
                _hoverTimer.Start();
                Invalidate();
            }
        }

        private void ChildControl_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = PointToClient(MousePosition);
            if (!ClientRectangle.Contains(mousePos))
            {
                _isHovering = false;
                _hoverTimer.Start();
                Invalidate();
            }
        }

        private void HoverTimer_Tick(object sender, EventArgs e)
        {
            float target = _isHovering ? 1f : 0f;
            float diff = target - _hoverProgress;
            
            if (Math.Abs(diff) < 0.05f)
            {
                _hoverProgress = target;
                if (!_isHovering && _hoverProgress == 0f) _hoverTimer.Stop();
            }
            else
            {
                _hoverProgress += diff * 0.2f;
            }
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!_isHovering)
            {
                _isHovering = true;
                _hoverTimer.Start();
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Point mousePos = PointToClient(MousePosition);
            if (!ClientRectangle.Contains(mousePos))
            {
                _isHovering = false;
                _hoverTimer.Start();
                Invalidate();
            }
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
            else if (_hoverProgress > 0)
            {
                int alpha = (int)(255 * _hoverProgress);
                using (var path = RoundedHelper.CreateRoundedRectangle(rect, _radius))
                using (var brush = new SolidBrush(Color.FromArgb(alpha, _hoverColor)))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _hoverTimer?.Dispose();
            base.Dispose(disposing);
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

    #region Bar Chart (Modern)

    public class BarChart : Control
    {
        private List<BarChartItem> _data = new List<BarChartItem>();
        private Color[] _palette = new[] { ThemeManager.AccentBlue, ThemeManager.AccentGreen, ThemeManager.AccentOrange, ThemeManager.AccentPurple, ThemeManager.AccentRed };
        private string _title = "Preços dos Produtos";
        private int _hoveredIndex = -1;
        private float[] _animationProgress;
        private Timer _animationTimer;

        public string Title { get => _title; set { _title = value; Invalidate(); } }

        public BarChart()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            this.BackColor = ThemeManager.BgCard;
            this.Font = new Font("Segoe UI", 9F);

            _animationTimer = new Timer { Interval = 16 };
            _animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            bool allComplete = true;
            for (int i = 0; i < _animationProgress.Length; i++)
            {
                if (_animationProgress[i] < 1f)
                {
                    _animationProgress[i] += 0.08f;
                    if (_animationProgress[i] > 1f) _animationProgress[i] = 1f;
                    allComplete = false;
                }
            }
            Invalidate();
            if (allComplete) _animationTimer.Stop();
        }

        public void SetData(List<BarChartItem> data)
        {
            _data = data ?? new List<BarChartItem>();
            _animationProgress = new float[_data.Count];
            for (int i = 0; i < _animationProgress.Length; i++)
                _animationProgress[i] = 0f;
            _animationTimer.Start();
            Invalidate();
        }

        public void SetPalette(Color[] colors)
        {
            if (colors != null && colors.Length > 0) _palette = colors;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int newHovered = GetBarIndexAtPoint(e.Location);
            if (newHovered != _hoveredIndex)
            {
                _hoveredIndex = newHovered;
                Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _hoveredIndex = -1;
            Invalidate();
        }

        private int GetBarIndexAtPoint(Point pt)
        {
            if (_data.Count == 0) return -1;

            int titleHeight = 40;
            int legendHeight = 30;
            int padding = 20;
            int chartLeft = padding + 60;
            int chartRight = Width - padding;
            int chartTop = titleHeight + padding;
            int chartBottom = Height - legendHeight - padding;
            int chartHeight = chartBottom - chartTop;

            if (_data.Count == 0 || chartHeight <= 0) return -1;

            int barWidth = Math.Max(20, (chartRight - chartLeft) / _data.Count - 10);
            int spacing = (chartRight - chartLeft - barWidth * _data.Count) / (_data.Count + 1);

            for (int i = 0; i < _data.Count; i++)
            {
                int x = chartLeft + spacing + i * (barWidth + spacing);
                if (pt.X >= x && pt.X <= x + barWidth && pt.Y >= chartTop && pt.Y <= chartBottom)
                    return i;
            }
            return -1;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Background
            using (var brush = new SolidBrush(BackColor))
            {
                g.FillRectangle(brush, ClientRectangle);
            }

            int titleHeight = 40;
            int legendHeight = 30;
            int padding = 20;
            int chartLeft = padding + 50;
            int chartRight = Width - padding;
            int chartTop = titleHeight + padding;
            int chartBottom = Height - legendHeight - padding;
            int chartHeight = chartBottom - chartTop;
            int chartWidth = chartRight - chartLeft;

            // Draw title
            using (var titleFont = new Font("Segoe UI", 12F, FontStyle.Bold))
            using (var titleBrush = new SolidBrush(ThemeManager.TextPrimary))
            {
                g.DrawString(_title, titleFont, titleBrush, padding, 12);
            }

            if (_data.Count == 0 || chartHeight <= 0 || chartWidth <= 0)
            {
                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var brush = new SolidBrush(ThemeManager.TextMuted))
                {
                    g.DrawString("Adicione produtos para ver o gráfico", this.Font, brush, 
                        new Rectangle(0, chartTop, Width, chartHeight), sf);
                }
                return;
            }

            // Calculate max value
            decimal maxValue = _data.Max(d => d.Value);
            if (maxValue <= 0) maxValue = 1;

            // Draw grid lines
            int gridLines = 5;
            using (var gridPen = new Pen(Color.FromArgb(40, ThemeManager.TextMuted), 1))
            using (var labelBrush = new SolidBrush(ThemeManager.TextMuted))
            using (var labelFont = new Font("Segoe UI", 8F))
            {
                gridPen.DashStyle = DashStyle.Dot;
                for (int i = 0; i <= gridLines; i++)
                {
                    int y = chartBottom - (int)(chartHeight * i / (float)gridLines);
                    g.DrawLine(gridPen, chartLeft, y, chartRight, y);

                    decimal labelValue = maxValue * i / gridLines;
                    string labelText = labelValue.ToString("N0") + " €";
                    var labelSize = g.MeasureString(labelText, labelFont);
                    g.DrawString(labelText, labelFont, labelBrush, chartLeft - labelSize.Width - 5, y - labelSize.Height / 2);
                }
            }

            // Draw bars
            int barWidth = Math.Max(20, Math.Min(60, (chartWidth / _data.Count) - 15));
            int totalBarsWidth = barWidth * _data.Count;
            int totalSpacing = chartWidth - totalBarsWidth;
            int spacing = totalSpacing / (_data.Count + 1);

            for (int i = 0; i < _data.Count; i++)
            {
                var item = _data[i];
                float progress = _animationProgress != null && i < _animationProgress.Length ? _animationProgress[i] : 1f;
                int barHeight = (int)(chartHeight * (float)(item.Value / maxValue) * progress);
                int x = chartLeft + spacing + i * (barWidth + spacing);
                int y = chartBottom - barHeight;

                Color barColor = _palette[i % _palette.Length];
                bool isHovered = i == _hoveredIndex;

                if (isHovered)
                {
                    barColor = RoundedHelper.LightenColor(barColor, 0.2f);
                }

                // Draw bar with rounded top
                if (barHeight > 0)
                {
                    using (var path = CreateRoundedTopRect(x, y, barWidth, barHeight, 6))
                    {
                        // Gradient fill
                        using (var brush = new LinearGradientBrush(
                            new Rectangle(x, y, barWidth, barHeight + 1),
                            barColor,
                            RoundedHelper.DarkenColor(barColor, 0.2f),
                            LinearGradientMode.Vertical))
                        {
                            g.FillPath(brush, path);
                        }

                        // Glow effect on hover
                        if (isHovered)
                        {
                            using (var glowBrush = new SolidBrush(Color.FromArgb(30, barColor)))
                            {
                                var glowRect = new Rectangle(x - 4, y - 4, barWidth + 8, barHeight + 8);
                                using (var glowPath = CreateRoundedTopRect(glowRect.X, glowRect.Y, glowRect.Width, glowRect.Height, 8))
                                {
                                    g.FillPath(glowBrush, glowPath);
                                }
                            }
                        }
                    }

                    // Draw value on top of bar
                    if (progress >= 0.9f)
                    {
                        string valueText = item.Value.ToString("N2") + " €";
                        using (var valueFont = new Font("Segoe UI", 8F, FontStyle.Bold))
                        using (var valueBrush = new SolidBrush(ThemeManager.TextPrimary))
                        {
                            var valueSize = g.MeasureString(valueText, valueFont);
                            float valueX = x + (barWidth - valueSize.Width) / 2;
                            float valueY = y - valueSize.Height - 4;
                            if (valueY < chartTop) valueY = y + 4;
                            g.DrawString(valueText, valueFont, valueBrush, valueX, valueY);
                        }
                    }
                }

                // Draw label below bar
                string label = item.Label.Length > 10 ? item.Label.Substring(0, 10) + "..." : item.Label;
                using (var labelFont = new Font("Segoe UI", 8F))
                using (var labelBrush = new SolidBrush(isHovered ? ThemeManager.TextPrimary : ThemeManager.TextSecondary))
                {
                    var labelSize = g.MeasureString(label, labelFont);
                    float labelX = x + (barWidth - labelSize.Width) / 2;
                    g.DrawString(label, labelFont, labelBrush, labelX, chartBottom + 8);
                }
            }

            // Draw tooltip on hover
            if (_hoveredIndex >= 0 && _hoveredIndex < _data.Count)
            {
                var item = _data[_hoveredIndex];
                string tooltip = $"{item.Label}\nPreço: {item.Value:N2} €";
                using (var tooltipFont = new Font("Segoe UI", 9F))
                {
                    var tooltipSize = g.MeasureString(tooltip, tooltipFont);
                    int tooltipX = Math.Min(Width - (int)tooltipSize.Width - 20, 
                        chartLeft + spacing + _hoveredIndex * (barWidth + spacing));
                    int tooltipY = chartTop + 10;

                    var tooltipRect = new Rectangle(tooltipX - 8, tooltipY - 4, 
                        (int)tooltipSize.Width + 16, (int)tooltipSize.Height + 8);

                    using (var tooltipPath = RoundedHelper.CreateRoundedRectangle(tooltipRect, 6))
                    using (var tooltipBrush = new SolidBrush(Color.FromArgb(230, ThemeManager.BgPrimary)))
                    using (var tooltipPen = new Pen(ThemeManager.BorderDefault))
                    using (var textBrush = new SolidBrush(ThemeManager.TextPrimary))
                    {
                        g.FillPath(tooltipBrush, tooltipPath);
                        g.DrawPath(tooltipPen, tooltipPath);
                        g.DrawString(tooltip, tooltipFont, textBrush, tooltipX, tooltipY);
                    }
                }
            }
        }

        private GraphicsPath CreateRoundedTopRect(int x, int y, int width, int height, int radius)
        {
            var path = new GraphicsPath();
            if (height < radius * 2)
            {
                path.AddRectangle(new Rectangle(x, y, width, height));
                return path;
            }

            path.AddArc(x, y, radius * 2, radius * 2, 180, 90);
            path.AddArc(x + width - radius * 2, y, radius * 2, radius * 2, 270, 90);
            path.AddLine(x + width, y + radius, x + width, y + height);
            path.AddLine(x + width, y + height, x, y + height);
            path.AddLine(x, y + height, x, y + radius);
            path.CloseFigure();
            return path;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _animationTimer?.Dispose();
            base.Dispose(disposing);
        }
    }

    public class BarChartItem
    {
        public string Label { get; set; }
        public decimal Value { get; set; }

        public BarChartItem(string label, decimal value)
        {
            Label = label;
            Value = value;
        }
    }

    #endregion

    #region Pie Chart

    public class PieChart : Control
    {
        private IDictionary<string, int> _data = new Dictionary<string, int>();
        private Color[] _palette = new[] { ThemeManager.AccentBlue, ThemeManager.AccentGreen, ThemeManager.AccentOrange, ThemeManager.AccentPurple, ThemeManager.AccentRed };
        
        public PieChart()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                         ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            // Use theme background instead of transparent
            this.BackColor = ThemeManager.BgCard;
        }

        public void SetData(IDictionary<string, int> data)
        {
            _data = data ?? new Dictionary<string, int>();
            Invalidate();
        }

        public void SetPalette(Color[] colors)
        {
            if (colors != null && colors.Length > 0) _palette = colors;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle area = new Rectangle(8, 8, Math.Min(this.Width, this.Height) - 16, Math.Min(this.Width, this.Height) - 16);

            int total = _data.Values.Sum();
            if (total <= 0)
            {
                using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                using (var brush = new SolidBrush(ThemeManager.TextMuted))
                {
                    g.DrawString("Sem dados", this.Font, brush, area, sf);
                }
                return;
            }

            float startAngle = -90f;
            int idx = 0;
            foreach (var kv in _data)
            {
                float sweep = (kv.Value / (float)total) * 360f;
                Color col = _palette[idx % _palette.Length];
                using (var brush = new SolidBrush(col))
                {
                    g.FillPie(brush, area, startAngle, sweep);
                }

                startAngle += sweep;
                idx++;
            }

            // draw legend on the right
            int legendX = area.Right + 12;
            int legendY = area.Top;
            int boxSize = 12;
            idx = 0;
            using (var sf = new StringFormat { LineAlignment = StringAlignment.Center })
            {
                foreach (var kv in _data)
                {
                    Color col = _palette[idx % _palette.Length];
                    using (var brush = new SolidBrush(col))
                    using (var pen = new Pen(Color.FromArgb(160, Color.Black)))
                    {
                        g.FillRectangle(brush, legendX, legendY + idx * 20, boxSize, boxSize);
                        g.DrawRectangle(pen, legendX, legendY + idx * 20, boxSize, boxSize);
                    }

                    string label = $"{kv.Key} ({kv.Value})";
                    using (var brush = new SolidBrush(ThemeManager.TextPrimary))
                    {
                        g.DrawString(label, new Font(this.Font.FontFamily, 9f), brush, new PointF(legendX + boxSize + 8, legendY + idx * 20));
                    }

                    idx++;
                }
            }
        }
    }

    #endregion
}
