using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.April4
{
    class MethodOverloading
    {
        void Add(float a, float b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, int b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(int a, float b)
        {
            Console.WriteLine("Sum" + (a + b));
        }
        void Add(float a, int b)
        {
            Console.WriteLine("Sum" + (a + b));
        }


        static void Main(string[] args)
        {
            //Calculator.Add(12,4);
            MethodOverloading m = new MethodOverloading();
            m.Add(1, 2);
            m.Add(1.1f, 2);
            m.Add(1, 2.2f);
            m.Add(1, 2, 4);
            m.Add(1.1f, 2.2f);
        }
    }
}

