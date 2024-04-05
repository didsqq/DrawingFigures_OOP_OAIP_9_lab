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
    public partial class FormRocket : Form
    {
        public FormRocket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x)
                 && int.TryParse(textBoxY.Text, out int y)
                 && int.TryParse(textBoxL.Text, out int l)
                 && int.TryParse(textBoxH.Text, out int h))
            {
                if (x + l < Init.pictureBox.Width && y + h < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    Rocket rocket = new Rocket(x, y, l, h);
                    ShapeContainer.AddFigure(rocket);
                    Init.comboBox1.Items.Add("Ракета");
                    rocket.Draw();
                    Close();
                }
                else
                {
                    textBoxX.Text = "";
                    textBoxY.Text = "";
                    textBoxL.Text = "";
                    textBoxH.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxX.Text = "";
                textBoxY.Text = "";
                textBoxL.Text = "";
                textBoxH.Text = "";
            }
        }
    }
}
