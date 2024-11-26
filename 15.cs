using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\User\\Documents\\file.txt";
            string fileName = filePath.Remove(0, filePath.LastIndexOf('\\') + 1);
            Console.WriteLine(fileName);
        }
    }
}
