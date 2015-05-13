using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Графика2
{
    class BezierDrawer
    {
        public static void DrawBezier(Point[] points, Graphics graphics)
        {
            double t;
            Pen pen = new Pen(Color.Black, 1);

            graphics.DrawLines(pen, points);

            pen.Width = 2;
            Point start = new Point(points[0].X, points[0].Y);

            // Цикл малювання кривої Безьє.
            // Параметр t пробігає значення між 0.0 та 1.0 з кроком 0.03.
            // Обчислюється значення наступної точки і креслиться пряма, що поєднує попередню точку з нею.
            for (t = 0.0; t < 1.0; t += 0.03)
            {
                Point stop = CalcBezierCurve(points, t);
                graphics.DrawLine(pen, start, stop);
                start = stop;
                //LineTo(hdc, np.x, np.y);
            }
        }
        static Point CalcBezierCurve(Point[] points, double t)
        {
            int i, c;
            double p;
            Point np = new Point();
            int n = points.Length - 1;

            Point[] localPoints = new Point[points.Length];
            points.CopyTo(localPoints, 0);

            c = 1;
            for (i = 0; i <= n; i++)
            {
                localPoints[i].X *= c;
                localPoints[i].Y *= c;
                c = (n - i) * c / (i + 1);
            }
            p = 1;
            for (i = 0; i <= n; i++)
            {
                localPoints[i].X = (int)Math.Round(localPoints[i].X * p);
                localPoints[i].Y = (int)Math.Round(localPoints[i].Y * p);
                p = p * t;
            }
            p = 1;
            for (i = n; i >= 0; i--)
            {
                localPoints[i].X = (int)Math.Round(localPoints[i].X * p);
                localPoints[i].Y = (int)Math.Round(localPoints[i].Y * p);
                p = p * (1 - t);
            }
            np.X = 0;
            np.Y = 0;
            for (i = 0; i <= n; i++)
            {
                np.X = np.X + localPoints[i].X;
                np.Y = np.Y + localPoints[i].Y;
            }
            return np;
        }
    }
}
