using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class Amicable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 1; i <= (num1 / 2); i++)
            {
                if (num1 % i == 0)
                {
                    sum1 = sum1 + i;
                }

            }
            for (int i = 1; i <= (num2 / 2); i++)
            {
                if (num2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (num1 == sum2 && num2 == sum1)
            {
                Console.WriteLine($"{num1} & {num2} are Amicable Numbers");
            }
            else
            {
                Console.WriteLine($"{num1} & {num2} are not Amicable Numbers");
            }
        }

    }
}
