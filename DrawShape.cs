using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBox
{
    enum DrawType
    {
        Line,
        Circle,
        Rect,
        Triangle,
        None
    }

    public static class DrawShape
    {
        public static void Triangle(Bitmap drawing, Pen pen, int startX, int startY, int endX, int endY)
        {
            using (Graphics g = Graphics.FromImage(drawing))
            {
                Point[] points = { new Point((endX + startX) / 2, startY), new Point(startX, endY), new Point(endX, endY) };
                g.DrawPolygon(pen, points);
            }
        }

        public static void Rectangle(Bitmap drawing, Pen pen, int startX, int startY, int endX, int endY)
        {
            using (Graphics g = Graphics.FromImage(drawing))
            {
                g.DrawRectangle(pen, startX, startY, endX - startX, endY - startY);
            }
        }

        public static void Circle(Bitmap drawing, Pen pen, int startX, int startY, int endX, int endY)
        {
            using (Graphics g = Graphics.FromImage(drawing))
            {
                Rectangle rect = new Rectangle(startX, startY, endX - startX, endY - startY);
                g.DrawEllipse(pen, rect);
            }
        }

        public static void Line(Bitmap drawing, Pen pen, int startX, int startY, int endX, int endY)
        {
            using (Graphics g = Graphics.FromImage(drawing))
            {
                g.DrawLine(pen, startX, startY, endX, endY);
            }
        }
    }
}
