//8.	WAP to print all negative elements in an array and also count total number of negative elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class Negatives
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int count=0;
            for (int i = 0; i < size; i++)
            {
                    a[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < size; i++)
            {
                if (i < 0)
                    Console.Write(a[i]+" ");
                count++;
            }
            Console.WriteLine("count is" +count);
        }
    }
}
