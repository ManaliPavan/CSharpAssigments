using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Class_Test
{
    class IMEI_No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter IMEI number");
            long a = Convert.ToInt64(Console.ReadLine());
            long n = a;
            long c = 0;
           
            while(a>0)
            {
                c++;
                a = a / 10;
            }
            a = n;
            if(c==15)
            {
                int sum = 0;
                for (int i = 1; i <= 15; i++)
                {
                    int digit = (int)(a % 10);
                    if (i % 2 == 0)
                    {
                        int twice = 2*digit;
                        if (twice > 9)
                        {
                            sum = sum + twice % 10 + twice / 10;
                        }
                        else
                            sum = sum + digit;
                        a = a / 10;
                    }
                    else
                    {
                        sum = sum + digit;
                    }
                }
                    if(sum%10==0)
                    {
                        Console.WriteLine("Valid IMEI Number");
                    }
                    else
                        Console.WriteLine("invalid IMEI Number");
                }
           

          else
                Console.WriteLine("Not 15 Digit Number");
           
        }
    }
}
