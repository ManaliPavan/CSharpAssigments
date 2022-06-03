//Write a program to get the value of a specified key in a HashTable
//and also update the value for given key.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q5
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
            Console.WriteLine("Enter key to update value(1-6)");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter value for key({key})");
            string value = Console.ReadLine();
            ht[key] = value;
                Console.WriteLine(key + " : " + value);
        }
    }
}
   

