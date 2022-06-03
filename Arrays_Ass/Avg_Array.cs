//  2.	WAP to accept dimension of 1D array and create and accept data in that array.
//      Calculate the average value of array elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class Avg_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array elements");
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            int avg = sum / size;
            Console.WriteLine("Avg of array elements "+avg);
        }

    }
}

/*
       o/p:
        Enter Array Size
        4
        Enter array elements
        1
        2
        3
        4
        Avg of array elements 2
*/
