using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Math example = new Math();

            int resultFirst = example.Opperation(firstNumber: 10);
            double resultSecond = example.Opperation(secondNumber: 0.5);
            string resultThird = example.Opperation(thirdNumber: "10");
            

            Console.WriteLine("First result = " + resultFirst);
            Console.WriteLine("Second result = " + resultSecond);
            Console.WriteLine("Third result = " + resultThird);



            Console.ReadLine();
        }
    }
}
