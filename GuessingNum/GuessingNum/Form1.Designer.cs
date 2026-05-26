namespace GuessingNum
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
            btnStart = new Button();
            btnAns = new Button();
            btnCheck = new Button();
            btnRestart = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ControlLight;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(78, 153);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(206, 81);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnAns
            // 
            btnAns.BackColor = SystemColors.ControlLight;
            btnAns.FlatStyle = FlatStyle.Flat;
            btnAns.Location = new Point(78, 325);
            btnAns.Name = "btnAns";
            btnAns.Size = new Size(206, 81);
            btnAns.TabIndex = 1;
            btnAns.Text = "看答案";
            btnAns.UseVisualStyleBackColor = false;
            btnAns.Click += btnAns_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ControlLight;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Location = new Point(78, 753);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(206, 81);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = SystemColors.ControlLight;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnRestart.Location = new Point(336, 753);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(206, 81);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "放棄重來";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 578);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 4;
            label1.Text = "輸入";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(78, 636);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 46);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 96);
            label2.Name = "label2";
            label2.Size = new Size(137, 38);
            label2.TabIndex = 7;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(568, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(530, 688);
            listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 944);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(btnRestart);
            Controls.Add(btnCheck);
            Controls.Add(btnAns);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnAns;
        private Button btnCheck;
        private Button btnRestart;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listBox1;
    }
}
