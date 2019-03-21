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
        bool match = false;
        List<string> carMake = new List<string>() { "toyota", "subaru", "honda", "nissan", "bmw" };
        for (int i = 0; i < carMake.Count; i++)
        {
            if (carMake[i].Contains(search))
            {
                Console.WriteLine(i);
                match = true;
                break;
            }
        }
        if (match == false)
        {
            Console.WriteLine("No Matching Results!");
        }

        // #9 & #10
        Console.WriteLine("Please type a letter between a and f:");
        string search2 = Console.ReadLine();
        bool match2 = false;
        List<string> alphabet = new List<string>() { "a", "b", "c", "d", "d", "e", "f" };
        for( int i = 0; i < alphabet.Count; i++)
        {
            if (alphabet[i].Contains(search2))
            {
                Console.WriteLine(i);
                match2 = true;
            }
        }
        if (match2 == false)
        {
            Console.WriteLine("No Matching Results!");
        }

        // #11
        List<string> alphabet2 = new List<string>() { "a", "b", "c", "d", "d", "e", "f" };
        List<string> results = new List<string>();
        foreach( string i in alphabet2)
        {
            if (!results.Contains(i))
            {
                results.Add(i);
            }
            else
            {
                results.Add(i + "dup");
            }

        }
        foreach(string i in results)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
