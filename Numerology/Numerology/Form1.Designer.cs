namespace Numerology
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            btnResult = new Button();
            label2 = new Label();
            lbResult = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 393);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(588, 46);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 275);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 1;
            label1.Text = "請選擇生日";
            // 
            // btnResult
            // 
            btnResult.Location = new Point(115, 554);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(339, 165);
            btnResult.TabIndex = 2;
            btnResult.Text = "分析結果";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(828, 275);
            label2.Name = "label2";
            label2.Size = new Size(107, 38);
            label2.TabIndex = 3;
            label2.Text = "關於你";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(828, 393);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(77, 38);
            lbResult.TabIndex = 4;
            lbResult.Text = "結果";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 1094);
            Controls.Add(lbResult);
            Controls.Add(label2);
            Controls.Add(btnResult);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "生命靈數";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button btnResult;
        private Label label2;
        private Label lbResult;
    }
}
