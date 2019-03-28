using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "A", "B", "C" };

            foreach (string item in employee1.Things)
            {
                Console.WriteLine(item);
            }

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3 };

            foreach (int item in employee2.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
