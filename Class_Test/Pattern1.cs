/*              1
              2 2 2
            3 3 3 3 3
          4 4 4 4 4 4 4

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 7; i = i + 2)
            {
                for (int j = 7; j >= i; j--)
                {
                    Console.Write(" ");
                }




                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                }
                k++;
                Console.WriteLine();
            }

        }
    }
}
