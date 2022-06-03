//WAP to create SortedList where key is of Integer type and value string and print all key-value pairs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Q5
    {
        static void Main(string[] args)
        {

            SortedList<int, string> ss = new SortedList<int, string>();
            ss.Add(1, "Java");
            ss.Add(2, "PHP");
            ss.Add(3, "C#");
            ss.Add(4, "C");

            foreach (var d in ss)
            {
                Console.WriteLine(d.Key + " : " + d.Value);
            }
        }
    }
}
