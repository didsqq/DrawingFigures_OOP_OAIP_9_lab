using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОАИП._2лаба.Фигуры
{
    abstract public class Figure
    {
        public Pen pen = new Pen(Color.Black, 5f);
        public int x;
        public int y;
        public int l;
        public int h;

        abstract public void Draw();
        public virtual void MoveTo(int x, int y, int index)
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
            }
            else
            {
                MessageBox.Show("Выход за границы");
            }

        }
        public static void DeleteF(Figure figure, bool flag = true, int ind = 0)
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
                ShapeContainer.figureList.Insert(ind, figure);
                foreach (Figure figure1 in ShapeContainer.figureListRPN)
                    figure1.Draw();
            }
        }

        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
