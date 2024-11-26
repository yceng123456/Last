using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shoppingList = "牛奶,麵包,雞蛋"; // 定義初始的購物清單
            int insertPosition = shoppingList.IndexOf("麵包"); // 找到"麵包"的位置
            string updatedList = shoppingList.Insert(insertPosition, "香蕉,"); // 插入"香蕉,"
            Console.WriteLine(updatedList); // 輸出更新後的清單

            // 預期輸出: 牛奶,香蕉,麵包,雞蛋
        }
    }
}
