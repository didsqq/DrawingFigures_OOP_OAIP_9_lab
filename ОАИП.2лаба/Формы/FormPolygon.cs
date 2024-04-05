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
    public partial class FormPolygon : Form
    {
        public FormPolygon()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x)
                 && int.TryParse(textBoxY.Text, out int y)
                 && int.TryParse(textBoxW.Text, out int w)
                 && int.TryParse(textBoxU.Text, out int n)
                 && int.TryParse(textBoxZ.Text, out int z))
            {
                if (x + w < Init.pictureBox.Width && y + w < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    if(n != 0 && n != 1 && n != 2 && w >= 0)
                    {
                        Polygon polygon = new Polygon(x, y, w, n, z);
                        ShapeContainer.AddFigure(polygon);
                        Init.comboBox1.Items.Add("Многоугольник");
                        polygon.Draw();
                        Close();

                        textBoxX.Text = "";
                        textBoxY.Text = "";
                        textBoxW.Text = "";
                        textBoxU.Text = "";
                        textBoxZ.Text = "";
                    }
                    else
                    {
                        textBoxX.Text = "";
                        textBoxY.Text = "";
                        textBoxW.Text = "";
                        textBoxU.Text = "";
                        textBoxZ.Text = "";
                        MessageBox.Show("Неверное количество углов или ширина", "Ошибка", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    textBoxX.Text = "";
                    textBoxY.Text = "";
                    textBoxW.Text = "";
                    textBoxU.Text = "";
                    textBoxZ.Text = "";
                    MessageBox.Show("Выход за границы", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                textBoxX.Text = "";
                textBoxY.Text = "";
                textBoxW.Text = "";
                textBoxU.Text = "";
                textBoxZ.Text = "";
            }
        }
    }
}
