using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();

        Console.WriteLine("What page number?");
        string currentPage = Console.ReadLine();
        int pageNumber = Convert.ToInt32(currentPage);

        Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
        string help = Console.ReadLine();
        bool helpNeeded = Convert.ToBoolean(help);

        Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
        string positiveExpereince = Console.ReadLine();

        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string additionalFeedback = Console.ReadLine();

        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();

        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        Console.Read();
    }
}

