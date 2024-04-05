using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАИП._2лаба.Фигуры
{
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int l, int h)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.h = h;
        }

        public Rectangle()
        {
            x = 0;
            y = 0;
            l = 0;
            h = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, x, y, l, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
