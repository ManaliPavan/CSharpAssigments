//10.WAP to find the maximum and minimum value in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class MaxMin
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            Console.WriteLine("Enter Array elements");
            int max = int.MinValue; //////Minvalue will assign minimum no (-214748...)
            int min = int.MaxValue;
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                if (min > arr[i])
                    min = arr[i];
                else if (arr[i] > max)
                    max = arr[i];
                else
                    continue;
            }
            Console.WriteLine("Min of Number" + min);
            Console.WriteLine("Max of Number" + max);
        }
    }
}
