//3.	WAP to search for a given number in an array and accordingly print the index if exists.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class SearchInArray
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("enter element to search");
            int ele = Convert.ToInt32(Console.ReadLine());
            bool ispresent = false;
            Console.WriteLine("postion");
            for (int i = 0; i < a.Length; i++)
            {
                if (ele == a[i])
                    Console.WriteLine(i);
                ispresent = true;
            }
            if (ispresent == false)
                Console.WriteLine("Not present");

        }
    }
}
