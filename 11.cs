using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 定義商品名稱與其價格
            string productName = "Apple";
            double price = 1.99;

            // 使用 PadRight() 將商品名稱補齊到 15 個字元長度，並以 '-' 填充
            string formattedProductName = productName.PadRight(15, '-');

            // 格式化輸出
            string result = $"{formattedProductName} ${price:F2}";

            // 輸出結果
            Console.WriteLine(result);

            // 假設進一步儲存到報表檔案
            System.IO.File.AppendAllText("report.txt", result + Environment.NewLine);
            Console.WriteLine("格式化結果已追加至 report.txt");
        }
    }
}
