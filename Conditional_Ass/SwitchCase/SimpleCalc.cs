using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class SimpleCalc
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

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Addition :" + (num1 + num2));
                    break;
                case 2:

                    if (num1 > num2)
                        Console.WriteLine("Subtraction :" + (num1 - num2));
                    else
                        Console.WriteLine("Subtraction :" + (num2 - num1));
                    break;
                case 3:
                    Console.WriteLine("Multiplication :" + (num1 * num2));
                    break;
                case 4:

                    if (num1 > num2)
                        Console.WriteLine("Division :" + (num1 / num2));
                    else
                        Console.WriteLine("Division :" + (num2 / num1));
                    break;
                default:
                    Console.WriteLine("Invalid I/P");
                    goto Reprint;
            }
        }
    }
}