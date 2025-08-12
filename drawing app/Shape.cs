using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drawing_App;

namespace Drawing_App
{

    // abstract class
    public abstract class Shape
    {
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public Rectangle Bounds { get; set; }
        public bool IsSelected { get; set; }

        public abstract void Draw(Graphics g);

        public virtual bool Contains(Point p)
        {
            return Bounds.Contains(p);
        }

        public virtual void DrawSelection(Graphics g)
        {
            if (IsSelected)
            {
                using (Pen selectionPen = new Pen(Color.Blue, 2))
                {
                    selectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    g.DrawRectangle(selectionPen, Bounds);
                }
            }
        }
    }
}


// implementing for rectangle shape
public class RectangleShape : Shape
{
    // override method
    public override void Draw(Graphics g)        
    {
        // Fill the rectangle
        using (SolidBrush fillBrush = new SolidBrush(FillColor))
        {
            g.FillRectangle(fillBrush, Bounds);
        }

        // Draw the border
        using (Pen borderPen = new Pen(BorderColor, BorderWidth))
        {
            g.DrawRectangle(borderPen, Bounds);
        }
    }

    public override bool Contains(Point p)
    {
        return Bounds.Contains(p);
    }
}


// implementing for circle shape
public class CircleShape : Shape
{
    public override void Draw(Graphics g)
    {
        // Fill the ellipse
        using (SolidBrush fillBrush = new SolidBrush(FillColor))
        {
            g.FillEllipse(fillBrush, Bounds);
        }

        // Draw the border
        using (Pen borderPen = new Pen(BorderColor, BorderWidth))
        {
            g.DrawEllipse(borderPen, Bounds);
        }
    }

    public override bool Contains(Point p)
    {
        // Check if point is within the ellipse
        float centerX = Bounds.X + Bounds.Width / 2f;
        float centerY = Bounds.Y + Bounds.Height / 2f;
        float radiusX = Bounds.Width / 2f;
        float radiusY = Bounds.Height / 2f;

        if (radiusX == 0 || radiusY == 0) return false;

        float normalizedX = (p.X - centerX) / radiusX;
        float normalizedY = (p.Y - centerY) / radiusY;

        return (normalizedX * normalizedX + normalizedY * normalizedY) <= 1;
    }
}

