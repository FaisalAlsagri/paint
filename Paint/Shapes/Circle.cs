using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Shapes
{
    public class Circle : Borderable
    {
        private Pen pen;
        public Circle():base()
        {
            Start = new();
            End = new();
            pen = new(DefaultSettings.Color, DefaultSettings.Thickness);
            pen.DashStyle = DefaultSettings.DashStyle;
            type = ShapeType.Circle;
        }
        public Circle(Point start, Point end) : base()
        {
            Start = start;
            End = end;
            pen = new(DefaultSettings.Color, DefaultSettings.Thickness);
            pen.DashStyle = DefaultSettings.DashStyle;
            type = ShapeType.Circle;
        }
        protected override Color Color
        {
            get
            {
                return pen.Color;
            }
            set
            {
                pen.Color = value;
            }
        }
        protected override float Thickness
        {
            get
            {
                return pen.Width;
            }
            set
            {
                pen.Width = value;
            }
        }
        protected override DashStyle Style
        {
            get
            {
                return pen.DashStyle;
            }
            set
            {
                pen.DashStyle = value;
            }
        }
        public override void Draw(Graphics g)
        {
            if (isSelected) 
                g.DrawRectangle(borderPen, Start.X-borderOffset, Start.Y - borderOffset, Width+borderOffset*2, Height+borderOffset * 2);
            g.DrawEllipse(pen, Start.X, Start.Y, Width, Height);
        }
    }
}
