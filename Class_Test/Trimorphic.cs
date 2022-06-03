using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            int copy = num;
            while (copy > 0)
            {
                copy = copy / 10;
                count = count * 10;
            }
            int cube = num * num * num;
            int digit = cube % (count);

            if (digit == num)
            {
                Console.WriteLine($"{num} is Trimorphic");
            }
            else
            {
                Console.WriteLine($"{num} isn't Trimorphic");
            }
        }
    }
}
