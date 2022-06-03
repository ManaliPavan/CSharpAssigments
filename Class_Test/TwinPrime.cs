using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class TwinPrime
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());


            bool flag1 = true;
            bool flag2 = true;
            for (int i = 2; i <= (num1 / 2); i++)
            {
                if (num1 % i == 0)
                {
                    flag1 = false;
                    break;
                }

            }

            for (int i = 2; i <= (num2 / 2); i++)
            {
                if (num2 % i == 0)
                {
                    flag2 = false;
                    break;
                }
            }



            if (flag1 == true && flag2 == true)
            {
                int diff = num1 - num2;
                if (diff == 2 || diff == -2)
                    Console.WriteLine("Given numbers are Twin Primes");
                else
                    Console.WriteLine("Given numbers are not Twin Primes");
            }
            else
                Console.WriteLine("One of the Given numbers is not Prime");

        }
    }
}
