//Write a program to get a set of keys contained in HashTable and print whole HashTable using for each loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q6
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "Rose");
            ht.Add(2, "Jasmine");
            ht.Add(3, "Lilli");
            ht.Add(4, "Mogra");
            ht.Add(5, "Zinia");
            ht.Add(6, "Lotus");
            ICollection c = ht.Keys;
            foreach (int i in c)
            {
                Console.WriteLine(i + ":" + ht[i]);
            }
            Console.WriteLine("Enter key to update value");
            int value = Convert.ToInt32(Console.ReadLine());
            ht[value] = "updated";
            foreach (int i in c)
            {
                Console.WriteLine(i + ":" + ht[i]);
            }
        }
    }
}
