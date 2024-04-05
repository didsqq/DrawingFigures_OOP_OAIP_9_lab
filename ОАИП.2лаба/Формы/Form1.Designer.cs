namespace ОАИП._2лаба
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            textBoxU = new TextBox();
            textBoxL = new TextBox();
            button1 = new Button();
            textBoxCoordY = new TextBox();
            label2 = new Label();
            textBoxCoordX = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonPolygon = new Button();
            buttonEllips = new Button();
            buttonRocket = new Button();
            buttonCircle = new Button();
            buttonTriangle = new Button();
            buttonMinePolygon = new Button();
            buttonSquare = new Button();
            buttonRectangle = new Button();
            groupBox3 = new GroupBox();
            ButtonMoveTo = new Button();
            ButtonDelete = new Button();
            textBoxNewCoordY = new TextBox();
            textBoxNewCoordX = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBoxInputString = new TextBox();
            groupBox4 = new GroupBox();
            buttonRemoveEl = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 636);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxU);
            groupBox1.Controls.Add(textBoxL);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxCoordY);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCoordX);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(548, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 139);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Рисование линии";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(137, 63);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 8;
            label7.Text = "Введите угол";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 19);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 7;
            label6.Text = "Введите Длину";
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(137, 81);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(112, 23);
            textBoxU.TabIndex = 6;
            // 
            // textBoxL
            // 
            textBoxL.Location = new Point(137, 37);
            textBoxL.Name = "textBoxL";
            textBoxL.Size = new Size(112, 23);
            textBoxL.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(6, 110);
            button1.Name = "button1";
            button1.Size = new Size(243, 23);
            button1.TabIndex = 4;
            button1.Text = "Нарисовать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxCoordY
            // 
            textBoxCoordY.Location = new Point(6, 81);
            textBoxCoordY.Name = "textBoxCoordY";
            textBoxCoordY.Size = new Size(112, 23);
            textBoxCoordY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Введите Y";
            // 
            // textBoxCoordX
            // 
            textBoxCoordX.Location = new Point(6, 37);
            textBoxCoordX.Name = "textBoxCoordX";
            textBoxCoordX.Size = new Size(112, 23);
            textBoxCoordX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите X";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonPolygon);
            groupBox2.Controls.Add(buttonEllips);
            groupBox2.Controls.Add(buttonRocket);
            groupBox2.Controls.Add(buttonCircle);
            groupBox2.Controls.Add(buttonTriangle);
            groupBox2.Controls.Add(buttonMinePolygon);
            groupBox2.Controls.Add(buttonSquare);
            groupBox2.Controls.Add(buttonRectangle);
            groupBox2.Location = new Point(548, 257);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 200);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Рисование Фигуры";
            // 
            // buttonPolygon
            // 
            buttonPolygon.Location = new Point(6, 66);
            buttonPolygon.Name = "buttonPolygon";
            buttonPolygon.Size = new Size(112, 38);
            buttonPolygon.TabIndex = 7;
            buttonPolygon.Text = "Многоугольник";
            buttonPolygon.UseVisualStyleBackColor = true;
            buttonPolygon.Click += buttonPolygon_Click;
            // 
            // buttonEllips
            // 
            buttonEllips.Location = new Point(6, 154);
            buttonEllips.Name = "buttonEllips";
            buttonEllips.Size = new Size(112, 38);
            buttonEllips.TabIndex = 6;
            buttonEllips.Text = "Эллипс";
            buttonEllips.UseVisualStyleBackColor = true;
            buttonEllips.Click += buttonEllips_Click;
            // 
            // buttonRocket
            // 
            buttonRocket.Location = new Point(137, 110);
            buttonRocket.Name = "buttonRocket";
            buttonRocket.Size = new Size(112, 38);
            buttonRocket.TabIndex = 5;
            buttonRocket.Text = "Ракета";
            buttonRocket.UseVisualStyleBackColor = true;
            buttonRocket.Click += buttonRocket_Click;
            // 
            // buttonCircle
            // 
            buttonCircle.Location = new Point(6, 110);
            buttonCircle.Name = "buttonCircle";
            buttonCircle.Size = new Size(112, 38);
            buttonCircle.TabIndex = 4;
            buttonCircle.Text = "Круг";
            buttonCircle.UseVisualStyleBackColor = true;
            buttonCircle.Click += buttonCircle_Click;
            // 
            // buttonTriangle
            // 
            buttonTriangle.Location = new Point(137, 66);
            buttonTriangle.Name = "buttonTriangle";
            buttonTriangle.Size = new Size(112, 38);
            buttonTriangle.TabIndex = 3;
            buttonTriangle.Text = "Треугольник";
            buttonTriangle.UseVisualStyleBackColor = true;
            buttonTriangle.Click += buttonTriangle_Click;
            // 
            // buttonMinePolygon
            // 
            buttonMinePolygon.Location = new Point(137, 154);
            buttonMinePolygon.Name = "buttonMinePolygon";
            buttonMinePolygon.Size = new Size(112, 38);
            buttonMinePolygon.TabIndex = 2;
            buttonMinePolygon.Text = "Своя фигура";
            buttonMinePolygon.UseVisualStyleBackColor = true;
            buttonMinePolygon.Click += buttonMinePolygon_Click;
            // 
            // buttonSquare
            // 
            buttonSquare.Location = new Point(137, 22);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(112, 38);
            buttonSquare.TabIndex = 1;
            buttonSquare.Text = "Квадрат";
            buttonSquare.UseVisualStyleBackColor = true;
            buttonSquare.Click += buttonSquare_Click;
            // 
            // buttonRectangle
            // 
            buttonRectangle.Location = new Point(6, 22);
            buttonRectangle.Name = "buttonRectangle";
            buttonRectangle.Size = new Size(112, 38);
            buttonRectangle.TabIndex = 0;
            buttonRectangle.Text = "Прямоугольник";
            buttonRectangle.UseVisualStyleBackColor = true;
            buttonRectangle.Click += buttonRectangle_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ButtonMoveTo);
            groupBox3.Controls.Add(ButtonDelete);
            groupBox3.Controls.Add(textBoxNewCoordY);
            groupBox3.Controls.Add(textBoxNewCoordX);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(548, 463);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(258, 185);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Взаимодействие с фигурами";
            // 
            // ButtonMoveTo
            // 
            ButtonMoveTo.Location = new Point(6, 115);
            ButtonMoveTo.Name = "ButtonMoveTo";
            ButtonMoveTo.Size = new Size(243, 29);
            ButtonMoveTo.TabIndex = 8;
            ButtonMoveTo.Text = "Переместить";
            ButtonMoveTo.UseVisualStyleBackColor = true;
            ButtonMoveTo.Click += ButtonMoveTo_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(6, 150);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(243, 29);
            ButtonDelete.TabIndex = 7;
            ButtonDelete.Text = "Удалить";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // textBoxNewCoordY
            // 
            textBoxNewCoordY.Location = new Point(137, 80);
            textBoxNewCoordY.Name = "textBoxNewCoordY";
            textBoxNewCoordY.Size = new Size(112, 23);
            textBoxNewCoordY.TabIndex = 5;
            // 
            // textBoxNewCoordX
            // 
            textBoxNewCoordX.Location = new Point(137, 51);
            textBoxNewCoordX.Name = "textBoxNewCoordX";
            textBoxNewCoordX.Size = new Size(112, 23);
            textBoxNewCoordX.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 3;
            label5.Text = "Выберите Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 2;
            label4.Text = "Выберите X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 25);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 1;
            label3.Text = "Выберите фигуру";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 23);
            comboBox1.TabIndex = 0;
            // 
            // textBoxInputString
            // 
            textBoxInputString.Location = new Point(6, 22);
            textBoxInputString.Name = "textBoxInputString";
            textBoxInputString.Size = new Size(243, 23);
            textBoxInputString.TabIndex = 9;
            textBoxInputString.KeyDown += textBoxInputString_KeyDown;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonRemoveEl);
            groupBox4.Controls.Add(textBoxInputString);
            groupBox4.Location = new Point(548, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(258, 100);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "ОПЗ";
            // 
            // buttonRemoveEl
            // 
            buttonRemoveEl.Location = new Point(6, 51);
            buttonRemoveEl.Name = "buttonRemoveEl";
            buttonRemoveEl.Size = new Size(243, 29);
            buttonRemoveEl.TabIndex = 9;
            buttonRemoveEl.Text = "Удалить все элементы";
            buttonRemoveEl.UseVisualStyleBackColor = true;
            buttonRemoveEl.Click += buttonRemoveEl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 660);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private TextBox textBoxCoordY;
        private Label label2;
        private TextBox textBoxCoordX;
        private GroupBox groupBox2;
        private Button buttonPolygon;
        private Button buttonEllips;
        private Button buttonRocket;
        private Button buttonCircle;
        private Button buttonTriangle;
        private Button buttonMinePolygon;
        private Button buttonSquare;
        private Button buttonRectangle;
        private GroupBox groupBox3;
        private Button ButtonMoveTo;
        private Button ButtonDelete;
        private TextBox textBoxNewCoordY;
        private TextBox textBoxNewCoordX;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private TextBox textBoxU;
        private TextBox textBoxL;
        private TextBox textBoxInputString;
        private GroupBox groupBox4;
        private Button buttonRemoveEl;
    }
}