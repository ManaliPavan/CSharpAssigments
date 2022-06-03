/*
 * Assume you have Arraylist  al = new ArrayList ();
al.Add("Sun");
al.Add("Mon");
al.Add("Sat");
al.Add("Sun ");
al.Add("Mon ");
al.Add("Sat ");
al.Add("Sun ");
al.Add("Sat ");
al.Add("Sun ");
al.Add("Mon ");
Write a code to remove duplicate elements from above list. 
         Final Arraylist should contain ( Sun, Mon, Sat); 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HomeWork.CollectionTest
{
    class Q1
    {
        static void Main(string[] args)
        {


            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat"); 
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Mon");

            /*//rather removing in same arraylist create other w/o duplicates
             ArrayList al1 = new ArrayList();
             foreach(string s in al)
             {
                 if(!al1.Contains(s))
                 {
                     al1.Add(s);
                 }
             }
             foreach (string s in al1)
             {
                 Console.WriteLine(s);
             }
            */
            dynamic[] arr = new dynamic[al.Count];
            al.CopyTo(arr);
            for (int i = 0; i < al.Count; )
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                   if(arr[i]==arr[j] && j<i)
                    {
                        break;
                    }
                    else if (arr[i].ToString() == arr[j].ToString())
                    {
                        al.Remove(arr[j]);
                    
                    }
                }
                i++;
            }
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
        }
    }
}
