using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 定義兩個用戶名稱
            string user1 = "Charlie";
            string user2 = "Alice";

            // 比較用戶名稱，判斷哪一個排在前面
            int result = user1.CompareTo(user2);

            // 輸出比較結果
            if (result < 0)
            {
                Console.WriteLine($"{user1} 排在 {user2} 前面");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{user2} 排在 {user1} 前面");
            }
            else
            {
                Console.WriteLine("兩個用戶名稱相同");
            }

            // 另一種情況：對一個用戶名列表進行排序
            string[] userNames = { "Charlie", "Bob", "Alice" };

            // 使用 CompareTo() 方法進行排序
            Array.Sort(userNames);

            Console.WriteLine("\n按照字母順序排序後的用戶名稱：");
            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
