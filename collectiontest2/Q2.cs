//WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Employee
    {
        string name;
        string designation;
        int salary;

        public Employee(string name, string designation, int salary)
        {
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"Name {name} Designation {designation} Salary {salary}";
        }
    }
    class Q2
    {
        static void Main(string[] args)
        { 
            List<dynamic> l1= new List<dynamic>();
            l1.Add(new Employee ("Anvi", "Software Engg." , 18000));
            l1.Add(new Employee("Janvi","Software Dev.", 25000));
            l1.Add(new Employee("Jivika","Software tester",20000));
            l1.Add(new Employee("Sanvi", "Software Engg.", 19000));


            foreach(dynamic d in l1)
            {
                Console.WriteLine(d);
            }


        }
    }
}
