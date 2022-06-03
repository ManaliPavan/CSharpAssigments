using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class DivisibleNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%5==0)
                Console.WriteLine("Number is divisible by 5");
            else if(num%11==0)
                Console.WriteLine("number is divisible by 11");
            else
                Console.WriteLine("Number is not divisible by 5/11");
        }
    }
}
