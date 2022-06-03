using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class Factors
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Factors of the number are: ");

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {

                    Console.Write(i + " ");
                }
            }


        }
    }
}
