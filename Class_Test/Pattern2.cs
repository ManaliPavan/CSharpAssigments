/*  * * * * *
    * * * *
    * * *
    * *
    *

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        }
}
