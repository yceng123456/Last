using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "example@domain.com";
            char[] charArray = email.ToCharArray();
            bool hasInvalidChar = false;

            foreach (char c in charArray)
            {
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.')
                {
                    hasInvalidChar = true;
                    break;
                }
            }

            Console.WriteLine(hasInvalidChar ? "Invalid Email" : "Valid Email");
        }
    }
}
