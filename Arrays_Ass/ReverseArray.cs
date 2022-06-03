//5.	WAP to print reverse of an array. Also print every alternate element backwards.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int i, j = 0;
            Console.WriteLine("Enter array elements");
            for (i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
                Console.WriteLine(size%2);
                for (i = size - 1; i >= size / 2; i--)
                {

                    while (j <= size / 2)
                    {
                        int temp = 0;
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                        break;
                    }
                    j++;
                }
            
            
            Console.WriteLine("Reversed Array ");
            for (j = 0; j < size; j++)
            {
                Console.Write(a[j] + " ");
            }



        }
    }
}
