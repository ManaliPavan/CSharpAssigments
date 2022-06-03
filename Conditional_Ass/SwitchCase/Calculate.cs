using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("___________________");
            Console.WriteLine("1.Area of circle\n2.Area of square\n3.Area of right angled triangle\n 4.Area of rectangle\n5.Circumference of circle\n6.Perimeter of square");

            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter radius");
                    double r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of circle" + (3.14 * r * r));
                    break;
                case 2:
                    Console.WriteLine("Enter side");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of square" + (s * s));
                    break;
                case 3:
                    Console.WriteLine("Enter b & h");
                    double b = Convert.ToDouble(Console.ReadLine());
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of right angled triangle" + (0.5 * b * h));
                    break;
                case 4:
                    Console.WriteLine("Enter l & b");
                    double l = Convert.ToDouble(Console.ReadLine());
                    double br = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of rectangle" + (l * br));
                    break;
                case 5:
                    Console.WriteLine("Enter r");
                    double ra = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Circumference of circle" + (2 * 3.14 * ra));
                    break;
                case 6:
                    Console.WriteLine("Enter side");
                    double s1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Perimeter of side" + (4 * s1));
                    break;

                default:
                    Console.WriteLine("Invalid I/P");
                    break;
            }
        }
    }
}
