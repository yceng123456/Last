using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.example.com";
            string domain = url.Substring(8);
            Console.WriteLine(domain);
        }
    }
}
