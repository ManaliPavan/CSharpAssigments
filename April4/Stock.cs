using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.April4
{
    class Stock
    {
        float openingprice;
        float closingprice;
        string stockname;
        public Stock()
        {
            Console.WriteLine("Constructor:");
            openingprice = 123.3f;
            closingprice = 176.3f;
            stockname = "CGpower";
           // Console.WriteLine(openingprice,closingprice,stockname);      ///we cannot display directly using , we use + concatinate sign
            Console.WriteLine(stockname+""+openingprice+""+closingprice);        
            Console.WriteLine(openingprice);
            Console.WriteLine(closingprice);
            Console.WriteLine(stockname);
            
        }
        public void SetOpeningPrice(float o)
        {
            openingprice = o;
        }
        public float GetOpeningPrice()
        {
            return openingprice;
        }

        public void SetClosingPrice(float c)
        {
            closingprice = c;
        }
        public float GetClosingPrice()
        {
            return closingprice;
        }

        public void SetStockName(string s)
        {
            stockname = s;
        }

        public string GetStockName()
        {
            return stockname;
        }

    }
    class TestStock
    {
        static void Main(string[] args)
        {
            Stock s1 = new Stock();
            Stock s2 = new Stock();
            Console.WriteLine("Enter OpeningPrice");
            s1.SetOpeningPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter ClosingPrice");
            s1.SetClosingPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter StockName");
            s1.SetStockName(Console.ReadLine());
            Console.WriteLine("Enter OpeningPrice");
            s2.SetOpeningPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter ClosingPrice");
            s2.SetClosingPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter StockName");
            s2.SetStockName(Console.ReadLine());
            Console.WriteLine($"Stock Details:\nOpeningPrice:{s1.GetOpeningPrice()}\nClosingPrice:{s1.GetClosingPrice()}\nStockName:{s1.GetStockName()}\n");
            Console.WriteLine($"Stock Details:\nOpeningPrice:{s2.GetOpeningPrice()}\nClosingPrice:{s2.GetClosingPrice()}\nStockName:{s2.GetStockName()}\n");
        }
    }
}

