namespace Numerology
{
    public partial class Form1 : Form
    {
        //設計一個使用西元生日計算生命靈數，並依據其星座
        //給予評論的程式，請使用 DateTimePicker 作為日
        //期輸入使用
        //生命靈數的計算方式(1980年8月16日)：
        //生命靈數就是
        //1＋9＋8＋0＋8＋1＋6=33
        //3＋3=6
        //結果為 6 (這個可能會用到遞迴運算
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            var analyzer = new Analyzer();
            var date = dateTimePicker1.Value;
            var sum = (date.Year.ToString() + date.Month.ToString() + date.Day.ToString())
                      .Sum(c => c - '0');
            var lifePathNum = analyzer.CalcLifePath(sum);
            var zodiac = analyzer.GetZodiac(date.Month, date.Day);
            var comment = analyzer.GetComment(zodiac, lifePathNum);
            lbResult.Text = $"你的星座是 {zodiac}\n你的生命靈數 {lifePathNum}：{comment}";
        }
    }
}
