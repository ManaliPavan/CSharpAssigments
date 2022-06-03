using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product = 1;
            while (n > 0)
            {
                int r = n % 10;
                sum = sum + r;
                product = product * r;
                n = n / 10;
            }
            if (sum == product)
                Console.WriteLine("Spy Number");
            else
                Console.WriteLine("Not Spy Number");
        }
    }
}
