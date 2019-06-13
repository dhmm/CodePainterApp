using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

namespace CodePainterApp
{
    public class DrawedPoint
    {
        public Color Color { set; get; }
        public Point Point { set; get; }
        public Size Size { set; get; }        
                
        public DrawedPoint(Point point, Color color, Size size)
        {
            Point = point;
            Color = color;
            Size = size;
        }
        public void Draw(Graphics g)
        {            
            SolidBrush sb = new SolidBrush(this.Color);
            g.FillRectangle(sb, Point.X, Point.Y, Size.Width, Size.Height);
            Debug.WriteLine("Point X = " + Point.X + " Y = " + Point.Y + " Color = "+this.Color + " Size = ( "+Size.Width+" x "+Size.Height+" ) ");
        }
       /* public void ReDraw(Graphics g)
        {
            Pen p = new Pen(Color.FromArgb(250, 40, 40, 40));
            g.DrawLine(p, this.Point,new Point(this.Point.X+this.Size.Width , this.Point.Y+this.Size.Height));

            SolidBrush sb = new SolidBrush(this.Color);
            g.FillRectangle(sb, Point.X+1, Point.Y+1, Size.Width-1, Size.Height-1);
            Debug.WriteLine("Point X = " + Point.X+1 + " Y = " + Point.Y+1 + " Color = " + this.Color + " Size = ( " + Size.Width + " x " + Size.Height + " ) ");
        }*/
    }
}
