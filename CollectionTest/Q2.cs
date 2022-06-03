//Sort Arraylist of String in reverse order of its natural sorting.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q2
    {
        static void Main(string[] args)
        {


            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("one");
            al.Add("two");
            al.Add("five");
            al.Add("six");
            al.Add("seven ");
            al.Add("three ");
            al.Add("four");
            al.Reverse();
            foreach(string d in al)
            {
                Console.WriteLine(d);
            }
        }
    }
}
