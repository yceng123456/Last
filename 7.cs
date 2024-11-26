using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Doe";
            string age = "30";
            string profession = "工程師";

            string result = string.Concat(firstName, " ", lastName, ", Age: ", age, ", Profession: ", profession);

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
