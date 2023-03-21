namespace IBiZ3
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label10 = new Label();
            button8 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            button4 = new Button();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(8, 173);
            button1.Name = "button1";
            button1.Size = new Size(195, 29);
            button1.TabIndex = 4;
            button1.Text = "Выбрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(5, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 93);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 2;
            label1.Text = "Шифрование:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Enabled = false;
            label10.Location = new Point(208, 60);
            label10.Name = "label10";
            label10.Size = new Size(195, 20);
            label10.TabIndex = 15;
            label10.Text = "Дешифрование:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            button8.Location = new Point(209, 259);
            button8.Name = "button8";
            button8.Size = new Size(194, 29);
            button8.TabIndex = 13;
            button8.Text = "Дешифровать";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 173);
            button2.Name = "button2";
            button2.Size = new Size(194, 29);
            button2.TabIndex = 11;
            button2.Text = "Выбрать файл";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(8, 259);
            button3.Name = "button3";
            button3.Size = new Size(194, 29);
            button3.TabIndex = 7;
            button3.Text = "Шифровать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 108);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 93);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(5, 108);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 60);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(208, 108);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 60);
            textBox4.TabIndex = 9;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(5, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(197, 27);
            textBox5.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(11, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(147, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Работа с текстом";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(165, 12);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(156, 24);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Работа с файлами";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.Enabled = false;
            label2.Location = new Point(7, 80);
            label2.Name = "label2";
            label2.Size = new Size(391, 25);
            label2.TabIndex = 31;
            label2.Text = "Введите текст:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Enabled = false;
            label3.Location = new Point(5, 205);
            label3.Name = "label3";
            label3.Size = new Size(397, 25);
            label3.TabIndex = 32;
            label3.Text = "Введите ключ:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.ButtonHighlight;
            textBox7.Location = new Point(7, 293);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(194, 152);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.BackColor = SystemColors.ButtonHighlight;
            textBox8.Location = new Point(209, 293);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(194, 152);
            textBox8.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(209, 225);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(194, 27);
            textBox6.TabIndex = 12;
            // 
            // label4
            // 
            label4.Enabled = false;
            label4.Location = new Point(12, 449);
            label4.Name = "label4";
            label4.Size = new Size(390, 25);
            label4.TabIndex = 37;
            label4.Text = "Доп. параметр";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 478);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Вывод в файл";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(336, 451);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(68, 60);
            button4.TabIndex = 17;
            button4.Text = "Выбрать файл";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(138, 451);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(192, 59);
            textBox9.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 516);
            Controls.Add(textBox9);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox6);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Квадрат Полибия";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label10;
        private Button button8;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox6;
        private Label label4;
        private CheckBox checkBox1;
        private Button button4;
        private TextBox textBox9;
    }
}