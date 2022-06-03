//WAP to create SortedList<Employee,string> where key is of Employee type and value is departmentname(string) he works in. SortedList should maintain data in descending order 
//of salary


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.collectiontest2
{

    class Employee2:IComparable
    {
        string name;
        string designation;
        int salary;

        public int CompareTo(object o)
        {
            Employee2 e = (Employee2)o;
            return salary.CompareTo(e.salary);
                
        }
        public Employee2(string name, string designation, int salary)
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
    class Q8
    {
       
        static void Main(string[] args)
        {
            SortedList<Employee2,string> s1 = new SortedList<Employee2,string>();
            s1.Add(new Employee2("Anvi", "Engineer", 20000), "Computer");
            s1.Add(new Employee2("Janvi", "Developer", 30000), "Computer");
            s1.Add(new Employee2("Aakruti", "Tester", 40000), "Computer");
            s1.Add(new Employee2("Manali", "Engineer", 50000), "Computer");
            s1.Add(new Employee2("Sonali", "Operations Executive", 60000), "Computer");
            foreach (KeyValuePair<Employee2,string> kvp in s1)
            {
                Console.WriteLine(kvp.Key+" : "+kvp.Value);
            }
        }
    
    }
}
