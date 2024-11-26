using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "cherry" };
            string result = string.Join(",", fruits);

            Console.WriteLine("合併後的字串為: " + result);
            Console.ReadLine();
        }
    }
}
