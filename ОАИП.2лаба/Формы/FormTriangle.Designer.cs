namespace ОАИП._2лаба
{
    partial class FormTriangle
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
            label1 = new Label();
            button1 = new Button();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            textBoxL = new TextBox();
            textBoxZ = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxZ);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxY);
            groupBox1.Controls.Add(textBoxX);
            groupBox1.Controls.Add(textBoxL);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 200);
            groupBox1.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "Введите длину ";
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
            // textBoxY
            // 
            textBoxY.Location = new Point(113, 109);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(113, 80);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxL
            // 
            textBoxL.Location = new Point(113, 22);
            textBoxL.Name = "textBoxL";
            textBoxL.Size = new Size(100, 23);
            textBoxL.TabIndex = 0;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(113, 51);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(100, 23);
            textBoxZ.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 10;
            label2.Text = "Введите Поворот";
            // 
            // FormTriangle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(groupBox1);
            Name = "FormTriangle";
            Text = "Треугольник";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button1;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private TextBox textBoxL;
        private Label label2;
        private TextBox textBoxZ;
    }
}