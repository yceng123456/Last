using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "您好 [名字] 歡迎登入";
            string result = str.Replace("[名字]", "王曉明");
            Console.WriteLine(result);
        }
    }
}
