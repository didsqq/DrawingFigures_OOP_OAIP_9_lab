using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class Polygon : Figure
    {
        private int n;
        private double z;
        public Polygon(int x, int y, int l, int n, double z)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.n = n;
            this.z = z;
        }

        public Polygon()
        {
            x = 0;
            y = 0;
            l = 0;
            n = 0;
            z = 0;
        }
        public override void Draw()
        {
            double angle = 2 * Math.PI / n;
            double rotationAngle = z * Math.PI / 180.0;

            Point[] points = new Point[n];
            Graphics g = Graphics.FromImage(Init.bitmap);
            for (int i = 0; i < n; i++)
            {
                double currentAngle = i * angle + rotationAngle;
                points[i].X = (int)(x + Math.Cos(currentAngle) * l);
                points[i].Y = (int)(y + Math.Sin(currentAngle) * l);
            }

            g.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}

