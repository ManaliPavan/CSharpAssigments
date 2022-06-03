using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Loop_Ass
{
    class SumOdd
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
