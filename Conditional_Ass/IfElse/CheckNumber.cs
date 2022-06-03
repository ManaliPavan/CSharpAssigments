using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class CheckNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            if(num>0)
                Console.WriteLine("Number is positive");
            else if(num<0)
                Console.WriteLine("Number is negative");
            else
                Console.WriteLine("Its zero");
        }
    }
}
