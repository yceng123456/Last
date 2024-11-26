using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "I love programming in C#";
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }
    }
}
