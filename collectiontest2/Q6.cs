//WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Q6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> d = new Dictionary<string, float>();
            d.Add("one", 1.1f);
            d.Add("two", 2.2f);
            d.Add("three", 3.3f);
            d.Add("four", 4.4f);
            d.Add("five", 5.5f);

            foreach (KeyValuePair<string,float> kvp in d)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
        }
    }
}
