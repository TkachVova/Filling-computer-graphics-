using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_lab2
{
    public partial class Form1 : Form
    {
        //Bitmap bitmap;
        PolDrawer pd;
        Graphics graphics;
        List<Point> points = new List<Point>();
        int fillmode = 0;
        public Form1()
        {
            InitializeComponent();
            pd = new PolDrawer(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(pd.bitmap);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            graphics.FillRectangle(myBrush, 0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = pd.bitmap;
            fillButton.Enabled = true;
            button1.Enabled = true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (fillmode == 0)
            {
                Point cursorPosition = pictureBox.PointToClient(Cursor.Position);
                points.Add(cursorPosition);
                Pen pen = new Pen(Color.Red, 1);
                graphics.DrawRectangle(pen, cursorPosition.X - 5, cursorPosition.Y - 5, 10, 10);
                pictureBox.Image = pd.bitmap;

                if (drawButton.Enabled == false)
                {
                    drawButton.Enabled = true;
                }
            }
            else
            {
                if (fillmode == 1)
                {
                    Pen pen = new Pen(Color.Red, 1);
                MouseEventArgs me = (MouseEventArgs)e;
                Point cursorPosition = me.Location;
                //Color cl = pd.bitmap.GetPixel(cursorPosition.X, cursorPosition.Y);
                pd.FillZone4(cursorPosition);

                pictureBox.Image = pd.bitmap;
                }

                if (fillmode == 2)
                {
                    Pen pen = new Pen(Color.Red, 1);
                    MouseEventArgs me = (MouseEventArgs)e;
                    Point cursorPosition = me.Location;
                    //Color cl = pd.bitmap.GetPixel(cursorPosition.X, cursorPosition.Y);
                    pd.FillZone44(cursorPosition);

                    pictureBox.Image = pd.bitmap;
                }
            }
            
        }


       


        private void drawButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.Transparent);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            graphics.FillRectangle(myBrush, 0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Image = pd.bitmap;
            pd.DrawPol(points.ToArray(), graphics);
            pictureBox.Image = pd.bitmap;
            rotateButton.Enabled = true;
            scaleButton.Enabled = true;
            transferButton.Enabled = true;
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            points = Transformator.RotateFigure(points.ToArray(), new Point((int)rotateCenterX.Value, (int)rotateCenterY.Value), (double)degreesToRotate.Value);
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Red, 1);
            pd.DrawPol(points.ToArray(), graphics);
            pictureBox.Image = pd.bitmap;
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            points = Transformator.ScaleFigure(points.ToArray(), (double) scaleX.Value / 100, (double) scaleX.Value / 100);
            scaleX.Value = 0;
            scaleY.Value = 0;
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Red, 1);
            pd.DrawPol(points.ToArray(), graphics);
            pictureBox.Image = pd.bitmap;
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            points = Transformator.TransferFigure(points.ToArray(), (double)transferX.Value, (double)transferY.Value);
            transferX.Value = 0;
            transferY.Value = 0;
            graphics.Clear(Color.Transparent);
            Pen pen = new Pen(Color.Red, 1);
            pd.DrawPol(points.ToArray(), graphics);
            pictureBox.Image = pd.bitmap;
        }

        private void clearCurve_Click(object sender, EventArgs e)
        {
            points.Clear();
            rotateButton.Enabled = false;
            scaleButton.Enabled = false;
            transferButton.Enabled = false;
            drawButton.Enabled = false;
            graphics.Clear(Color.Transparent);
            pictureBox.Image = pd.bitmap;
        }

       

        private void fillButton_Click_1(object sender, EventArgs e)
        {
            if (fillmode == 0)
            {
                fillmode = 1;
            }
            else
            {
                fillmode = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fillmode == 0)
            {
                fillmode = 2;
            }
            else
            {
                fillmode = 0;
            }
        }
    }
}
