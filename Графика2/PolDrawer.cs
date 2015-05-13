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
           
        }


        public void FillZone4(Point point, Color fromColor)
        {
            if (point.X < bitmap.Size.Width && point.Y < bitmap.Size.Height&&point.X>0&&point.Y>0)
            {
                System.Drawing.Color cl = bitmap.GetPixel(point.X, point.Y);

                if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                {
                    bitmap.SetPixel(point.X, point.Y, Color.Magenta);
                    FillZone4(new Point(point.X + 1, point.Y), fromColor);
                    FillZone4(new Point(point.X, point.Y + 1), fromColor);
                    FillZone4(new Point(point.X - 1, point.Y), fromColor);
                    FillZone4(new Point(point.X, point.Y - 1), fromColor);
                }
            }

        }

        public void FillZone8(Point point, Color fromColor)
        {
            if (point.X < bitmap.Size.Width && point.Y < bitmap.Size.Height && point.X > 0 && point.Y > 0)
            {
                System.Drawing.Color cl = bitmap.GetPixel(point.X, point.Y);

                if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                {
                    bitmap.SetPixel(point.X, point.Y, Color.Green);
                    FillZone8(new Point(point.X + 1, point.Y), fromColor);
                    FillZone8(new Point(point.X, point.Y + 1), fromColor);
                    FillZone8(new Point(point.X - 1, point.Y), fromColor);
                    FillZone8(new Point(point.X, point.Y - 1), fromColor);

                    FillZone8(new Point(point.X + 1, point.Y + 1), fromColor);
                    FillZone8(new Point(point.X - 1, point.Y - 1), fromColor);
                    FillZone8(new Point(point.X + 1, point.Y - 1), fromColor);
                    FillZone8(new Point(point.X - 1, point.Y + 1), fromColor);
                }
            }

        }



        public void FloodFill(Point start, Color fromColor)
        {
            System.Drawing.Color cl = bitmap.GetPixel(start.X, start.Y);

            bitmap.SetPixel(start.X, start.Y, Color.Black);

            var open = new Queue<Point>();
            open.Enqueue(start);

            while (open.Count > 0)
            {
                var current = open.Dequeue();
                var x = current.X;
                var y = current.Y;

                if (x > 0)
                {
                    cl = bitmap.GetPixel(x - 1, y);
                    if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                    {
                        bitmap.SetPixel(x - 1, y, Color.Black);
                        open.Enqueue(new Point(x - 1, y));
                    }
                }
                if (x < bitmap.Width - 1)
                {
                    cl = bitmap.GetPixel(x + 1, y);
                    if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                    {
                        bitmap.SetPixel(x + 1, y, Color.Black);
                        open.Enqueue(new Point(x + 1, y));
                    }
                }
                if (y > 0)
                {
                    cl = bitmap.GetPixel(x, y - 1);
                    if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                    {
                        bitmap.SetPixel(x, y - 1, Color.Black);
                        open.Enqueue(new Point(x, y - 1));
                    }
                }
                if (y < bitmap.Height - 1)
                {
                    cl = bitmap.GetPixel(x, y + 1);
                    if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                    {
                        bitmap.SetPixel(x, y + 1, Color.Black);
                        open.Enqueue(new Point(x, y + 1));
                    }
                }
            }

        }


        public void LineFill(Point start, Color fromColor)
        {
            System.Drawing.Color cl = bitmap.GetPixel(start.X, start.Y);

            //bitmap.SetPixel(start.X, start.Y, Color.Black);

            var open = new Queue<Point>();
            open.Enqueue(start);
            List<int> filledLines = new List<int>();

            while (open.Count > 0)
            {
                Point current = open.Dequeue();
                filledLines.Add(current.Y);
                int x = current.X;
                int y = current.Y;
                int x_iter_left = x;
                int x_iter_right = x + 1;
                bool right_stop_not_found = true;
                bool left_stop_not_found = true;
                bool can_go_up = true;
                bool can_go_down = true;

                while (right_stop_not_found || left_stop_not_found)
                {
                    if (right_stop_not_found)
                    {
                        if (x_iter_right < bitmap.Width)
                        {
                            cl = bitmap.GetPixel(x_iter_right, y);
                            if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                            {
                                if (can_go_up)
                                {
                                    if (y - 1 > 0)
                                    {
                                        cl = bitmap.GetPixel(x_iter_right, y - 1);
                                        if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                                        {
                                            if (!filledLines.Any(p => p==y-1))
                                            {
                                                open.Enqueue(new Point(x_iter_right, y - 1));
                                                can_go_up = false;
                                            }

                                        }
                                    }
                                }
                                if (can_go_down)
                                {
                                    if (y + 1 < bitmap.Height)
                                    {
                                        cl = bitmap.GetPixel(x_iter_right, y + 1);
                                        if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                                        {
                                            if (!filledLines.Any(p => p == y + 1))
                                            {
                                                open.Enqueue(new Point(x_iter_right, y + 1));
                                                can_go_up = false;
                                            }
                                        }
                                    }
                                }
                                bitmap.SetPixel(x_iter_right, y, Color.YellowGreen);
                                x_iter_right++;
 
                            }
                            else
                            {
                                x_iter_right--;
                                right_stop_not_found = false;
                            }
                        }
                        
                    }
                    if (left_stop_not_found)
                    {
                        cl = bitmap.GetPixel(x_iter_left, y);
                        //cl = bitmap.GetPixel(x_iter_left, y);
                        if (x_iter_left > 0)
                        {
                            if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                            {
                                if (can_go_up)
                                {
                                    if (y - 1 > 0)
                                    {
                                        cl = bitmap.GetPixel(x_iter_left, y - 1);
                                        if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                                        {
                                            if (!filledLines.Any(p => p == y - 1))
                                            {
                                                open.Enqueue(new Point(x_iter_left, y - 1));
                                                can_go_up = false;
                                            }

                                        }
                                    }
                                }
                                if (can_go_down)
                                {
                                    if (y + 1 < bitmap.Height)
                                    {
                                        cl = bitmap.GetPixel(x_iter_left, y + 1);
                                        if (cl.B.Equals(fromColor.B) && cl.G.Equals(fromColor.G) && cl.R.Equals(fromColor.R))
                                        {
                                            if (!filledLines.Any(p => p == y + 1))
                                            {
                                                open.Enqueue(new Point(x_iter_left, y + 1));
                                                can_go_down = false;
                                            }
                                        }
                                    }
                                }
                                bitmap.SetPixel(x_iter_left, y, Color.YellowGreen);
                                x_iter_left--;
                            }
                            else
                            {
                                x_iter_left++;
                                left_stop_not_found = false;
                            }
                        }
                        
                    }  
                }




                
            }

        }




    }
}
