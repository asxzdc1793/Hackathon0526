namespace replace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //使用 Console.ReadLine() 讀取一個整數 max
            //(至少大於 90)，在螢幕上用 WriteLine 分行顯示
            //1~max，其中可被 3 整除者替換為 Build，可被
            //5 整除者替換為 School，可以被 3 和 5 同時整
            //除者替換為 Dann
            Console.WriteLine("請輸入一個整數:");
            var input = int.Parse(Console.ReadLine());
            foreach (var i in Enumerable.Range(1, input))
            {
                Console.WriteLine(i % 15 == 0 ? "Dann" : i % 3 == 0 ? "Build" : i % 5 == 0 ? "School" : i.ToString());
            }
            Console.ReadLine();
        }
    }
}
