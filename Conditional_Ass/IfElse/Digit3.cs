using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class Digit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num;
            if(num>100 && num<999)
            {
                Console.WriteLine("Number is 3 digit");
                int sum = num%10;
                num = num / 100;
                sum = (int)sum+ (num % 10);
                Console.WriteLine("Sum of 1st and 3rd digit is"+sum);
            }
            else
                Console.WriteLine("Number is not 3 digit");
        }
    }
}
