//WAP to create a Queue with some colors (String) using generics.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    
    class Q3

    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Red");
            q.Enqueue("Blue");
            q.Enqueue("Green");
            q.Enqueue("Orange");
            q.Enqueue("White");

            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
        }
    }
}
