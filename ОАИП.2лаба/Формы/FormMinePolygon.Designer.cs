namespace ОАИП._2лаба
{
    partial class FormMinePolygon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonAcept = new Button();
            textBoxCoordY = new TextBox();
            textBoxCoordX = new TextBox();
            textBoxNumPoints = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonCreatePoint = new Button();
            buttonDraw = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAcept);
            groupBox1.Controls.Add(textBoxCoordY);
            groupBox1.Controls.Add(textBoxCoordX);
            groupBox1.Controls.Add(textBoxNumPoints);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonCreatePoint);
            groupBox1.Controls.Add(buttonDraw);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание фигуры";
            // 
            // buttonAcept
            // 
            buttonAcept.Location = new Point(6, 51);
            buttonAcept.Name = "buttonAcept";
            buttonAcept.Size = new Size(219, 23);
            buttonAcept.TabIndex = 8;
            buttonAcept.Text = "Подтвердить";
            buttonAcept.UseVisualStyleBackColor = true;
            buttonAcept.Click += buttonAcept_Click;
            // 
            // textBoxCoordY
            // 
            textBoxCoordY.Location = new Point(125, 112);
            textBoxCoordY.Name = "textBoxCoordY";
            textBoxCoordY.Size = new Size(100, 23);
            textBoxCoordY.TabIndex = 7;
            // 
            // textBoxCoordX
            // 
            textBoxCoordX.Location = new Point(125, 83);
            textBoxCoordX.Name = "textBoxCoordX";
            textBoxCoordX.Size = new Size(100, 23);
            textBoxCoordX.TabIndex = 6;
            // 
            // textBoxNumPoints
            // 
            textBoxNumPoints.Location = new Point(125, 16);
            textBoxNumPoints.Name = "textBoxNumPoints";
            textBoxNumPoints.Size = new Size(100, 23);
            textBoxNumPoints.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 115);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 4;
            label3.Text = "Координата Y:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Координата X:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 2;
            label1.Text = "Кол-во точек";
            // 
            // buttonCreatePoint
            // 
            buttonCreatePoint.Location = new Point(6, 141);
            buttonCreatePoint.Name = "buttonCreatePoint";
            buttonCreatePoint.Size = new Size(219, 23);
            buttonCreatePoint.TabIndex = 1;
            buttonCreatePoint.Text = "Добавить точку";
            buttonCreatePoint.UseVisualStyleBackColor = true;
            buttonCreatePoint.Click += buttonCreatePoint_Click;
            // 
            // buttonDraw
            // 
            buttonDraw.Location = new Point(6, 170);
            buttonDraw.Name = "buttonDraw";
            buttonDraw.Size = new Size(219, 23);
            buttonDraw.TabIndex = 0;
            buttonDraw.Text = "Нарисовать полигон";
            buttonDraw.UseVisualStyleBackColor = true;
            buttonDraw.Click += buttonDraw_Click;
            // 
            // FormMinePolygon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 218);
            Controls.Add(groupBox1);
            Name = "FormMinePolygon";
            Text = "Многоугольник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonCreatePoint;
        private Button buttonDraw;
        private TextBox textBoxCoordY;
        private TextBox textBoxCoordX;
        private TextBox textBoxNumPoints;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonAcept;
    }
}