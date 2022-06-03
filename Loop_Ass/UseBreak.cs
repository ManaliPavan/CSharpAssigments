using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Loop_Ass
{
    class UseBreak
    {
        static void Main(string[] args)
        {



            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}