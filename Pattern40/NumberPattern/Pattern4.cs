/*
        5 4 3 2 1
        5 4 3 2
        5 4 3
        5 4
        5
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern40.NumberPattern
{
    class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
