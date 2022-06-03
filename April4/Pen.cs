using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.April4
{
    class Pen
    {
        string brand;
        string color;
        int price;


        public Pen()
            {
            Console.WriteLine("Constructor:");
            brand = "Parker Pens";
            color = "Black";
            price = 2000;
            Console.WriteLine(brand+""+color+""+price);
            }
        public void SetBrand(string b)
        {
            brand = b;
        }
        public string GetBrand()
        {
            return brand;
        }

        public void SetColor(string c)
        {
            color = c;
        }
        public string GetColor()
        {
            return color;
        }

        public void SetPrice(int p)
        {
            price = p;
        }
        public int GetPrice()
        {
            return price;
        }
    }
    class TestPen
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            Pen p2 = new Pen();
            Console.WriteLine("Enter Pen Brand");
            p1.SetBrand(Console.ReadLine());
            Console.WriteLine("Enter Pen Color");
            p1.SetColor(Console.ReadLine());
            Console.WriteLine("Enter Pen Price");
            p1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Pen Brand");
            p2.SetBrand(Console.ReadLine());
            Console.WriteLine("Enter Pen Color");
            p2.SetColor(Console.ReadLine());
            Console.WriteLine("Enter Pen Price");
            p2.SetPrice(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"Pen Details:\nBrand:{p1.GetBrand()}\nColor:{p1.GetColor()}\nPrice:{p1.GetPrice()}\n");
            Console.WriteLine($"Pen Details:\nBrand:{p2.GetBrand()}\nColor:{p2.GetColor()}\nPrice:{p2.GetPrice()}\n");
        }
    }

}