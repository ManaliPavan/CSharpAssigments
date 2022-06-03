//WAP to sort the elements of List that contains String objects. Print List

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Q1
    {
        static void Main(string[] args)
        {
            List<string> l1 = new List<string>()
            { "mango","apple","lemon","orange","grapes"};
            l1.Sort();
            foreach(string s in l1)
            {
                Console.Write(s+"  ");
            }

        }
    }
}
