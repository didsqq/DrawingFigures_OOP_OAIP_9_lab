using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using ОАИП._2лаба.Фигуры;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОАИП._2лаба
{
    public partial class Form1 : Form
    {

        private Bitmap bitmap;
        private Pen pen = new Pen(Color.Black, 5);
        private ListBox listBox = new ListBox();

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pen = new Pen(Color.Black, 5);
            Init.bitmap = bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = pen;
            Init.comboBox1 = comboBox1;
            pictureBox1.BackColor = Color.White;
            Init.listBox = listBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCoordX.Text, out int startX)
                && int.TryParse(textBoxCoordY.Text, out int startY)
                && float.TryParse(textBoxL.Text, out float length)
                && float.TryParse(textBoxU.Text, out float angleInDegrees))
            {
                if (startX + length < Init.pictureBox.Width && startY + length < Init.pictureBox.Height && startX > 0 && startY > 0)
                {
                    float angleInRadians = angleInDegrees * (float)Math.PI / 180.0f;
                    float endX = startX + length * (float)Math.Cos(angleInRadians);
                    float endY = startY + length * (float)Math.Sin(angleInRadians);

                    MineLine line = new MineLine(startX, startY, endX, endY);
                    ShapeContainer.AddFigure(line);
                    line.Draw();
                    comboBox1.Items.Add("Линия");

                    textBoxCoordX.Text = "";
                    textBoxCoordY.Text = "";
                    textBoxL.Text = "";
                    textBoxU.Text = "";
                }
                else
                {
                    textBoxCoordX.Text = "";
                    textBoxCoordY.Text = "";
                    textBoxL.Text = "";
                    textBoxU.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxCoordX.Text = "";
                textBoxCoordY.Text = "";
                textBoxL.Text = "";
                textBoxU.Text = "";
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            Figure.DeleteF(ShapeContainer.figureList[comboBox1.SelectedIndex]);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Text = "";
        }
        private void ButtonMoveTo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNewCoordX.Text, out int x)
               && int.TryParse(textBoxNewCoordY.Text, out int y))
            {
                ShapeContainer.figureList[comboBox1.SelectedIndex].MoveTo(x, y, comboBox1.SelectedIndex);
                textBoxNewCoordX.Text = "";
                textBoxNewCoordY.Text = "";
            }
            else
            {
                textBoxNewCoordX.Text = "";
                textBoxNewCoordY.Text = "";
            }
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            FormRectangle rectangle = new FormRectangle();
            rectangle.ShowDialog();
        }
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            FormSquare square = new FormSquare();
            square.ShowDialog();
        }

        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            FormPolygon polygon = new FormPolygon();
            polygon.ShowDialog();
        }

        private void buttonMinePolygon_Click(object sender, EventArgs e)
        {
            FormMinePolygon minepolygon = new FormMinePolygon();
            minepolygon.ShowDialog();
        }

        private void buttonRocket_Click(object sender, EventArgs e)
        {
            FormRocket rocket = new FormRocket();
            rocket.ShowDialog();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            FormTriangle triangle = new FormTriangle();
            triangle.ShowDialog();
        }

        private void buttonEllips_Click(object sender, EventArgs e)
        {
            FormEllips ellips = new FormEllips();
            ellips.ShowDialog();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            FormCircle circle = new FormCircle();
            circle.ShowDialog();
        }

        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string expression = textBoxInputString.Text;
                if (ReversePolishNotation.CalculateRPN(expression)) 
                {
                    Init.listBox.Items.Add(expression + " - выполнено");
                }
                else
                {
                    Init.listBox.Items.Add(expression + " - ошибка");
                }
                textBoxInputString.Text = "";
            }
        }
        private void buttonRemoveEl_Click(object sender, EventArgs e)
        {
            buttonRemoveEl.Click += new EventHandler(button_click);
            Controls.Remove(groupBox1);
            Controls.Remove(groupBox2);
            Controls.Remove(groupBox3);

            Init.listBox.Location = new Point(626, 149);
            Init.listBox.Size = new Size(295, 720);
            Controls.Add(Init.listBox);
            buttonRemoveEl.Text = "Вернуть все элементы";
        }
        private void button_click(object sender, EventArgs e)
        {
            buttonRemoveEl.Click += new EventHandler(buttonRemoveEl_Click);
            Controls.Remove(Init.listBox);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
        }
    }
}