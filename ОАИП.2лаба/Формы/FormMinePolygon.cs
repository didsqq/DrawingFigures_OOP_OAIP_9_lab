using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОАИП._2лаба.Фигуры;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОАИП._2лаба
{
    public partial class FormMinePolygon : Form
    {

        private Point[] points;
        private int n;
        private int i = 0;
        public FormMinePolygon()
        {
            InitializeComponent();
            buttonDraw.Enabled = false;
            buttonCreatePoint.Enabled = false;
            n = 0;
            points = new Point[1];
        }
        private void buttonAcept_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumPoints.Text, out n))
            {
                points = new Point[n];
                buttonDraw.Enabled = true;
                buttonCreatePoint.Enabled = true;
                buttonAcept.Enabled = false;
            }
            else
            {
                textBoxNumPoints.Text = "";
            }
        }
        private void buttonCreatePoint_Click(object sender, EventArgs e)
        {
            CreatePoint();
        }
        private void CreatePoint()
        {

            if (int.TryParse(textBoxCoordX.Text, out int x) && int.TryParse(textBoxCoordY.Text, out int y))
            {
                if (x < Init.pictureBox.Width && y < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    points[i] = new Point(x, y);
                    textBoxCoordX.Text = "";
                    textBoxCoordY.Text = "";
                    i++;
                }
                else
                {
                    textBoxCoordX.Text = "";
                    textBoxCoordY.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxCoordX.Text = "";
                textBoxCoordY.Text = "";
            }
            if (i == n)
            {
                buttonCreatePoint.Enabled = false;
            }
        }
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            MinePolygon minepolygon = new MinePolygon(points, n);
            ShapeContainer.AddFigure(minepolygon);
            Init.comboBox1.Items.Add("Своя Фигура");
            minepolygon.Draw();
            Close();
        }
    }
}


