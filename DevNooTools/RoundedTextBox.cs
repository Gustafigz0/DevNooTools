using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    public class RoundedTextBox : UserControl
    {
        private TextBox textBox;
        private int radius = 10;
        private Color borderColor = Color.Gray;
        private Color focusBorderColor = Color.Blue;
        private int borderSize = 1;
        private bool isFocused = false;

        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color FocusBorderColor
        {
            get => focusBorderColor;
            set
            {
                focusBorderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public override string Text
        {
            get => textBox?.Text ?? string.Empty;
            set
            {
                if (textBox != null)
                    textBox.Text = value;
            }
        }

        public override Color ForeColor
        {
            get => textBox?.ForeColor ?? base.ForeColor;
            set
            {
                base.ForeColor = value;
                if (textBox != null)
                    textBox.ForeColor = value;
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                if (textBox != null)
                    textBox.BackColor = value;
            }
        }

        public HorizontalAlignment TextAlign
        {
            get => textBox?.TextAlign ?? HorizontalAlignment.Left;
            set
            {
                if (textBox != null)
                    textBox.TextAlign = value;
            }
        }

        public RoundedTextBox()
        {
            InitializeTextBox();
        }

        private void InitializeTextBox()
        {
            if (textBox != null)
                return;

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                BackColor = this.BackColor,
                ForeColor = this.ForeColor
            };

            this.Controls.Add(textBox);
            this.DoubleBuffered = true;
            this.Padding = new Padding(10, 12, 10, 12);
            this.Size = new Size(150, 35);

            textBox.Enter += (s, e) =>
            {
                isFocused = true;
                this.Invalidate();
                this.OnEnter(e);
            };

            textBox.Leave += (s, e) =>
            {
                isFocused = false;
                this.Invalidate();
                this.OnLeave(e);
            };

            textBox.TextChanged += (s, e) => this.OnTextChanged(e);
            textBox.KeyPress += (s, e) => this.OnKeyPress(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            InitializeTextBox();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            
            using (GraphicsPath path = GetRoundedRectangle(rect, radius))
            {
                this.Region = new Region(path);
                
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                Color currentBorderColor = isFocused ? focusBorderColor : borderColor;
                using (Pen pen = new Pen(currentBorderColor, borderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectangle(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate();
        }
    }
}
