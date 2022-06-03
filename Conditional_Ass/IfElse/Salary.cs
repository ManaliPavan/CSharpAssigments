using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.day2.assignment
{
    class Salary    {
        static void Main(string[] args)
        {
            double gross_sal;
            Console.WriteLine("Enter Salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            if (sal <= 10000)
            {
                double HRA = 0.2 * sal;
                double DA = 0.8 * sal;
                gross_sal = sal + HRA + DA;
                Console.WriteLine("Gross salary" + gross_sal);
            }
            else if (sal <= 20000)
            {
                double HRA = 0.25 * sal;
                double DA = 0.9 * sal;
                gross_sal = sal + HRA + DA;
                Console.WriteLine("Gross salary" + gross_sal);
            }
            else if (sal > 20000)
            {
                double HRA = 0.3 * sal;
                double DA = 0.95 * sal;
                gross_sal = sal + HRA + DA;
                Console.WriteLine("Gross salary" + gross_sal);
            }
        }
    }
}
