using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class HarshadNo
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                temp = temp / 10;
            }

            if (num % sum == 0)
            {
                Console.WriteLine($"{num} is Harshad Number");
            }
            else
            {
                Console.WriteLine($"{num} not Harshad Number");
            }

        }
        }
    }
