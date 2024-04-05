namespace ОАИП._2лаба
{
    partial class FormPolygon
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
            textBoxZ = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            textBoxW = new TextBox();
            textBoxU = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxZ);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxY);
            groupBox1.Controls.Add(textBoxX);
            groupBox1.Controls.Add(textBoxW);
            groupBox1.Controls.Add(textBoxU);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 220);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание фигуры";
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(113, 80);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(100, 23);
            textBoxZ.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 83);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 9;
            label5.Text = "Введите поворот";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 141);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Введите Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Введите X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = "Введите ширину";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 5;
            label1.Text = "Количество углов";
            // 
            // button1
            // 
            button1.Location = new Point(6, 167);
            button1.Name = "button1";
            button1.Size = new Size(207, 45);
            button1.TabIndex = 4;
            button1.Text = "Создать фигуру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(113, 138);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(113, 109);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxW
            // 
            textBoxW.Location = new Point(113, 51);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(100, 23);
            textBoxW.TabIndex = 1;
            // 
            // textBoxU
            // 
            textBoxU.Location = new Point(113, 22);
            textBoxU.Name = "textBoxU";
            textBoxU.Size = new Size(100, 23);
            textBoxU.TabIndex = 0;
            // 
            // FormPolygon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 238);
            Controls.Add(groupBox1);
            Name = "FormPolygon";
            Text = "Многоугольник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private TextBox textBoxW;
        private TextBox textBoxU;
        private TextBox textBoxZ;
        private Label label5;
    }
}