using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        Console.WriteLine("What is the weight of your package in lbs.");
        int weight = Convert.ToInt32(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.Read();
        }
        else
        {
            Console.WriteLine("What is the package width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the package length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int volume = width * height * length;

            if (volume > 50)
            {
                Console.WriteLine("Package to big to be shipped via Package Express.");
                Console.Read();
            }
            else
            {
                decimal quote = (volume * weight) / 100;
                Console.WriteLine("Your estimated shipping cost is $" + quote + ".");
                Console.Read();
            }
        }
    }
}
