using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not leap Year");
        }
    }
}
