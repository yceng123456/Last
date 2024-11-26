using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提示用戶輸入字串
            Console.WriteLine("請輸入一個字串:");
            string userInput = Console.ReadLine(); // 讀取用戶輸入

            // 使用 Copy 方法將用戶輸入的字串複製到另一個變數
            string copiedInput = string.Copy(userInput);

            // 輸出複製的字串
            Console.WriteLine("你輸入的字串是: " + copiedInput);

            // 將複製的字串轉換為大寫
            string upperCaseInput = copiedInput.ToUpper();
            Console.WriteLine("轉換為大寫後的字串: " + upperCaseInput);
        }
    }
}
