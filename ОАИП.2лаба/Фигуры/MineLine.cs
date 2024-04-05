using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class MineLine : Figure
    {
        private float x2;
        private float y2;
        private int x1;
        private int y1;
        public MineLine(int x1, int y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public MineLine()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawLine(Init.pen, x1, y1, x2, y2);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y, int index)
        {
            if (!(x1 + x < 0 && y1 + y < 0
                || y1 + y < 0
                || x1 + x > Init.pictureBox.Width && y1 + y < 0
                || x1 + l + x > Init.pictureBox.Width
                || x1 + x > Init.pictureBox.Width && y1 + y > Init.pictureBox.Height
                || y1 + h + y > Init.pictureBox.Height
                || x1 + x < 0 && y1 + y > Init.pictureBox.Height || x1 + x < 0))
            {
                x1 += x;
                y1 += y;
                x2 += x;
                y2 += y;    
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
