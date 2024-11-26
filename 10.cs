using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 假設我們有一個員工編號清單，並希望所有編號都是6位數，不足的前面補0
            string[] employeeIds = { "7", "45", "123", "4567" };

            // 遍歷每個員工編號
            foreach (string id in employeeIds)
            {
                // 將編號補足為6位數，左邊用'0'填充
                string formattedId = id.PadLeft(6, '0');

                // 輸出結果
                Console.WriteLine(formattedId);
            }
        }
    }
}
