using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numver: ");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Michael J Tallant\Logs\log.txt", number);

            using (StreamReader reader = new StreamReader(@"C:\Users\Michael J Tallant\Logs\log.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                    Console.ReadLine();
                }
            }
        }
    }
}
