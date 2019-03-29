using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            Console.WriteLine(current);

            Console.WriteLine("Please enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime newTime = current.AddHours(x);
            Console.WriteLine(newTime);
            Console.ReadLine();
        }
    }
}
