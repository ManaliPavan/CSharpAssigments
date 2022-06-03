using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loop_Ass
{
    class GCD_LCM
    {
        static void Main(string[] args)
        {
            int gcd = 1,lcm=0,temp,max;
            Console.WriteLine("Enter Numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n1 && i <= n2; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    gcd = i;
                }
            } 
            Console.WriteLine("GCD"+gcd);

            for (int i = 1; i <= n1 && i <= n2; i++)
            {
                if (n1 > n2)
                    max = temp = n1;
                else
                    max = temp = n2;
                while (n1 != 0)
                {
                    if (max % n1 == 0 && max % n2 == 0)
                    {
                        lcm = max;
                        break;
                    }
                    max += temp;
                }
            }
                Console.WriteLine("LCM" + lcm);
            
        }
    }
}
