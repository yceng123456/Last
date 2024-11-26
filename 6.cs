using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "document.txt";
            bool result = filename.EndsWith(".txt");
            string output = result ? "檔案是 .txt 格式" : "檔案不是 .txt 格式";

            Console.WriteLine(output);
            Console.WriteLine();
        }
    }
}
