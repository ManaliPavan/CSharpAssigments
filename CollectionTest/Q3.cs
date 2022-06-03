/*
 The encryption of alphabets are to be done as follows:	[2]

A=1,B=2,C=3,Z=26

The potential of a word is found by adding the encrypted value of the alphabets.

Example: KITE

Potential = 11 + 9 + 20 + 5 = 45

Accept a sentence Decode the words according to their potential and arrange them in ascending order.

Output the result in format given below:
 Input:THE SKY IS THE LIMIT.
 POTENTIAL:THE=33,SKY=55,IS=28,THE=33,LIMIT=63 
Output :IS THE THE SKY LIMIT
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q3
    {
        static void Main(string[] args)
        {
            /*
            ArrayList al = new ArrayList()
            {
                "THE" ,"SKY", "IS" ,"THE" ,"LIMIT"
            };
            */
            Console.WriteLine("Enter Sentence");
            string s = Console.ReadLine();
            string[] str1 = s.Split(" ");
            ArrayList al = new ArrayList();
            for(int i=0;i<str1.Length;i++)
            {
                al.Add(str1[i]);
            }
            SortedList al1 = new SortedList(al.Count);
            int[] arr = new int[al.Count];
            int k = 0;
            foreach (string d in al)
            {

                string str = d;
                int potential = 0;
                foreach (char c in d)
                {
                    potential += c - 'A' + 1;
                }
                al1.Add((potential,k) ,d);
                k++;
            }
            foreach (DictionaryEntry d1 in al1)
            {
                Console.WriteLine(d1.Value);
            }
        }
    }
}
         
       
  

