using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
        Reprint:
            Console.WriteLine("Enter your choice");
            Console.WriteLine("___________________");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n");
            int ch = Convert.ToInt32(Console.ReadLine());

            if (ch == 1)
                Console.WriteLine("Addition :" + (num1 + num2));
            else if (ch == 2)
            {
                if (num1 > num2)
                    Console.WriteLine("Subtraction :" + (num1 - num2));
                else
                    Console.WriteLine("Subtraction :" + (num2 - num1));
            }
            else if (ch == 3)
                Console.WriteLine("Multiplication :" + (num1 * num2));
            else if (ch == 4)
            {
                if (num1 > num2)
                    Console.WriteLine("Division :" + (num1 / num2));
                else
                    Console.WriteLine("Division :" + (num2 / num1));
            }
            else
                    Console.WriteLine("Invalid I/P");
                    goto Reprint;
            }

        }
    }

