using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class BouncyNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isIncrease = true;
            bool isDecrease = true;
            int next = a % 10;
            a = a / 10;
            while (a > 0)
            {
                int prev = a % 10;
                if (prev > next)
                {
                    isIncrease = false;
                }
                else if (prev < next)
                {
                    isDecrease = false;
                }
                next = prev;
                a = a / 10;
            }
                if (isIncrease && isDecrease)
                {
                    Console.WriteLine(" All are Equal");
                }
                else if(isIncrease)
                {
                    Console.WriteLine("Incresing number");
                }
                else if (isDecrease)
                {
                    Console.WriteLine("Decresing number");
                }
            
        }

    }

}
