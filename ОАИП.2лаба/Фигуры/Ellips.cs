using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП._2лаба.Фигуры
{
    internal class Ellipse : Figure
    {
        public string name;
        public Ellipse(string name, int l, int h, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.h = h;
            this.name = name;
        }

        public Ellipse()
        {
            x = 0;
            y = 0;
            l = 0;
            h = 0;
            name = "";
        }
        public override void Draw()
        {
            Graphics.FromImage((Image)Init.bitmap).DrawEllipse(Init.pen, x, y, l, h);
            Init.pictureBox.Image = (Image)Init.bitmap;
        }

        public bool EllipseDraw()
        {
            if (x + l < Init.pictureBox.Width && y + h < Init.pictureBox.Height && x > 0 && y > 0) { 
                Graphics.FromImage((Image)Init.bitmap).DrawEllipse(Init.pen, x, y, l, h);
                Init.pictureBox.Image = (Image)Init.bitmap;
                return true;
            }
            else { return false; }
        }

        public static void EllipseDeleteF(Figure figure, bool flag = true, int ind = 0)
        {
            if (flag)
            {
                Graphics graphics = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                graphics.Clear(Color.White);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure figure1 in ShapeContainer.figureList)
                    figure1.Draw();
                foreach (Figure figure1 in ShapeContainer.figureListRPN)
                    figure1.Draw();
            }
            else
            {
                Graphics graphics = Graphics.FromImage(Init.bitmap);
                ShapeContainer.figureList.Remove(figure);
                graphics.Clear(Color.White);
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure figure2 in ShapeContainer.figureList)
                    figure2.Draw();
                foreach (Figure figure1 in ShapeContainer.figureListRPN)
                    figure1.Draw();
                ShapeContainer.figureListRPN.Insert(ind, figure);
            }
        }
        public bool EllipseMoveTo(int x, int y, int index)
        {
            if (!(this.x + x < 0 && this.y + y < 0
            || this.y + y < 0
            || this.x + x > Init.pictureBox.Width && this.y + y < 0
            || this.x + l + x > Init.pictureBox.Width
            || this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height
            || this.y + h + y > Init.pictureBox.Height
            || this.x + x < 0 && this.y + y > Init.pictureBox.Height || this.x + x < 0))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false, index);
                Draw();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
