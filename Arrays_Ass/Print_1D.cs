//1.	WAP to add elements to single dimensional int array
//      and print elements from 1D array

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class Print_1D
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array elements");
            for(int i=0;i<size;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach(int d in a)
            {
                Console.Write(d+" ");
            }
        }
    }
}
/*
        o/p:
        Enter Array Size
        3
        Enter array elements
        1
        2
        3
        1 2 3
*/