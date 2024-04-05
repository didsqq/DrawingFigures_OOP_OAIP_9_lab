using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class MinePolygon : Figure
    {
        private Point[] points;
        private int n;
        public MinePolygon(Point[] point , int n)
        {
            points = point;
            this.n = n;
        }
        public MinePolygon()
        {
            points = new Point[1];
        }
        public override void Draw()
        {
            Graphics graphics = Graphics.FromImage(Init.bitmap);
            graphics.DrawPolygon(Init.pen, points);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y, int index)
        {
            if (!(this.x + x < 0 && this.y + y < 0
                || this.y + y < 0
                || this.x + x > Init.pictureBox.Width && this.y + y < 0
                || this.x + l + x > Init.pictureBox.Width
                || this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height
                || this.y + h + y > Init.pictureBox.Height
                || this.x + x < 0 && this.y + y > Init.pictureBox.Height || this.x + x < 0))
            {
                for (int i = 0; i < n; i++)
                {
                    points[i].X += x;
                    points[i].Y += y;
                }
                this.x += x;
                this.y += y;
                DeleteF(this, false, index);
                Draw();
            }
            else
            {
                MessageBox.Show("Выход за границы");
            }
        }
    }
}
