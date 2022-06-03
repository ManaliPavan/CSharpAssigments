//Make use of such collection that stores moviename such that last entered movie is first
//deleted and accordingly previous one

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Q7
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("KGf");
            s.Push("BoolBhulaiya");
            s.Push("Attack");
            s.Push("Pushpa");
            s.Push("Spiderman");
            foreach(string ss in s)
            {
                Console.WriteLine(ss);
            }
            Console.WriteLine("Deleted...");
            Console.WriteLine(s.Pop());

        }
    }
}
