using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 提示用戶輸入命令
            Console.WriteLine("請輸入命令：");
            string userInput = Console.ReadLine();

            // 將用戶輸入轉換為大寫
            string command = userInput.ToUpper();

            // 根據轉換後的命令進行處理
            if (command == "START")
            {
                Console.WriteLine("系統啟動中...");
            }
            else if (command == "STOP")
            {
                Console.WriteLine("系統停止中...");
            }
            else if (command == "EXIT")
            {
                Console.WriteLine("退出系統...");
            }
            else
            {
                Console.WriteLine("無效的命令！");
            }
        }
    }
}
