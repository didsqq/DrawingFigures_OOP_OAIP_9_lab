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
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x)
                && int.TryParse(textBoxY.Text, out int y)
                && int.TryParse(textBoxW.Text, out int w)) 
            {
                if (x + w < Init.pictureBox.Width && y + w < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    Circle circle = new Circle(x, y, w, "");
                    ShapeContainer.AddFigure(circle);
                    Init.comboBox1.Items.Add("Круг");
                    circle.Draw();
                    Close();
                }
                else
                {
                    textBoxX.Text = "";
                    textBoxY.Text = "";
                    textBoxW.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxX.Text = "";
                textBoxY.Text = "";
                textBoxW.Text = "";
            }
        }
    }
}
