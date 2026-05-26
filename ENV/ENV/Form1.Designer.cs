namespace ENV
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            label1 = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ScrollBar;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(436, 331);
            btn1.Name = "btn1";
            btn1.Size = new Size(77, 69);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ScrollBar;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Location = new Point(533, 331);
            btn2.Name = "btn2";
            btn2.Size = new Size(77, 69);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ScrollBar;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Location = new Point(629, 331);
            btn3.Name = "btn3";
            btn3.Size = new Size(77, 69);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ScrollBar;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Location = new Point(629, 421);
            btn6.Name = "btn6";
            btn6.Size = new Size(77, 69);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ScrollBar;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Location = new Point(533, 421);
            btn5.Name = "btn5";
            btn5.Size = new Size(77, 69);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ScrollBar;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Location = new Point(436, 421);
            btn4.Name = "btn4";
            btn4.Size = new Size(77, 69);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ScrollBar;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Location = new Point(629, 509);
            btn9.Name = "btn9";
            btn9.Size = new Size(77, 69);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ScrollBar;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Location = new Point(533, 509);
            btn8.Name = "btn8";
            btn8.Size = new Size(77, 69);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ScrollBar;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Location = new Point(436, 509);
            btn7.Name = "btn7";
            btn7.Size = new Size(77, 69);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ScrollBar;
            btnDot.FlatStyle = FlatStyle.Flat;
            btnDot.Location = new Point(533, 599);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(77, 69);
            btnDot.TabIndex = 10;
            btnDot.Text = "．";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnNum_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ScrollBar;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Location = new Point(436, 599);
            btn0.Name = "btn0";
            btn0.Size = new Size(77, 69);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(803, 614);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 12;
            label1.Text = "結果：";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.ScrollBar;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Location = new Point(765, 514);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(188, 58);
            btnConvert.TabIndex = 13;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ScrollBar;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(1001, 514);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 58);
            btnClear.TabIndex = 14;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(765, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 46);
            textBox1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(12, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 248);
            panel1.TabIndex = 16;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(46, 140);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(264, 42);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "華氏轉換為攝氏";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(46, 65);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(264, 42);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "攝氏轉換為華氏";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2015, 1044);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(label1);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnDot;
        private Button btn0;
        private Label label1;
        private Button btnConvert;
        private Button btnClear;
        private TextBox textBox1;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}
