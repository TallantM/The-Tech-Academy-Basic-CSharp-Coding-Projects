using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        // #1
        Console.WriteLine("Please type a past tense verb: ");
        string verb = Console.ReadLine();
        string[] name = { "Michael ", "James ", "Freddy ", "Jason ", "Sarah ", "Lindsey " };
        for (int i = 0; i < name.Length; i++)
        {
            name[i] += verb;
            Console.WriteLine(name[i]);
        }

        // #2 Commented out because loop breaks the program
        //int number = 0;
        //while (true)
        //{
        //    Console.WriteLine(number++);
        //}

        // #3 & #4
        int number = 0;
        while (number < 10)
        {
            Console.WriteLine(number++);
        }

        // #5
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // #6, #7, & #8
        Console.WriteLine("Search Car Make list for:");
        string search = Console.ReadLine();
        List<string> carMake = new List<string>() { "toyota", "subaru", "honda", "nissan", "bmw" };
        foreach(string make in carMake)
        {
            if (!make.Contains(search))
            {
                Console.WriteLine(make);
                continue;
            }
            else
            {
                Console.WriteLine("Your search for " + search + " yeilded no results.");
                break;
            }
        }
        

        Console.ReadLine();
    }
}
