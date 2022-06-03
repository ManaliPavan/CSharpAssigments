//7.WAP to insert an element in a specific position into an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class SpecificPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter position of array element");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array element");
            for (int i = pos; i < size; i++)
            {
                if(pos<=size)
                a[i] = int.Parse(Console.ReadLine());
                else
                    Console.WriteLine("invalid position");
            }
        }
    }
}
