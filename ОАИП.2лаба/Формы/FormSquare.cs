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
    public partial class FormSquare : Form
    {
        public FormSquare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRectX.Text, out int x)
                && int.TryParse(textBoxRectY.Text, out int y)
                && int.TryParse(textBoxH.Text, out int w))
            {
                if (x + w < Init.pictureBox.Width && y + w < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    Square square = new Square(x, y, w);
                    ShapeContainer.AddFigure(square);
                    Init.comboBox1.Items.Add("Квадрат");
                    square.Draw();
                    Close();
                }
                else
                {
                    textBoxRectX.Text = "";
                    textBoxRectY.Text = "";
                    textBoxH.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxRectX.Text = "";
                textBoxRectY.Text = "";
                textBoxH.Text = "";
            }

        }
    }
}
