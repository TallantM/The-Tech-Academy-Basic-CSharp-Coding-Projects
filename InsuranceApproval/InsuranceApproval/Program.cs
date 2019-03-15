using System;



class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Have you ever had a DUI? (Please answer \"true\" or \"false\").");
        bool dui = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("How many speeding tickets do you have?");
        int tickets = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qualified?");
        bool qualified = (age > 15 && dui == false && tickets <= 3);
        Console.WriteLine(qualified);

        Console.Read();
    }
}
