/*      1
        12
        123
        1234
        12345
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern40.NumberPattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
