using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays
{
    class Concatenate
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4 };
            int[] b = { 90, 91, 92, 93, 94, 95 };
            int[] c = new int[a.Length+b.Length];
            int k = 0;
                for (int i = 0; i < a.Length; i++)                   ///this loop is known as index based
                {
                    c[i] = a[i];
                k++;
                }
                for (int j = 0; j < b.Length; j++)
                {
                    c[k] = b[j];                 //or c[j+a.Length]=b[j]; 
                k++;
                }
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i] + " ");
                }
            //or  for display array 

            /*               foreach(int d in c)                    ///will work in only forward direction printing
                           Console.WriteLine(d);

                //or
                
                Array.ForEach(c,Console.WriteLine);

           */




            ///////////////////////////or......../////////////////////
            ///Logic with only one loop
            /*           for (int i = 0; i < a.Length; i++)
                       {
                           if (i < a.Length)
                           {
                               c[i] = a[i];
                           }
                           else
                               c[i] = b[i-a.Length];
                       }
            */
        }
    }
}

