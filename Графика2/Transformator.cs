using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Graphics_lab2
{
    class Transformator
    {
        public static List<Point> RotateFigure(Point[] points, Point origin, double angle){
            List<Point> ret = new List<Point>();
            Point temp = new Point();
            for (int i = 0; i < points.Length; i++ )
            {
                temp.X = (int)Math.Round(origin.X + (points[i].X - origin.X) * Math.Cos(angle) - (points[i].Y - origin.Y) * Math.Sin(angle));
                temp.Y = (int)Math.Round(origin.Y + (points[i].X - origin.X) * Math.Sin(angle) + (points[i].Y - origin.Y) * Math.Cos(angle));
                ret.Add(temp);
            }
            return ret;
        }

        public static List<Point> ScaleFigure(Point[] points, double scaleX, double scaleY)
        {
            List<Point> ret = new List<Point>();
            Point temp = new Point();
            for (int i = 0; i < points.Length; i++)
            {
                temp.X = (int)Math.Round(points[i].X * scaleX);
                temp.Y = (int)Math.Round(points[i].Y * scaleY);
                ret.Add(temp);
            }
            return ret;
        }

        public static List<Point> TransferFigure(Point[] points, double deltaX, double deltaY)
        {
            List<Point> ret = new List<Point>();
            Point temp = new Point();
            for (int i = 0; i < points.Length; i++)
            {
                temp.X = (int)Math.Round(points[i].X + deltaX);
                temp.Y = (int)Math.Round(points[i].Y + deltaY);
                ret.Add(temp);
            }
            return ret;
        }
    }
}
