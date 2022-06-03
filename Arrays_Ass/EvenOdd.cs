//9.	WAP to put even and odd elements of array in two separate arrays.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            int[] even = new int[size];
            int[] odd = new int[size];
            Console.WriteLine("Enter array elements");

            for (int i = 0; i < size; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < size; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[i] = a[i];
                }
                else
                    odd[i] = a[i];
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(even[i]);
                Console.WriteLine();
                Console.Write(odd[i]);
            }
        }

    }
}

