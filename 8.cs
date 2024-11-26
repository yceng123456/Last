using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "Secure123";
            string userInput = "Secure123";

            bool result = correctPassword.Equals(userInput);

            if (result)
            {
                Console.WriteLine("密碼正確，登錄成功！");
            }
            else
            {
                Console.WriteLine("密碼錯誤，請重新輸入。");
            }
            Console.WriteLine();
        }
    }
}
