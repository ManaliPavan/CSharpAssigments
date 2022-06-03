//1.WAP to find and count total number of duplicate elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class Duplicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
            
        }

    }
}
