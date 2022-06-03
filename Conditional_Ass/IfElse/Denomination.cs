using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class Denomination
    {
        static void Main(string[] args)
        {
            int note;
            Console.WriteLine("Enter amount");
            int amt = Convert.ToInt32(Console.ReadLine());
            //2000,500,200,100,50,20,10,1
            if (amt > 2000)
            {
                note = amt / 2000;
                amt = amt % 2000;
                Console.WriteLine(note + "of 2000");
            }
            if (amt > 500)
            {
                note = amt / 500;
                amt = amt % 500;
                Console.WriteLine(note + "of 500");
            }
            if (amt > 200)
            {
                note = amt / 200;
                amt = amt % 200;
                Console.WriteLine(note + "of 200");
            }
            if (amt > 100)
            {
                note = amt / 100;
                amt = amt % 100;
                Console.WriteLine(note + "of 100");
            }

            if (amt > 50)
            {
                note = amt / 50;
                amt = amt % 50;
                Console.WriteLine(note + "of 50");
            }
            if (amt > 20)
            {
                note = amt / 20;
                amt = amt % 20;
                Console.WriteLine(note + "of 20");
            }
            if (amt > 10)
            {
                note = amt / 10;
                amt = amt % 10;
                Console.WriteLine(note + "of 10");
            }
            if (amt > 1)
            {
                note = amt / 1;
                Console.WriteLine(note + "of 1");
            }
        }
    }

}
