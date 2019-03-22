using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParamenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose another number (This number is optional).");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            Math example = new Math();

            int resultMath = example.Opperation(firstNumber, secondNumber);

            Console.WriteLine("Result = " + resultMath);




            Console.ReadLine();
        }
    }
}
