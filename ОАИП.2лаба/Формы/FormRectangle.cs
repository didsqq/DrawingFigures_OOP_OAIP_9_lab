using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОАИП._2лаба.Фигуры;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОАИП._2лаба
{
    public partial class FormRectangle : Form
    {
        public FormRectangle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRectX.Text, out int x)
                 && int.TryParse(textBoxRectY.Text, out int y)
                 && int.TryParse(textBoxW.Text, out int w)
                 && int.TryParse(textBoxH.Text, out int h))
            {
                if (x + w < Init.pictureBox.Width && y + h < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    Фигуры.Rectangle rectangle = new Фигуры.Rectangle(x, y, w, h);
                    ShapeContainer.AddFigure(rectangle);
                    Init.comboBox1.Items.Add("Прямоугольник");
                    rectangle.Draw();
                    Close();
                }
                else
                {
                    textBoxRectX.Text = "";
                    textBoxRectY.Text = "";
                    textBoxW.Text = "";
                    textBoxH.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxRectX.Text = "";
                textBoxRectY.Text = "";
                textBoxW.Text = "";
                textBoxH.Text = "";
            }            
        }
    }
}
