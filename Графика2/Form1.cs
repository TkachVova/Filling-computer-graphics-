using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Графика2
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        List<Point> points = new List<Point>();
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Point cursorPosition = pictureBox.PointToClient(Cursor.Position);
            points.Add(cursorPosition);
            Pen pen = new Pen(Color.Black, 1);
            graphics.DrawEllipse(pen, cursorPosition.X - 5, cursorPosition.Y - 5, 10, 10);
            pictureBox.Image = bitmap;

            if(drawButton.Enabled == false){
                drawButton.Enabled = true;
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            BezierDrawer.DrawBezier(points.ToArray(), graphics);
            pictureBox.Image = bitmap;
            rotateButton.Enabled = true;
            scaleButton.Enabled = true;
            transferButton.Enabled = true;
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            points = Transformator.RotateFigure(points.ToArray(), new Point((int)rotateCenterX.Value, (int)rotateCenterY.Value), (double)degreesToRotate.Value);
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i < points.Count; i++ )
            {
                graphics.DrawEllipse(pen, points[i].X - 5, points[i].Y - 5, 10, 10);
            }
            BezierDrawer.DrawBezier(points.ToArray(), graphics);
            pictureBox.Image = bitmap;
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            points = Transformator.ScaleFigure(points.ToArray(), (double) scaleX.Value / 100, (double) scaleX.Value / 100);
            scaleX.Value = 0;
            scaleY.Value = 0;
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i < points.Count; i++)
            {
                graphics.DrawEllipse(pen, points[i].X - 5, points[i].Y - 5, 10, 10);
            }
            BezierDrawer.DrawBezier(points.ToArray(), graphics);
            pictureBox.Image = bitmap;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            points = Transformator.TransferFigure(points.ToArray(), (double)transferX.Value, (double)transferY.Value);
            transferX.Value = 0;
            transferY.Value = 0;
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i < points.Count; i++)
            {
                graphics.DrawEllipse(pen, points[i].X - 5, points[i].Y - 5, 10, 10);
            }
            BezierDrawer.DrawBezier(points.ToArray(), graphics);
            pictureBox.Image = bitmap;
        }

        private void clearCurve_Click(object sender, EventArgs e)
        {
            points.Clear();
            rotateButton.Enabled = false;
            scaleButton.Enabled = false;
            transferButton.Enabled = false;
            drawButton.Enabled = false;
            graphics.Clear(Color.Transparent);
            pictureBox.Image = bitmap;
        }
    }
}
