using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("This number will now be Added, Subtracted, and Multiplied by 2.");

            Math example = new Math();

            int resultAdd = example.Add(userNumber);
            int resultSubtract = example.Subtract(userNumber);
            int resultMultiply = example.Multiply(userNumber);

            Console.WriteLine("Addition result = " + resultAdd);
            Console.WriteLine("Subtraction result = " + resultSubtract);
            Console.WriteLine("Multiplication result = " + resultMultiply);

            Console.ReadLine();
        }
    }
}
