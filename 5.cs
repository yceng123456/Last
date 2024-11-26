using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\John\\Documents\\file.txt";

            // 定義要檢查的目錄
            string directoryToCheck = "C:\\Users\\John";

            // 使用 StartsWith() 判斷檔案路徑是否以指定目錄開頭
            bool result = filePath.StartsWith(directoryToCheck);

            // 根據結果生成輸出訊息
            string output;
            if (result)
            {
                output = "檔案路徑以 '" + directoryToCheck + "' 開頭";
            }
            else
            {
                output = "檔案路徑不以 '" + directoryToCheck + "' 開頭";
            }

            // 輸出結果
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
