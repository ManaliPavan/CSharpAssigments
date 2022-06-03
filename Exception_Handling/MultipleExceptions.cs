//WAP to catch multiple exceptions. i. IndexOutOfRangeException and DivideByZeroException

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exception_Handling
{
    class MultipleExceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            

            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Division{a / b}");
                Console.WriteLine("enter array elements");
                int[] arr = new int[5];
                for (int i = 0; i <=5; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());

                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception : Divide by Zero");

            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Excetion : {"+e.Message+"}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Excetion : Error" + "  {" + e.Message + "}");
            }
            finally
            {
                Console.WriteLine("in finally");
            }

        }
    }
}
