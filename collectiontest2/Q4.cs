//WAP to add user defined objects of type Employee in a HashSet employee object.
//Make sure if I create 2 different objects with same data the other one should not be
//added as hashset stores unique objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{
    class Employee1
    {
        string name;
        string designation;
        int salary;
        public override bool Equals(object obj)
        {
            Employee1 e = (Employee1)obj;
            return
                  name == e.name && 
                  designation == e.designation && 
                  salary == e.salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name,designation,salary);
        }
        public Employee1(string name, string designation, int salary)
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
            return $"Name : {name} Designation : {designation} Salary : {salary}";
        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            HashSet<Employee1> h1 = new HashSet<Employee1>();
            h1.Add(new Employee1("Anvi", "Software Engg.", 18000));
            h1.Add(new Employee1("Janvi", "Software Dev.", 25000));
            h1.Add(new Employee1("Jivika", "Software tester", 20000));
            h1.Add(new Employee1("Sanvi", "Software Engg.", 19000));
            h1.Add(new Employee1("Sanvi", "Software Engg.", 19000));
            foreach (var value in h1)
            {
                Console.WriteLine(value);
            }
        }
    }
}
