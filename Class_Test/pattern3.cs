/*  12345
    ABCD
    123
    AB
    1
    AB
    123
    ABCD
    12345  */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class pattern3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                char ch = 'A';
                int k = 1;
                for (int j = 5; j >= i; j--)
                {

                    if (i % 2 != 0)
                    {
                        Console.Write(k);
                        k++;
                    }

                    else
                    {

                        Console.Write(ch);
                        ch++;
                        //Console.Write(char()(64+j));
                    }

                }
                Console.WriteLine();
            }
            for (int i = 2; i <= 5; i++)
            {
                char ch = 'A';
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(ch);
                        ch++;
                        //Console.Write(char()(64+j));
                    }

                    else
                    {

                        Console.Write(j);

                    }

                }
                Console.WriteLine();
            }

        }
    }
}
