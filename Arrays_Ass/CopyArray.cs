//4.	WAP to copy an array by iterating the array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int[] b = new int[size];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                b[i] = a[i];

            }
            Console.Write("b[] =");
            foreach(int d in b)
            {
                Console.Write(d+" ");
            }
        }
    }
}

/*
        Enter Array Size
        3
        Enter array elements
        1
        2
        3
        b[] =1 2 3
*/
