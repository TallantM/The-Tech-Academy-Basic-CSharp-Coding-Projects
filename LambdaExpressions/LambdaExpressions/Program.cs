using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Smith", ID = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Watts", ID = 2 };
            Employee employee3 = new Employee() { FirstName = "Sarah", LastName = "Engles", ID = 3 };
            Employee employee4 = new Employee() { FirstName = "Mike", LastName = "Schmidt", ID = 4 };
            Employee employee5 = new Employee() { FirstName = "Shawn", LastName = "John", ID = 5 };
            Employee employee6 = new Employee() { FirstName = "Jake", LastName = "Edwards", ID = 6 };
            Employee employee7 = new Employee() { FirstName = "Brittney", LastName = "Wilson", ID = 7 };
            Employee employee8 = new Employee() { FirstName = "Jordan", LastName = "Jackson", ID = 8 };
            Employee employee9 = new Employee() { FirstName = "Michelle", LastName = "Boche", ID = 9 };
            Employee employee10 = new Employee() { FirstName = "Samuel", LastName = "Ryan", ID = 10 };

            List<Employee> employees = new List<Employee>()
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10

            };

            Console.WriteLine("Foreach Loop Joes:");
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID: " + employee.ID);
                }
            }

            Console.WriteLine("Lambda Expression Joes:");
            List<Employee> joes = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID: " + employee.ID);
            }

            Console.WriteLine("Lambda Expression Int:");
            List<Employee> ids = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in ids)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " ID: " + employee.ID);
            }


            Console.ReadLine();
        }
    }
}
