namespace ОАИП._2лаба
{
    partial class FormCircle
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
            textBoxW = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxY);
            groupBox1.Controls.Add(textBoxX);
            groupBox1.Controls.Add(textBoxW);
            groupBox1.Location = new Point(7, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание фигуры";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Введите Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 54);
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
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Введите ширину";
            // 
            // button1
            // 
            button1.Location = new Point(5, 109);
            button1.Name = "button1";
            button1.Size = new Size(207, 45);
            button1.TabIndex = 4;
            button1.Text = "Создать фигуру";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(113, 80);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(100, 23);
            textBoxY.TabIndex = 3;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(113, 51);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 2;
            // 
            // textBoxW
            // 
            textBoxW.Location = new Point(113, 22);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(100, 23);
            textBoxW.TabIndex = 0;
            // 
            // FormCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 176);
            Controls.Add(groupBox1);
            Name = "FormCircle";
            Text = "FormCircle";
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
        private TextBox textBoxW;
    }
}