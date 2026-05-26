namespace GuessingNum
{
    public partial class Form1 : Form
    {
        //電腦從 0~9 亂數挑選 4 的不重複的數字，讓使用
        //者猜。
        //如果玩家猜測的某一個數字和電腦挑選的相同，但順
        //序不同，則以 B 表示；若是該數字連順序都相同則
        //以 A 表示。4A 及代表遊戲成功結束。
        //例如：電腦挑出的數字為 5461
        //玩家猜 5038，則為 1A0B
        //玩家猜 5048，則為 1A1B
        //玩家猜 9872，則為 0A0B
        List<int> answer = new();
        Random rnd = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            answer = Enumerable.Range(0, 10)
                    .OrderBy(_ => rnd.Next())
                    .Take(4)
                    .ToList();
            listBox1.Items.Clear();
            textBox1.Clear();
            listBox1.Items.Add("遊戲開始！請輸入4個數字");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 4 || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("請輸入4個數字！");
                return;
            }
            var guess = textBox1.Text.Select(c => int.Parse(c.ToString())).ToList();
            var A = Enumerable.Range(0, 4).Count(i => guess[i] == answer[i]);
            var B = guess.Intersect(answer).Count() - A;
            listBox1.Items.Add($"{textBox1.Text} → {A}A{B}B");

            if (A == 4)
                MessageBox.Show("過關！");
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("", answer));
        }
    }
}
