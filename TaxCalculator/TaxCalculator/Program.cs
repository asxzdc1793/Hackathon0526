namespace TaxCalculator
{
    internal class Program
    {
        //中華民國的稅率級距表如下：
        //年收入
        //0 ~540,000 : 5%
        //年收入 540,001 ~  1,210,000 : 12%
        //年收入 1,210,001 ~  2,420,000 : 20%
        //年收入 2,420,001 ~  4,530,000 : 30%
        //年收入 4,530,001 ~ 10,310,000 : 40%
        //年收入 10,310,001~            : 50%
        //撰寫一個程式可以輸入年收入，然後依照上面的公式
        //計算應繳納稅額。請使用 Decimal。

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("請輸入您的年收入金額:（輸入 end 結束）");
                var input = Console.ReadLine();
                if (input?.ToLower() == "end") break;
                if (!decimal.TryParse(input, out var income))
                {
                    Console.WriteLine("輸入格式錯誤，請重新輸入");
                    continue;
                }
                var brackets = new (decimal limit, decimal rate)[]
                {
                    (540_000,          0.05m),
                    (1_210_000,        0.12m),
                    (2_420_000,        0.20m),
                    (4_530_000,        0.30m),
                    (10_310_000,       0.40m),
                    (decimal.MaxValue, 0.50m),
                };

                var tax = 0m;
                var prev = 0m;

                foreach (var (limit, rate) in brackets)
                {
                    if (income <= prev) break;
                    var taxable = Math.Min(income, limit) - prev;
                    tax += taxable * rate;
                    prev = limit;
                }

                Console.WriteLine($"應繳稅額：{tax:N2} 元\n");
            }
        }
    }
}
