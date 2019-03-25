using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOverloadOutput
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number:");
            int userChoice = Convert.ToInt32(Console.ReadLine());


            Math example = new Math();

            example.Divide(userChoice, out int test);

            Console.WriteLine(test);

            Console.WriteLine("Please select another number:");
            int userChoiceSecond = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your second result is: " + Math.Opperation(userChoiceSecond));

            Console.WriteLine("Please select a final number:");
            double userChoiceThird = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your second result is: " + Math.Opperation(userChoiceThird));


            Console.ReadLine();
        }
    }
}
