using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string source = "hello world";
            char[] destination = new char[5];
            source.CopyTo(0, destination, 0, 5);
            Console.WriteLine(destination);
        }
    }
}
