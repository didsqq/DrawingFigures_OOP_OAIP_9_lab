namespace ОАИП._2лаба
{
    partial class FormRectangle
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxRectY = new TextBox();
            textBoxRectX = new TextBox();
            textBoxW = new TextBox();
            textBoxH = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxRectY);
            groupBox1.Controls.Add(textBoxRectX);
            groupBox1.Controls.Add(textBoxW);
            groupBox1.Controls.Add(textBoxH);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание фигуры";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Введите Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
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
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Введите длину";
            // 
            // button1
            // 
            button1.Location = new Point(6, 139);
            button1.Name = "button1";
            button1.Size = new Size(207, 45);
            button1.TabIndex = 4;
            button1.Text = "Создать фигуру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxRectY
            // 
            textBoxRectY.Location = new Point(113, 109);
            textBoxRectY.Name = "textBoxRectY";
            textBoxRectY.Size = new Size(100, 23);
            textBoxRectY.TabIndex = 3;
            // 
            // textBoxRectX
            // 
            textBoxRectX.Location = new Point(113, 80);
            textBoxRectX.Name = "textBoxRectX";
            textBoxRectX.Size = new Size(100, 23);
            textBoxRectX.TabIndex = 2;
            // 
            // textBoxW
            // 
            textBoxW.Location = new Point(113, 51);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(100, 23);
            textBoxW.TabIndex = 1;
            // 
            // textBoxH
            // 
            textBoxH.Location = new Point(113, 22);
            textBoxH.Name = "textBoxH";
            textBoxH.Size = new Size(100, 23);
            textBoxH.TabIndex = 0;
            // 
            // FormRectangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(groupBox1);
            Name = "FormRectangle";
            Text = "Прямоугольник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxRectY;
        private TextBox textBoxRectX;
        private TextBox textBoxW;
        private TextBox textBoxH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}