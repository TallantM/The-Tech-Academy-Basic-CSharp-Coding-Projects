using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee();
            employeeA.FirstName = "Sample";
            employeeA.LastName = "Student";
            employeeA.ID = 1;

            Employee employeeB = new Employee();
            employeeB.FirstName = "Sample";
            employeeB.LastName = "Student";
            employeeB.ID = 1;

            employeeA.SayName();
            employeeB.SayName();

            bool result = employeeA == employeeB;

            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
