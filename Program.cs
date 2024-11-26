using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 系統內部存儲的密碼
            string storedPassword = "SecurePassword123";

            // 用戶輸入的密碼
            string userInputPassword = "securepassword123";

            // 使用 Compare() 方法比較密碼，這裡忽略大小寫的比較
            int result = string.Compare(storedPassword, userInputPassword, ignoreCase: true);

            // 判斷比較結果，並給出提示
            if (result == 0)
            {
                Console.WriteLine("密碼匹配，登錄成功！");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請再試一次！");
            }
        }
    }
}
