using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Graphics_lab2
{
    class PolDrawer
    {

        public Bitmap bitmap;
        public PolDrawer(int w, int h)
        {
            bitmap = new Bitmap(w, h);
        }

        public void FillZone44(Point point)
        {
            if (point.X < bitmap.Size.Width && point.Y < bitmap.Size.Height && point.X > 0 && point.Y > 0)
            {
                System.Drawing.Color cl = bitmap.GetPixel(point.X, point.Y);

                if (cl.B.Equals(255) && cl.G.Equals(255) && cl.R.Equals(255))
                {
                    bitmap.SetPixel(point.X, point.Y, Color.Green);
                    FillZone44(new Point(point.X + 1, point.Y));
                    FillZone44(new Point(point.X, point.Y + 1));
                    FillZone44(new Point(point.X - 1, point.Y));
                    FillZone44(new Point(point.X, point.Y - 1));
                }
            }

        }

        public void DrawPol(Point[] points, Graphics graphics)
        {
            double t;
            Pen pen = new Pen(Color.Green, 1);

            graphics.DrawPolygon(pen, points);

            pen.Width = 2;
            Point start = new Point(points[0].X, points[0].Y);

            // Цикл малювання кривої Безьє.
            // Параметр t пробігає значення між 0.0 та 1.0 з кроком 0.03.
            // Обчислюється значення наступної точки і креслиться пряма, що поєднує попередню точку з нею.
           
        }


        public void FillZone4(Point point)
        {
            if (point.X < bitmap.Size.Width && point.Y < bitmap.Size.Height&&point.X>0&&point.Y>0)
            {
                System.Drawing.Color cl = bitmap.GetPixel(point.X, point.Y);

                if (cl.B.Equals(255)&&cl.G.Equals(255)&&cl.R.Equals(255))
                {
                    bitmap.SetPixel(point.X, point.Y, Color.Magenta);
                    FillZone4(new Point(point.X + 1, point.Y));
                    FillZone4(new Point(point.X, point.Y + 1));
                    FillZone4(new Point(point.X - 1, point.Y));
                    FillZone4(new Point(point.X, point.Y - 1));
                }
            }

        }

        public void FillZone8(Point point)
        {
            if (point.X < bitmap.Size.Width && point.Y < bitmap.Size.Height && point.X > 0 && point.Y > 0)
            {
                System.Drawing.Color cl = bitmap.GetPixel(point.X, point.Y);

                if (cl.B.Equals(255) && cl.G.Equals(255) && cl.R.Equals(255))
                {
                    bitmap.SetPixel(point.X, point.Y, Color.Green);
                    FillZone8(new Point(point.X + 1, point.Y));
                    FillZone8(new Point(point.X, point.Y + 1));
                    FillZone8(new Point(point.X - 1, point.Y));
                    FillZone8(new Point(point.X, point.Y - 1));

                    FillZone8(new Point(point.X+1, point.Y+1));
                    FillZone8(new Point(point.X - 1, point.Y - 1));
                    FillZone8(new Point(point.X + 1, point.Y - 1));
                    FillZone8(new Point(point.X - 1, point.Y + 1));
                }
            }

        }



    }
}
