using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Loop_Ass
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
           
            int a = 0,b= 1;
            int sum = 0;
           
            Console.Write(a+" ");
            Console.Write(b+" ");
            for(int i=1;i<=10;i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.Write(sum+" ");
            }

        }
    }
}
