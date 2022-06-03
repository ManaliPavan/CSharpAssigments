using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class NumberWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number(1-5)");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(num+"   ONE");
                    break;
                case 2:
                    Console.WriteLine(num+"   TWO");
                    break;
                case 3:
                    Console.WriteLine(num+"   THREE");
                    break;
                case 4:
                    Console.WriteLine(num+"   FOUR");
                    break;
                case 5:
                    Console.WriteLine(num +"  FIVE");
                    break;
                default:
                    Console.WriteLine("Number must be b/w 1-5");
                    break;
            }
        }
    }
}
