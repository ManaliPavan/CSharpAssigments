using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.Loop_Ass
{
    class OddList
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}