//Create a HashTable  where key is integers 1 to 10 and string is number in Words. Remove entry for which number is divisible by 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add(5, "five");
            ht.Add(6, "six");
            ht.Add(7, "seven");
            ht.Add(8, "eight");
            ht.Add(9, "nine");
            ht.Add(10, "ten");
            DictionaryEntry [] darr = new DictionaryEntry[ht.Count];
            ht.CopyTo(darr, 0);
            for (int i = 0; i < darr.Length; i++)
            {
                dynamic k = darr[i].Key;
                if (k % 3 == 0)
                    ht.Remove(k);
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+" : "+d.Value);
            }
        }
    }

}
