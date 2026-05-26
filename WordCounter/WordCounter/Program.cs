namespace WordCounter
{
    internal class Program
    {
        //輸入一個有意義的英文敘述字串，計算其個別單字數
        //量(不區分大小寫)，例如 “To be or not to be”，
        //會得到以下結果：
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入單字:");
            var words = Console.ReadLine().ToLower().Split(' ');
            var result = words.GroupBy(w => w)
                              .OrderByDescending(g => g.Count());
            foreach (var g in result) {
                Console.WriteLine($"{g.Key}: {g.Count()}");
            }
            Console.ReadLine();
        }
    }
}
