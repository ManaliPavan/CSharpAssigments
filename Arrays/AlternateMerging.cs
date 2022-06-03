using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class AlternateMerging
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 90, 91, 92, 93, 94, 95 };
            int[] c = new int[a.Length + b.Length];
            int j = 0;
            for (int i = 0; i < c.Length;)
            {
                if (j < a.Length && j < b.Length)
                {
                    c[i] = a[j];
                    i++;
                    c[i] = b[j];
                    i++;
                }
                else if (j < a.Length)
                {
                    c[i] = a[j];
                    i++;
                }

                else
                {
                    c[i] = b[j];
                    i++;
                }
                j++;
            }
            foreach(int d in c)
            {
                Console.Write(d+" ");
            }
            
        }
    }
}
