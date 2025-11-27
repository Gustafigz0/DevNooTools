using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DevNooTools
{
    public class RoundedButton : Button
    {
        private int radius = 10;
        private Color hoverColor = Color.LightBlue;
        private bool isHovered = false;

        public int Radius
        {
            get => radius;
            set
            {
                radius = value;
                this.Invalidate();
            }
        }

        public Color HoverColor
        {
            get => hoverColor;
            set => hoverColor = value;
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.DoubleBuffered = true;
            this.Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            isHovered = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            isHovered = false;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            
            using (GraphicsPath path = GetRoundedRectangle(rect, radius))
            {
                this.Region = new Region(path);
                
                Color currentBackColor = isHovered ? hoverColor : this.BackColor;
                using (SolidBrush brush = new SolidBrush(currentBackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }
            }

            TextRenderer.DrawText(
                pevent.Graphics,
                this.Text,
                this.Font,
                rect,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
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
    }
}
