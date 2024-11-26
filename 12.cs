using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shoppingList = "apple, banana, cherry, date";
            int lastIndex = shoppingList.LastIndexOf(',');
            Console.WriteLine("The last index of ',' is: " + lastIndex);
        }
    }
}
