using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class Max3No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2 || num1>num3)
            {
                Console.WriteLine(num1 + "is greater");
            }
            else if(num2>num3)
            {
                Console.WriteLine(num2 + "is greater");
            }
            else
            {
                Console.WriteLine(num3 + "is greater");
            }

        }
    }
}
