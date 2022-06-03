/*
         5
        5 4
       5 4 3
      5 4 3 2
     5 4 3 2 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern40.NumberPattern
{
    class Pattern5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int k = 5;
                for (int space = 5; space >= i; space--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k--;
                }
                Console.WriteLine();
            }
        }
    }
}
