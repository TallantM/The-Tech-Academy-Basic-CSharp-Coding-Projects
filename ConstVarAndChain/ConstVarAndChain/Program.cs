using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarAndChain
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorChain example = new ConstructorChain("Michael");
            const string name = "Michael";
            
            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("What is your favorite food? ");
            var favFood = Console.ReadLine();

            Console.ReadLine();
            
        }
    }
}
