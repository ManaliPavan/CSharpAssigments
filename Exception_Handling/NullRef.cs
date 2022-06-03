//WAP to use catch / handle NullReferenceRange exception.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exception_Handling
{
    class NullRef
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Student Details:RollNo\nName\nStd\n");
                string rollno=null;
                string name = "Manali";
                string std = "10th";
                rollno=rollno.ToLower();              
                Console.WriteLine($"Details:\n{rollno}\t{name}\t{std}");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Error :  {"+e.Message+"}");
            }
                }
    }


}
