//15.	WAP to accept data in 2D array where rows are fixed and columns are variable.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Arrays_Ass
{
    class Array2D1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter column size");
            int csize = int.Parse(Console.ReadLine());
            int[,] a2 = new int[3, csize];

            for (int r = 0; r < a2.GetLength(0); r++)
            {
                Console.WriteLine("Enter row elements of row " + r);
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    a2[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < a2.GetLength(0); r++)
            {
                for (int c = 0; c < a2.GetLength(1); c++)
                {
                    Console.Write(a2[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
