using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ОАИП._2лаба.Фигуры;

namespace ОАИП._2лаба
{
    public partial class FormEllips : Form
    {
        public FormEllips()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxRectX.Text, out int x)
                && int.TryParse(textBoxRectY.Text, out int y)
                && int.TryParse(textBoxL.Text, out int w)
                && int.TryParse(textBoxH.Text, out int h))
            {
                if (x + w < Init.pictureBox.Width && y + h < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    string name = "типа круг";
                    Ellipse ellips = new Ellipse(name, w, h, x, y);
                    ShapeContainer.AddFigure(ellips);
                    Init.comboBox1.Items.Add("Эллипс");
                    ellips.Draw();
                    Close();
                }
                else
                {
                    textBoxRectX.Text = "";
                    textBoxRectY.Text = "";
                    textBoxH.Text = "";
                    textBoxL.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxRectX.Text = "";
                textBoxRectY.Text = "";
                textBoxL.Text = "";
                textBoxH.Text = "";
            }
        }
    }
}
