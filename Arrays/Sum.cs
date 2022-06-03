using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8 };
            int[] c = new int[4];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (i == j)
                    { 
                        Console.WriteLine(" a " + a[i] + "  b " + b[j]);
                        c[i] = a[i] + b[j];
                    }
                }
            }
            Console.WriteLine();
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i] + " ");
                }
            
        }
    }
}
