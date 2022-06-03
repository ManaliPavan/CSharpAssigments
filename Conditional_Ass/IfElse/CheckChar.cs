using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class CheckChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter character");
            char ch = Convert.ToChar(Console.Read());
            if (ch > 'a' && ch < 'z' || ch > 'A' && ch < 'Z')
                Console.WriteLine("Alphabet");
            else if (ch > '0' && ch < '9')
                Console.WriteLine("Digit");
            else
                Console.WriteLine("Special Character");
        }
    }
}
