/*ArrayList Contains 
al.Add("pune");
al.Add("Mumbai");
al.Add("pune");
al.Add("Mumbai");
al.Add("Nasik");
al.Add("pune");
Create a HashTable which contain String as key and Integer as value key is name of city and value is frequency of that city.
("pune",3);
("Mumbai", 2);
Print hashtable using Foreach loop.
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            Hashtable ht = new Hashtable();
            int Tcount = 0;
            string k=null;
            foreach (string d in al)
            {
                k = d;
                if (al.Contains(d))
                    Tcount++;
            }
            ht.Add(k,Tcount);

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key+":"+d.Value);
            }
        }
    }
}
