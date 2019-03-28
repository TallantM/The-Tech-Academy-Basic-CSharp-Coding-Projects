using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number example = new Number();
            example.Amount = 5;

            Console.WriteLine(example.Amount);
            Console.ReadLine();
        }
    }
}
