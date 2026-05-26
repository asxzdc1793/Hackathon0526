namespace ENV
{
    public partial class Form1 : Form
    {
        //F = 9/5 * C + 32
        //C = (F - 32) * 5/9
        public Form1()
        {
            InitializeComponent();
        }
        private void btnNum_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            textBox1.Text += btn.Text;
        }
        

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked) {
                MessageBox.Show("請先選擇轉換方式!!");
                return;
            }
            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("請輸入正確數字");
                return;
            }
            var input = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {
                var result = 9.0 / 5 * input + 32;
                label1.Text = $"結果: {input}°C = {result}°F";
            }
            else
            {
                var result = (input - 32) * 5.0 / 9;
                label1.Text = $"結果: {input}°F = {result}°C";
            }
        }
    }
}
